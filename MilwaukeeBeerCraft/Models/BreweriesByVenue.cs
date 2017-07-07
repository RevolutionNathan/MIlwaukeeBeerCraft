
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class Item
{
    public string category_name { get; set; }
    public string category_id { get; set; }
    public bool is_primary { get; set; }
}
 
public class Categories
{
    public int count { get; set; }
    public List<Item> items { get; set; }
}

public class Stats
{
    public int total_count { get; set; }
    public int user_count { get; set; }
    public int total_user_count { get; set; }
    public int monthly_count { get; set; }
    public int weekly_count { get; set; }
}

public class VenueIcon
{
    public string sm { get; set; }
    public string md { get; set; }
    public string lg { get; set; }
}

public class Location
{
    public string venue_address { get; set; }
    public string venue_city { get; set; }
    public string venue_state { get; set; }
    public string venue_country { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
}

public class Contact
{
    public string twitter { get; set; }
    public string venue_url { get; set; }
}

public class Foursquare
{
    public string foursquare_id { get; set; }
    public string foursquare_url { get; set; }
}

public class Photo
{
    public string photo_img_sm { get; set; }
    public string photo_img_md { get; set; }
    public string photo_img_lg { get; set; }
    public string photo_img_og { get; set; }
}

public class Beer
{
    public int bid { get; set; }
    public string beer_name { get; set; }
    public string beer_label { get; set; }
    public int beer_abv { get; set; }
    public int beer_ibu { get; set; }
    public string beer_slug { get; set; }
    public string beer_description { get; set; }
    public int is_in_production { get; set; }
    public int beer_style_id { get; set; }
    public string beer_style { get; set; }
    public int auth_rating { get; set; }
    public bool wish_list { get; set; }
    public int beer_active { get; set; }
}

public class Contact2
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string url { get; set; }
}

public class Location2
{
    public string brewery_city { get; set; }
    public string brewery_state { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
}

public class Brewery
{
    public int brewery_id { get; set; }
    public string brewery_name { get; set; }
    public string brewery_slug { get; set; }
    public string brewery_label { get; set; }
    public string country_name { get; set; }
    public Contact2 contact { get; set; }
    public Location2 location { get; set; }
    public int brewery_active { get; set; }
}

public class User
{
    public int uid { get; set; }
    public string user_name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string user_avatar { get; set; }
    public string relationship { get; set; }
    public int is_private { get; set; }
}

public class Item2
{
    public string category_name { get; set; }
    public string category_id { get; set; }
    public bool is_primary { get; set; }
}

public class Categories2
{
    public int count { get; set; }
    public List<Item2> items { get; set; }
}

public class Location3
{
    public string venue_address { get; set; }
    public string venue_city { get; set; }
    public string venue_state { get; set; }
    public string venue_country { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
}

public class Contact3
{
    public string twitter { get; set; }
    public string venue_url { get; set; }
}

public class Foursquare2
{
    public string foursquare_id { get; set; }
    public string foursquare_url { get; set; }
}

public class VenueIcon2
{
    public string sm { get; set; }
    public string md { get; set; }
    public string lg { get; set; }
}

public class Venue2
{
    public int venue_id { get; set; }
    public string venue_name { get; set; }
    public string primary_category { get; set; }
    public string parent_category_id { get; set; }
    public Categories2 categories { get; set; }
    public Location3 location { get; set; }
    public Contact3 contact { get; set; }
    public bool public_venue { get; set; }
    public Foursquare2 foursquare { get; set; }
    public VenueIcon2 venue_icon { get; set; }
}

public class Items
{
    public int photo_id { get; set; }
    public Photo photo { get; set; }
    public string created_at { get; set; }
    public int checkin_id { get; set; }
    public Beer beer { get; set; }
    public Brewery brewery { get; set; }
    public User user { get; set; }
    public Venue2 venue { get; set; }
}

public class Media
{
    public int count { get; set; }
    public Items items { get; set; }
}

public class Beer2
{
    public int bid { get; set; }
    public string beer_name { get; set; }
    public string beer_label { get; set; }
    public int beer_abv { get; set; }
    public int beer_ibu { get; set; }
    public string beer_slug { get; set; }
    public string beer_description { get; set; }
    public int is_in_production { get; set; }
    public int beer_style_id { get; set; }
    public string beer_style { get; set; }
    public int auth_rating { get; set; }
    public bool wish_list { get; set; }
    public int beer_active { get; set; }
    public double rating_score { get; set; }
    public int rating_count { get; set; }
}

public class Contact4
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string url { get; set; }
}

public class Location4
{
    public string brewery_city { get; set; }
    public string brewery_state { get; set; }
    public double lat { get; set; }
    public double lng { get; set; }
}

public class Brewery2
{
    public int brewery_id { get; set; }
    public string brewery_name { get; set; }
    public string brewery_slug { get; set; }
    public string brewery_label { get; set; }
    public string country_name { get; set; }
    public Contact4 contact { get; set; }
    public Location4 location { get; set; }
    public int brewery_active { get; set; }
}

public class Friends
{
    public int count { get; set; }
    public List<object> items { get; set; }
}

public class Items2
{
    public string created_at { get; set; }
    public int total_count { get; set; }
    public int your_count { get; set; }
    public Beer2 beer { get; set; }
    public Brewery2 brewery { get; set; }
    public Friends friends { get; set; }
}

public class TopBeers
{
    public int offset { get; set; }
    public int limit { get; set; }
    public int count { get; set; }
    public Items2 items { get; set; }
}

public class Venue
{
    public int venue_id { get; set; }
    public string venue_name { get; set; }
    public string last_updated { get; set; }
    public string primary_category { get; set; }
    public Categories categories { get; set; }
    public Stats stats { get; set; }
    public VenueIcon venue_icon { get; set; }
    public bool public_venue { get; set; }
    public Location location { get; set; }
    public Contact contact { get; set; }
    public Foursquare foursquare { get; set; }
    public Media media { get; set; }
    public TopBeers top_beers { get; set; }
}

public class VenueRootObject
{
    public Venue venue { get; set; }
}