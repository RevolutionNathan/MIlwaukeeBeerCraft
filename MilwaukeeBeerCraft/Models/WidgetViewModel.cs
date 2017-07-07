using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilwaukeeBeerCraft;

namespace MilwaukeeBeerCraft.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(BlogRepository blogRepository)
        {
            Categories = blogRepository.Categories();
            Brewery = blogRepository.Breweries();
            Beers = blogRepository.Beers();

        }

        public IList<Category> Categories { get; private set; }
        public IList<BeerStyles> Beers { get; private set; }
        public IList<MilwaukeeBreweries> Brewery { get; private set; }


    }
}