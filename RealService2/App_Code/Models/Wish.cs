using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Wish
    {
        public int Wish_ID { get; set; }
        public string Location_ID { get; set; }
        public Nullable<int> No_Bedrooms { get; set; }
        public Nullable<int> No_Bathrooms { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Type { get; set; }
        public string Agreement_Type { get; set; }
        public string Agent_ID { get; set; }
        public Nullable<int> Client_ID { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Client Client { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Wish_ID.Equals(""))
            {
                return false;
            }
            if (this.Agent_ID.Equals(""))
            {
                return false;
            }

            return true;
        }

        public Boolean objectDataEquals(Wish obj)
        {
            if (!(this.Wish_ID.Equals(obj.Wish_ID)))
            {
                return false;
            }
            if (!(this.Agent_ID.Equals(obj.Agent_ID)))
            {
                return false;
            }

            return true;
        }
    }
}
