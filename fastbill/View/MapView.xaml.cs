using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Linq;
using System.Text;
using fastbill.ViewModel;
using fastbill.Service;

namespace fastbill.View
{
    public partial class MapView : ContentPage
    {
        public MapView(RestaurantViewModel restaurant)
        {
            MapViewModel map = MapService.getMapRestaurant(RestaurantViewModel.GetRestaurant(restaurant));
            var requesMap = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(map.lat, map.lng), Distance.FromMiles(0.3)))
            {
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            requesMap.Pins.Add(new Pin
            {
                Type = PinType.Generic,
                Position = new Position(map.lat, map.lng),
                Label = restaurant.NameRestaurant,
                Address = restaurant.AddressRestaurant
            });
            stack.Children.Add(requesMap);
            Content = stack;
        }
    }
}
