using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class InterestSvcEFImpl : IInterestSvc
    {
        public bool insertInterest(Interest obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Interests.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteInterest(Interest obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Interest> InterestList = from interest in db.Interests
                                                        where interest.Buying_Agent == obj.Buying_Agent &&
                                                        interest.Selling_Agent == obj.Selling_Agent &&
                                                        interest.Property_ID == obj.Property_ID
                                                        select interest;

                    if ((InterestList.ToArray().Length > 0))
                    {

                        db.Interests.Remove((InterestList.ToArray())[0]);
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

        public List<Interest> selectAllInterests()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Interest> InterestList = from interest in db.Interests
                                                    select interest;

                return InterestList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Interest selectInterest(Interest obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Interest> InterestList = from interest in db.Interests
                                                    where interest.Buying_Agent == obj.Buying_Agent &&
                                                    interest.Selling_Agent == obj.Selling_Agent &&
                                                    interest.Property_ID == obj.Property_ID
                                                    select interest;

                return (InterestList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}