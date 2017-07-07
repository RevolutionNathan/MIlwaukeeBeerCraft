using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using MilwaukeeBeerCraft.App_Start;
using MilwaukeeBeerCraft.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Google.Apis.Calendar.v3.CalendarService;


namespace MilwaukeeBeerCraft.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }
        
        private readonly IDataStore dataStore = new FileDataStore(GoogleWebAuthorizationBroker.Folder);

        //private async Task<UserCredential> GetCredentialForApiAsync()
        //{
        //    var initializer = new GoogleAuthorizationCodeFlow.Initializer
        //    {
        //        ClientSecrets = new ClientSecrets
        //        {
        //            ClientId = MyClientSecrets.ClientId,
        //            ClientSecret = MyClientSecrets.ClientSecret,
        //        },
        //        Scopes = MyRequestedScopes.Scopes,
        //    };
        //    var flow = new GoogleAuthorizationCodeFlow(initializer);

        //    var identity = await HttpContext.GetOwinContext().Authentication.GetExternalIdentityAsync(DefaultAuthenticationTypes.ApplicationCookie);
        //    var userId = "nathan@milwaukeebeercraft.com"; /*identity.FindFirstValue(MyClaimTypes.GoogleUserId);*/

        //    var token = await dataStore.GetAsync<TokenResponse>(userId);
        //    return new UserCredential(flow, userId, token);
        //}
        
        // GET: /Calendar/UpcomingEvents
        public async Task<ActionResult> UpcomingEvents()
        {
            const int MaxEventsPerCalendar = 20;
            const int MaxEventsOverall = 50;
            string[] Scopes = { CalendarService.Scope.CalendarReadonly };

            var model = new UpcomingEventsViewModel();

            //var credential = await GetCredentialForApiAsync();
            UserCredential credential;

            using (var stream =
                new FileStream(@"\\Mac\Home\Desktop\devCode\C#\MilwaukeeBeerCraft\MilwaukeeBeerCraft\Content\client_secret.json", FileMode.Open, FileAccess.Read))
            { 
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var initializer = new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Milwaukee Beer Craft",
            };
            var service = new CalendarService(initializer);

            // Fetch the list of calendars.
            var calendars = await service.CalendarList.List().ExecuteAsync();
            // Fetch some events from each calendar.
            var fetchTasks = new List<Task<Google.Apis.Calendar.v3.Data.Events>>(calendars.Items.Count);
            foreach (var calendar in calendars.Items)
            {
                var request = service.Events.List(calendar.Id);
                request.MaxResults = MaxEventsPerCalendar;
                request.SingleEvents = true;
                request.TimeMin = DateTime.Now;
                fetchTasks.Add(request.ExecuteAsync());
            }
            var fetchResults = await Task.WhenAll(fetchTasks);

            // Sort the events and put them in the model.
            var upcomingEvents = from result in fetchResults
                                    from evt in result.Items
                                    where evt.Start != null
                                    let date = evt.Start.DateTime.HasValue ?
                                        evt.Start.DateTime.Value.Date :
                                        DateTime.ParseExact(evt.Start.Date, "yyyy-MM-dd", null)
                                    let sortKey = evt.Start.DateTimeRaw ?? evt.Start.Date
                                    orderby sortKey
                                    select new { evt, date };
            var eventsByDate = from result in upcomingEvents.Take(MaxEventsOverall)
                                group result.evt by result.date into g
                                orderby g.Key
                                select g;

            var eventGroups = new List<CalendarEventGroup>();
            foreach (var grouping in eventsByDate)
            {
                eventGroups.Add(new CalendarEventGroup
                {
                    GroupTitle = grouping.Key.ToLongDateString(),
                    Events = grouping,
                });
            }

            model.EventGroups = eventGroups;
            return View(model);
        }

    }
}