using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilwaukeeBeerCraft.Models;
using FluentNHibernate.Mapping;

namespace MilwaukeeBeerCraft.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);

            Map(x => x.Beer)
                .Length(10)
                .Nullable();

            Map(x => x.Brewery)
                .Length(10)
                .Nullable();

            Map(x => x.Event)
                .Length(10)
                .Nullable();

            Map(x => x.People)
                .Length(10)
                .Nullable();

            HasMany(x => x.Posts)
                .Inverse()
                .Cascade.All()
                .KeyColumn("Category");
            Map(x => x.UrlSlug)
                .Length(200)
                .Not.Nullable();

        }
    }
}