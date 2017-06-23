using System.Collections.Generic;

namespace MilwaukeeBeerCraft.Models
{
    public class Brewery
    {
        public virtual int Id
        { get; set; }
        public virtual string Name
        { get; set; }
        public virtual string UrlSlug
        { get; set; }
        public virtual bool GoodCity
        { get; set; }
        public virtual bool ThirdSpace
        { get; set; }
        public virtual bool MobCraft
        { get; set; }
        public virtual bool MilWaukeeBrewing
        { get; set; }
        public virtual bool LakefrontBrewery
        { get; set; }
        public virtual bool BrennerBrewing
        { get; set; }
        public virtual bool EagleParkBrewing
        { get; set; }
        public virtual bool Enlightened
        { get; set; }
        public virtual bool D14
        { get; set; }
        public virtual bool StFrancis
        { get; set; }
        public virtual bool CompanyBrewing
        { get; set; }
        public virtual bool GatheringPlace
        { get; set; }
        public virtual bool CityLights
        { get; set; }
        public virtual bool BrokenBat
        { get; set; }
        public virtual bool BlackHusky
        { get; set; }
        public virtual bool NewBarons
        { get; set; }
        public virtual bool Sprecher
        { get; set; }
        public virtual bool RaisedGrain
        { get; set; }
        public virtual bool Fermentorium
        { get; set; }
        public virtual ICollection<Post> Posts
        { get; set; }


    }
}