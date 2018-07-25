using System;
using SQLite;
namespace fastbill.Model
{
    [Table("restaurant")]
    public class RestaurantModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;  }
        public string NameRestaurant { get; set; }
        public string AddressRestaurant { get; set; }
        public string DescriptionRestaurant { get; set;  }
    }


}
