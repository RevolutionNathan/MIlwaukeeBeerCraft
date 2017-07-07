using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Calendar.v3;


namespace MilwaukeeBeerCraft.App_Start
{
    public class MyRequestedScopes
    {
        public static string[] Scopes
        {
            get
            {
                return new[] {
                    "openid",
                    "email",
                    CalendarService.Scope.CalendarReadonly,
                };
            }
        }
    }
}