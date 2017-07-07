using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MilwaukeeBeerCraft.Models;

namespace MilwaukeeBeerCraft.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BeerListObject> BeerListObject
        { get; set; }
        public DbSet<BeerStyles> BeerStyles
        { get; set; }
        public DbSet<Category> Category
        { get; set; }
        public DbSet<ListOfBeerLists> ListOfBeerLists
        { get; set; }
        public DbSet<MilwaukeeBreweries> MilwaukeeBreweries
        { get; set; }
        public DbSet<Post> Post
        { get; set; }

        public DbSet<UntappedBrewery> UntappedBrewery
        { get; set; }
        public DbSet<ResponseTime> ResponseTime
        { get; set; }
        public DbSet<InitTime> InitTime
        { get; set; }
        public DbSet<Meta> Meta
        { get; set; }
        public DbSet<Beer> Beer
        { get; set; }
        public DbSet<Contact> Contact
        { get; set; }
        public DbSet<Location> Location
        {get; set;}
        public DbSet<Brewery> Brewery
        { get; set; }
        public DbSet<Item> Item
        { get; set; }
        public DbSet<Beers> Beers
        { get; set; }
        public DbSet<Response> Response
        { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}