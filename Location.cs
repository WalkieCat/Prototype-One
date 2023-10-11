using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _gameDev1
{
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(string locationName, string description)
        {
            Name = locationName;
            Description = description;
        }
    }

    public class LocationManager
    {
        public List<Location> Locations { get; }

        public LocationManager()
        {
            Locations = new List<Location>
            {
                new Location("Office", "Your detective office."),
                new Location("Crime Scene", "The place where the crime occurred.")
                // Add more locations as needed
            };
        }

        public List<Location> GetLocations()
        {
            return Locations;
        }

        public void DisplayLocations()
        {
            Console.WriteLine("Available locations:");
            foreach (var location in Locations)
            {
                Console.WriteLine($"{location.Name}: {location.Description}");
            }
        }
    }
}
