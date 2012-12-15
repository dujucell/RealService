using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class OutsideInterest
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string Agent_ID { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Client Client { get; set; }

        public Boolean isDataEntered()
        {
            if (this.ID.Equals(""))
            {
                return false;
            }
            if (this.URL.Equals(""))
            {
                return false;
            }

            return true;
        }

        
    }
}
