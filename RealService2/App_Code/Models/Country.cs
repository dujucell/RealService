using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Country
    {
        public Country()
        {
            this.Country_ID = "";
            this.Country_Name = "";
            this.Locations = new List<Location>();
        }

        public Country(String Country_ID, String Country_Name)
        {
            this.Country_ID = Country_ID;
            this.Country_Name = Country_Name;
            this.Locations = new List<Location>();
        }

        public string Country_ID { get; set; }
        public string Country_Name { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Country_ID.Equals(""))
            {
                return false;
            }
            if (this.Country_Name.Equals(""))
            {
                return false;
            }

            return true;
        }

        public Boolean objectDataEquals(Country obj)
        {
            if (!(this.Country_ID.Equals(obj.Country_ID)))
            {
                return false;
            }
            if (!(this.Country_Name.Equals(obj.Country_Name)))
            {
                return false;
            }

            return true;
        }
    }
}
