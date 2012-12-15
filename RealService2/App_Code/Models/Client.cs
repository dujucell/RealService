using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Client
    {
        public Client()
        {
            this.OutsideInterests = new List<OutsideInterest>();
            this.Properties = new List<Property>();
            this.Wishes = new List<Wish>();
        }

        public int ClientID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Agent_ID { get; set; }
        public string Type { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual ICollection<OutsideInterest> OutsideInterests { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }

        public Boolean isDataEntered()
        {
            if (this.ClientID == 0)
            {
                return false;
            }
            if (this.F_Name.Equals(""))
            {
                return false;
            }
            if (this.L_Name.Equals(""))
            {
                return false;
            }
            if (this.Type.Equals(""))
            {
                return false;
            }
            if (this.Agent_ID.Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}
