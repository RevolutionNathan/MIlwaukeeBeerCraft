using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MilwaukeeBeerCraft.Models;

namespace MilwaukeeBeerCraft.Mapping
{
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id);

            Map(x => x.Title)
                .Length(500)
                .Not.Nullable();

            Map(x => x.Description)
                .Length(5000)
                .Not.Nullable();

            Map(x => x.Published)
                .Not.Nullable();

            Map(x => x.PostedOn)
                .Not.Nullable();

            Map(X => X.Modified);

            References(x => x.Category)
                .Column("Category")
                .Not.Nullable();

            HasManyToMany(x => x.Beers)
                .Table("Title");

            HasManyToMany(x => x.Brewery)
                .Table("Title");

        }
    }
}