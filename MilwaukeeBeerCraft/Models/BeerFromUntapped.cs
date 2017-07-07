using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MilwaukeeBeerCraft.Models
{
    public class ResponseTime
    {
        [Key]
        public int id { get; set; }

        public double time { get; set; }
        public string measure { get; set; }
    }

    public class InitTime
    {
        [Key]
        public int id { get; set; }
        public double time { get; set; }
        public string measure { get; set; }
    }

    public class Meta
    {
        [Key]
        public int id
        { get; set; }
        public int code { get; set; }
        public ResponseTime response_time { get; set; }
        public InitTime init_time { get; set; }
    }

    public class Beer
    {
        [Key]
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public string beer_style { get; set; }
        public double beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_slug { get; set; }
        public string beer_description { get; set; }
        public int is_in_production { get; set; }
        public string created_at { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
        public double rating_score { get; set; }
        public int rating_count { get; set; }
    }

    public class Contact
    {
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string url { get; set; }
        [Key] public int id { get; set; }
    }

    public class Location
    {
        public string brewery_city { get; set; }
        public string brewery_state { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        [Key] public int id { get; set; }
    }

    public class Brewery
    {
        [Key]
        public int brewery_id { get; set; }
        public string brewery_name { get; set; }
        public string brewery_slug { get; set; }
        public string brewery_label { get; set; }
        public string country_name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public int brewery_active { get; set; }
    }

    public class Friends
    {
        public List<object> items { get; set; }
        public int count { get; set; }
        [Key] public int id { get; set; }
    }

    public class Item
    {
        public int total_user_count { get; set; }
        public object has_had { get; set; }
        public int total_count { get; set; }
        public Beer beer { get; set; }
        public Brewery brewery { get; set; }
        public Friends friends { get; set; }
        [Key]
        public int id { get; set; }
    }

    public class Beers
    {
        public int count { get; set; }
        public List<Item> items { get; set; }

        [Key] public int id { get; set; }
    }

    public class Collaborations
    {
        public int count { get; set; }
        public List<object> items { get; set; }
        [Key]
        public int id { get; set; }
    }

    public class Response
    {
        public string source { get; set; }
        public int total_count_filtered { get; set; }
        public int total_count { get; set; }
        public bool is_search { get; set; }
        public bool type_id { get; set; }
        public bool sort { get; set; }
        public Beers beers { get; set; }
        public Collaborations collaborations { get; set; }
        public string sort_name { get; set; }
        public string sort_key { get; set; }
        [Key]
        public int id { get; set; }
    }

    public class BeerListObject
    {
        public Meta meta { get; set; }
        public List<object> notifications { get; set; }
        public Response response { get; set; }
        [Key]
        public int id { get; set; }
            
    }
    
}

           