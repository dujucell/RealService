using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Agreement
    {
        public Agreement()
        {
            this.Agreement_ID = "";
            this.Agreement_Name = "";
            this.Properties = new List<Property>();
        }

        public Agreement(String Agreement_ID, String Agreement_Name)
        {
            this.Agreement_ID = Agreement_ID;
            this.Agreement_Name = Agreement_Name;
            this.Properties = new List<Property>();
        }

        public string Agreement_ID { get; set; }
        public string Agreement_Name { get; set; }
        public virtual ICollection<Property> Properties { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Agreement_ID.Equals(""))
            {
                return false;
            }
            if (this.Agreement_Name.Equals(""))
            {
                return false;
            }

            return true;
        }

        public Boolean objectDataEquals(Agreement obj)
        {
            if (!(this.Agreement_ID.Equals(obj.Agreement_ID)))
            {
                return false;
            }
            if (!(this.Agreement_Name.Equals(obj.Agreement_Name)))
            {
                return false;
            }

            return true;
        }
    }
}
