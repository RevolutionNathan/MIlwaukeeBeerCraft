using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilwaukeeBeerCraft.Models;
using FluentNHibernate.Mapping;

namespace MilwaukeeBeerCraft.Mapping
{
    public class BreweryMap : ClassMap<Brewery>
    {

        public BreweryMap()
        {
            Id(x => x.Id);

            HasManyToMany(x => x.Posts)
                .Cascade.All().Inverse()
                .Table("Title");

            Map(x => x.GoodCity)
                .Length(5)
                .Nullable();

            Map(x => x.ThirdSpace)
                .Length(5)
                .Nullable();

            Map(x => x.MobCraft)
                .Length(5)
                .Nullable();

            Map(x => x.MilWaukeeBrewing)
                .Length(5)
                .Nullable();

            Map(x => x.LakefrontBrewery)
                .Length(5)
                .Nullable();

            Map(x => x.BrennerBrewing)
                .Length(5)
                .Nullable();

            Map(x => x.EagleParkBrewing)
                .Length(5)
                .Nullable();

            Map(x => x.Enlightened)
                .Length(5)
                .Nullable();

            Map(x => x.D14)
                .Length(5)
                .Nullable();

            Map(x => x.StFrancis)
                .Length(5)
                .Nullable();

            Map(x => x.CompanyBrewing)
                .Length(5)
                .Nullable();

            Map(x => x.GatheringPlace)
                .Length(5)
                .Nullable();

            Map(x => x.CityLights)
                .Length(5)
                .Nullable();

            Map(x => x.BrokenBat)
                .Length(5)
                .Nullable();

            Map(x => x.BlackHusky)
                .Length(5)
                .Nullable();

            Map(x => x.NewBarons)
                .Length(5)
                .Nullable();

            Map(x => x.Sprecher)
                .Length(5)
                .Nullable();

            Map(x => x.RaisedGrain)
                .Length(5)
                .Nullable();

            Map(x => x.Fermentorium)
                .Length(5)
                .Nullable();
            Map(x => x.UrlSlug)
                .Length(200)
                .Not.Nullable();

        }
    }
}