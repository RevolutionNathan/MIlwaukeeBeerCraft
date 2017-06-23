using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilwaukeeBeerCraft.Models;
using FluentNHibernate.Mapping;

namespace MilwaukeeBeerCraft.Mapping
{
    public class BeersMap: ClassMap<Beers>
    {
        public BeersMap()
        {
            Id(x => x.Id);

            HasManyToMany(x => x.Posts)
                .Cascade.All().Inverse()
                .Table("Title");
            
            Map(x => x.UrlSlug)
                .Length(200)
                .Not.Nullable();
            Map(x => x.AmericanAmber)
                .Length(5)
	            .Nullable();
            Map(x => x.RedAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanBarleywine)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanBlackAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanBlondeAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanBrownAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanDarkWheatAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanDoubleIPA)
             .Length(5) 
                .Nullable();
            Map(x => x.ImperialIPA)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanDoubleStout)
                .Length(5)
                .Nullable();
            Map(x => x.ImperialStout)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanIPA)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanPaleAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanPaleWheatAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanPorter)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanStout)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanStrongAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanWildAle)
                .Length(5)
                .Nullable();
            Map(x => x.BlackTan)
                .Length(5)
                .Nullable();
            Map(x => x.ChileBeer)
                .Length(5)
                .Nullable();
            Map(x => x.CreamAle)
                .Length(5)
                .Nullable();
            Map(x => x.PumpkinAle)
                .Length(5)
                .Nullable();
            Map(x => x.RyeBeer)
                .Length(5)
                .Nullable();
            Map(x => x.Wheatwine)
                .Length(5)
                .Nullable();
            Map(x => x.BelgianDarkAle)
                .Length(5)
                .Nullable();
            Map(x => x.BelgianIPA)
                .Length(5)
                .Nullable();
            Map(x => x.BelgianPaleAle)
                .Length(5)
                .Nullable();
            Map(x => x.BelgianStrongDarkAle)
                .Length(5)
                .Nullable();
            Map(x => x.BelgianStrongPaleAle)
                .Length(5)
                .Nullable();
            Map(x => x.BièredeGarde)
                .Length(5)
                .Nullable();
            Map(x => x.Dubbel)
                .Length(5)
                .Nullable();
            Map(x => x.Faro)
                .Length(5)
                .Nullable();
            Map(x => x.FlandersOudBruin)
                .Length(5)
                .Nullable();
            Map(x => x.FlandersRedAle)
                .Length(5)
                .Nullable();
            Map(x => x.Gueuze)
                .Length(5)
                .Nullable();
            Map(x => x.LambicFruit)
                .Length(5)
                .Nullable();
            Map(x => x.LambicUnblended)
                .Length(5)
                .Nullable();
            Map(x => x.Quadrupel)
                .Length(5) 
                .Nullable();
            Map(x => x.Saison)
                .Length(5)
                .Nullable();
            Map(x => x.FarmhouseAle)
                .Length(5)
                .Nullable();
            Map(x => x.Tripel)
                .Length(5)
                .Nullable();
            Map(x => x.Witbier)
                .Length(5)
                .Nullable();
            Map(x => x.BalticPorter)
                .Length(5) 
                .Nullable();
            Map(x => x.Braggot)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishBarleywine)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishBitter)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishBrownAle)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishDarkMildAle)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishIndiaPaleAle)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishPaleAle)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishPaleMildAle)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishPorter)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishStout)
                .Length(5)
                .Nullable();
            Map(x => x.EnglishStrongAle)
                .Length(5)
                .Nullable();
            Map(x => x.ExtraSpecialBitter)
                .Length(5)
                .Nullable();
            Map(x => x.ExportStout)
                .Length(5)
                .Nullable();
            Map(x => x.MilkStout)
                .Length(5)
                .Nullable();
            Map(x => x.OatmealStout)
                .Length(5)
                .Nullable();
            Map(x => x.OldAle)
                .Length(5)
                .Nullable();
            Map(x => x.RussianImperialStout)
                .Length(5)
                .Nullable();
            Map(x => x.WinterWarmer)
                .Length(5)
                .Nullable();
            Map(x => x.Sahti)
                .Length(5)
                .Nullable();
            Map(x => x.Altbier)
                .Length(5)
                .Nullable();
            Map(x => x.BerlinerWeissbier)
                .Length(5) 
                .Nullable();
            Map(x => x.Dunkelweizen)
                .Length(5)
                .Nullable();
            Map(x => x.Gose)
                .Length(5)
                .Nullable();
            Map(x => x.Hefeweizen)
                .Length(5)
                .Nullable();
            Map(x => x.Kölsch)
                .Length(5)
                .Nullable();
            Map(x => x.Kristalweizen)
                .Length(5)
                .Nullable();
            Map(x => x.Roggenbier)
                .Length(5)
                .Nullable();
            Map(x => x.Weizenbock)
                .Length(5)
                .Nullable();
            Map(x => x.IrishDryStout)
                .Length(5)
                .Nullable();
            Map(x => x.IrishRed)
                .Length(5)
                .Nullable();
            Map(x => x.Kvass)
                .Length(5)
                .Nullable();
            Map(x => x.ScotchAle)
                .Length(5)
                .Nullable();
            Map(x => x.WeeHeavy)
                .Length(5)
                .Nullable();
            Map(x => x.ScottishAle)
                .Length(5)
                .Nullable();
            Map(x => x.Gruit)
                .Length(5)
                .Nullable();
            Map(x => x.AncientHerbedAle)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanAdjunctLager)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanAmberLager)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanRedLager)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanImperialPilsner)
                .Length(5)
                .Nullable();
            Map(x => x.AmericanMaltLiquor)
                .Length(5) 
                .Nullable();
            Map(x => x.AmericanPaleLager)
                .Length(5)
                .Nullable();
            Map(x => x.CaliforniaCommonSteamBeer)
                .Length(5)
                .Nullable();
            Map(x => x.LightLager)
                .Length(5)
                .Nullable();
            Map(x => x.CzechPilsener)
                .Length(5)
                .Nullable();
            Map(x => x.EuroDarkLager)
                .Length(5)
                .Nullable();
            Map(x => x.EuroPaleLager)
                .Length(5)
                .Nullable();
            Map(x => x.EuroStrongLager)
                .Length(5)
                .Nullable();
            Map(x => x.Bock)
                .Length(5)
                .Nullable();
            Map(x => x.Doppelbock)
                .Length(5)
                .Nullable();
            Map(x => x.Dortmunder)
                .Length(5)
                .Nullable();
            Map(x => x.Eisbock)
                .Length(5)
                .Nullable();
            Map(x => x.GermanPilsener)
                .Length(5)
                .Nullable();
            Map(x => x.KellerbierZwickelbier)
                 .Length(5)
                 .Nullable();
            Map(x => x.MaibockHellesBock)
                .Length(5)
                .Nullable();
            Map(x => x.MärzenOktoberfest)
                .Length(5) 
                .Nullable();
            Map(x => x.MunichDunkelLager)
                .Length(5) 
                .Nullable();
            Map(x => x.MunichHellesLager)
                .Length(5) 
                .Nullable();
            Map(x => x.Rauchbier)
                .Length(5) 
                .Nullable();
            Map(x => x.Schwarzbier)
                .Length(5) 
                .Nullable();
                Map(x => x.ViennaLager)
                .Length(5) 
                .Nullable();
            Map(x => x.FruitBeer)
                .Length(5) .
                Nullable();
            Map(x => x.HerbedBeer)
                .Length(5) 
                .Nullable();
            Map(x => x.SmokedBeer)
                .Length(5) 
                .Nullable();
      
        }
    }
}