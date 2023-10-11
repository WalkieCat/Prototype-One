using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _gameDev1.Action;

namespace _gameDev1.Action
{
    class MapAction : IAction
    {
        private LocationManager locationManager;

        public MapAction(LocationManager manager)
        {
            locationManager = manager;
        }

        public void Execute()
        {
            var locations = locationManager.GetLocations();
            if (locationManager != null && locations.Any())
            {
                locationManager.DisplayLocations();
            }
            else
            {
                Console.WriteLine("LocationManager is null. Please initialize it.");
            }
        }
    }
}
