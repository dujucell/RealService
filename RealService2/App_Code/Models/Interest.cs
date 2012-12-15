using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Interest
    {
        public string Buying_Agent { get; set; }
        public string Selling_Agent { get; set; }
        public string Property_ID { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Agent Agent1 { get; set; }
        public virtual Property Property { get; set; }

        public Boolean isDataEntered()
        {
            if (this.Buying_Agent.Equals(""))
            {
                return false;
            }
            if (this.Selling_Agent.Equals(""))
            {
                return false;
            }
            if (this.Property_ID.Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}
