using System;
using System.Collections.Generic;
using SQLite;
using fastbill.Model;
using Xamarin.Forms;
using System.Linq;
namespace fastbill.Repository
{
    public class RestaurantDAO
    {

        private SQLiteConnection _connection;

        public RestaurantDAO()
        {
            var dep = DependencyService.Get<ConnectionFactory>();
            string rule = dep.getRule("database.sqlite");
            _connection = new SQLiteConnection(rule);
            _connection.CreateTable<RestaurantModel>();

        }

        public List<RestaurantModel> getAll()
        {
            return _connection.Table<RestaurantModel>().ToList();
        }

        public RestaurantModel getById(int id)
        {
            return _connection.Table<RestaurantModel>().Where(a=>a.Id == id).FirstOrDefault();
        }

        public RestaurantModel getByName(string name){
            return _connection.Table<RestaurantModel>().Where(a => a.NameRestaurant == name).FirstOrDefault();
        }

        public void save(RestaurantModel restaurant){
            _connection.Insert(restaurant);
        }

        public void update(RestaurantModel restaurant){
            _connection.Update(restaurant);
        }

        public void delete(RestaurantModel restaurant){
            _connection.Delete(restaurant);
        }
    }
}
