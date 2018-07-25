using System;
namespace fastbill.ViewModel
{
    public class MapViewModel
    {
        public double lat { get; set; }
        public double lng { get; set; }

        public MapViewModel() {
            
        }

        public MapViewModel(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }
}
