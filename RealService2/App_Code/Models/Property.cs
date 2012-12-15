using System;
using System.Collections.Generic;

namespace RealService2.Models
{
    public class Property
    {
        public Property()
        {
            this.Interests = new List<Interest>();
        }

        public string MLS_Prop_ID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Location_ID { get; set; }
        public decimal Price { get; set; }
        public int No_Bedrooms { get; set; }
        public int No_Bathrooms { get; set; }
        public string Type { get; set; }
        public string Agreement_Type { get; set; }
        public System.DateTime Date_Posted { get; set; }
        public string Other { get; set; }
        public string URL { get; set; }
        public string VideoURL { get; set; }
        public string Agent_ID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<decimal> GmapsX { get; set; }
        public Nullable<decimal> GMapsY { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual Agreement Agreement { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual Location Location { get; set; }
        public virtual RealType Type1 { get; set; }

        public Boolean isDataEntered()
        {
            if (this.MLS_Prop_ID.Equals(""))
            {
                return false;
            }
            if (this.Location_ID.Equals(""))
            {
                return false;
            }
            if (this.Price.Equals(""))
            {
                return false;
            }
            if (this.No_Bathrooms == 0)
            {
                return false;
            }
            if (this.No_Bedrooms == 0)
            {
                return false;
            }
            if (this.Type.Equals(""))
            {
                return false;
            }
            if (this.Agreement_Type.Equals(""))
            {
                return false;
            }
            if (this.Date_Posted == null)
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
