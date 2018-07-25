using System;
using System.Collections.Generic;
using fastbill.ViewModel;
using Xamarin.Forms;

namespace fastbill.View
{
    public partial class EditRestaurantView : ContentPage
    {
        private RestaurantViewModel restaurant { get; set; }
        public EditRestaurantView(RestaurantViewModel restaurant)
        {
            InitializeComponent();
            this.restaurant = restaurant;
            name.Text = restaurant.NameRestaurant;
            address.Text = restaurant.AddressRestaurant;
            description.Text = restaurant.DescriptionRestaurant;

        }

        public void update(object sender, EventArgs args) {
            restaurant.NameRestaurant = name.Text;
            restaurant.AddressRestaurant = address.Text;
            restaurant.DescriptionRestaurant = description.Text;
            restaurant.update();

            App.Current.MainPage = new NavigationPage(new ListRestaurantView());
        }

        public void delete(object sender, EventArgs args)
        {
            restaurant.delete();
            App.Current.MainPage = new NavigationPage(new ListRestaurantView());
        }
            
    }
}
