using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using fastbill.ViewModel;
using fastbill.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace fastbill.Service
{
    public static class MapService
    {
        private const string uri = "http://maps.googleapis.com/maps/api/geocode/json?address=";
        public static MapViewModel getMapRestaurant(RestaurantModel restaurant) {

            HttpClient request = new HttpClient();
            HttpResponseMessage response = request.GetAsync(uri + restaurant.AddressRestaurant).GetAwaiter().GetResult();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                if (content.Length > 2)
                {
                    JObject json = JsonConvert.DeserializeObject<JObject>(content);
                    double lat = (double)json["results"][0]["geometry"]["location"]["lat"];
                    double lng = (double)json["results"][0]["geometry"]["location"]["lng"];
                    MapViewModel map = new MapViewModel(lat, lng);
                    return map;
                }
                else
                {
                    return null;
                }
            }
            return null;
        } 
    }
}
