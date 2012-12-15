using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class RealType
    {
        public RealType()
        {
            RealType_ID = "";
            RealType_Name = "";
            this.Properties = new List<Property>();
        }

        public RealType(String RealType_ID, String RealType_Name)
        {
            this.RealType_ID = RealType_ID;
            this.RealType_Name = RealType_Name;
            this.Properties = new List<Property>();
        }

        public string RealType_ID { get; set; }
        public string RealType_Name { get; set; }
        public virtual ICollection<Property> Properties { get; set; }

        public Boolean isDataEntered()
        {
            if (this.RealType_ID.Equals(""))
            {
                return false;
            }
            if (this.RealType_Name.Equals(""))
            {
                return false;
            }

            return true;
        }

        public Boolean objectDataEquals(RealType obj)
        {
            if (!(this.RealType_ID.Equals(obj.RealType_ID)))
            {
                return false;
            }
            if (!(this.RealType_Name.Equals(obj.RealType_Name)))
            {
                return false;
            }

            return true;
        }
    }
}
