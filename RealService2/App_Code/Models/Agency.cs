using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Agency
    {
        public Agency()
        {
            Agency_ID = "";
            Agency_Name = "";
            this.Agents = new List<Agent>();
        }

        public Agency(String Agency_ID, String Agency_Name)
        {
            this.Agency_ID = Agency_ID;
            this.Agency_Name = Agency_Name;
            this.Agents = new List<Agent>();
        }
        

        public string Agency_ID { get; set; }
        public string Agency_Name { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Agency_ID.Equals(""))
            {
                return false;
            }
            if (this.Agency_Name.Equals(""))
            {
                return false;
            }
         
            return true;
        }

        public Boolean objectDataEquals(Agency obj)
        {
            if (!(this.Agency_ID.Equals(obj.Agency_ID)))
            {
                return false;
            }
            if (!(this.Agency_Name.Equals(obj.Agency_Name)))
            {
                return false;
            }

            return true;
        }
    }
}
