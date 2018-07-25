using System;
using System.Collections.Generic;
using Xamarin.Forms;
using fastbill.ViewModel;


namespace fastbill.View
{
    public partial class AddRestaurantView : ContentPage
    {
        public AddRestaurantView()
        {
            InitializeComponent();
        }

        public void add(object sender, EventArgs args){
            RestaurantViewModel restaurant = new RestaurantViewModel();
            restaurant.NameRestaurant = name.Text;
            restaurant.AddressRestaurant = address.Text;
            restaurant.DescriptionRestaurant = description.Text;
            restaurant.save();

            App.Current.MainPage = new NavigationPage(new ListRestaurantView());
        }
    }
}
