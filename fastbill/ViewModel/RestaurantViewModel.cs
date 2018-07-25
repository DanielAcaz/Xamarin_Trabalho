using System;
using fastbill.Model;
using fastbill.Repository;
using System.Collections.Generic;
namespace fastbill.ViewModel
{
    public class RestaurantViewModel
    {
        #region Properties
        public int Id { get; set; }
        public string NameRestaurant { get; set; }
        public string AddressRestaurant { get; set; }
        public string DescriptionRestaurant { get; set; }
        #endregion

        public RestaurantDAO dao;

        public RestaurantViewModel(){
            dao = new RestaurantDAO();
        }


        public static RestaurantModel GetRestaurant(RestaurantViewModel viewModel){
            var restaurant = new RestaurantModel();
            restaurant.Id = viewModel.Id;
            restaurant.NameRestaurant = viewModel.NameRestaurant;
            restaurant.AddressRestaurant = viewModel.AddressRestaurant;
            restaurant.DescriptionRestaurant = viewModel.DescriptionRestaurant;
            return restaurant;
        }

        public List<RestaurantViewModel> GetRestaurants(){
            var restaurants = dao.getAll();
            List<RestaurantViewModel> list = new List<RestaurantViewModel>();
            for (int i = 0; i < restaurants.Count; i++){
                RestaurantViewModel viewModel = new RestaurantViewModel();
                viewModel.AddressRestaurant = restaurants[i].AddressRestaurant;
                viewModel.NameRestaurant = restaurants[i].NameRestaurant;
                viewModel.DescriptionRestaurant = restaurants[i].DescriptionRestaurant;
                viewModel.Id = restaurants[i].Id;
                list.Add(viewModel);                   
            }
            return list;
        }

        public void save() {
            var restaurant = GetRestaurant(this);
            dao.save(restaurant);
        }

        public void update() {
            var restaurant = GetRestaurant(this);
            dao.update(restaurant);
        }

        public void delete() {
            var restaurant = GetRestaurant(this);
            dao.delete(restaurant);
        }
    }
}
