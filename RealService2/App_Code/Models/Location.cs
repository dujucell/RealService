using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Location
    {
        public Location()
        {
            this.Location_ID = "";
            this.City = "";
            this.Country_ID = "";
            this.Properties = new List<Property>();
        }

        public Location(String Location_ID, String City, String Country_ID)
        {
            this.Location_ID = Location_ID;
            this.City = City;
            this.Country_ID = Country_ID;
            this.Properties = new List<Property>();
        }

        public string Location_ID { get; set; }
        public string City { get; set; }
        public string Country_ID { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Property> Properties { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Location_ID.Equals(""))
            {
                return false;
            }
            if (this.City.Equals(""))
            {
                return false;
            }

            return true;
        }

        public Boolean objectDataEquals(Location obj)
        {
            if (!(this.Location_ID.Equals(obj.Location_ID)))
            {
                return false;
            }
            if (!(this.City.Equals(obj.City)))
            {
                return false;
            }

            return true;
        }
    }
}
