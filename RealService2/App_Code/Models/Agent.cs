using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Agent
    {
        public Agent()
        {
            this.Clients = new List<Client>();
            this.Interests = new List<Interest>();
            this.Interests1 = new List<Interest>();
            this.OutsideInterests = new List<OutsideInterest>();
            this.Properties = new List<Property>();
            this.Wishes = new List<Wish>();
        }

        public string Agent_ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Telephone { get; set; }
        public string Status { get; set; }
        public string Agency_ID { get; set; }
        public virtual Agency Agency { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Interest> Interests1 { get; set; }
        public virtual ICollection<OutsideInterest> OutsideInterests { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Agent_ID.Equals(""))
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
            if (this.Status.Equals(""))
            {
                return false;
            }
            if (this.Agency_ID.Equals(""))
            {
                return false;
            }

            return true;
        }

    }
}
