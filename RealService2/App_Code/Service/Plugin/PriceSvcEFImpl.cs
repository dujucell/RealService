using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class PriceSvcEFImpl : IPriceSvc
    {
        public bool insertPrice(Price obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Prices.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deletePrice(Price obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Price> PriceList = from price in db.Prices
                                                    where price.Range == obj.Range
                                                    select price;

                    if ((PriceList.ToArray().Length > 0))
                    {

                        //Remove Dependencies
                        #region Database Submission

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool updatePrice(Price obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Price> PriceList = from price in db.Prices
                                                    where price.Range == obj.Range
                                                    select price;

                    if ((PriceList.ToArray()).Length > 0)
                    {
                        foreach (Price Price in PriceList)
                        {
                            //Modify Attributes
                        }

                        #region Database Submission with Rollback

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public List<Price> selectAllPrices()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Price> PriceList = from price in db.Prices
                                                select price;

                return PriceList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Price selectPrice(Price obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Price> PriceList = from Price in db.Prices
                                                where Price.Range == obj.Range
                                                select Price;

                return (PriceList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}