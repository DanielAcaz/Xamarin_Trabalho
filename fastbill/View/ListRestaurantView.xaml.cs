using System;
using System.Collections.Generic;
using fastbill.ViewModel;
using Xamarin.Forms;

namespace fastbill.View
{
    public partial class ListRestaurantView : ContentPage
    {
        public ListRestaurantView()
        {
            InitializeComponent();
            RestaurantViewModel restaurants = new RestaurantViewModel();
            List.ItemsSource = restaurants.GetRestaurants();
        }

        public void AddRestaurant(object sender, EventArgs args) {
            Navigation.PushAsync(new AddRestaurantView());
        }

        public void EditAction(object sender, EventArgs args) {
            Label label = (Label)sender;
            RestaurantViewModel restaurant = ((TapGestureRecognizer)label.GestureRecognizers[0]).CommandParameter as RestaurantViewModel;
            Navigation.PushAsync(new EditRestaurantView(restaurant));
        }

        public void MapAction(object sender, EventArgs args){
            Label label = (Label)sender;
            RestaurantViewModel restaurant = ((TapGestureRecognizer)label.GestureRecognizers[0]).CommandParameter as RestaurantViewModel;
            Navigation.PushAsync(new MapView(restaurant));
        }
    }
}
