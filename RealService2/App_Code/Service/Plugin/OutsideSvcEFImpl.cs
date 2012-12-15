using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class OutsideSvcEFImpl : IOutsideSvc
    {
        public bool insertOutsideInterest(OutsideInterest obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.OutsideInterests.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteOutsideInterest(OutsideInterest obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<OutsideInterest> OutsideInterestList = from outsideInterest in db.OutsideInterests
                                                                      where outsideInterest.ID == obj.ID
                                                                      select outsideInterest;

                    if ((OutsideInterestList.ToArray().Length > 0))
                    {

                        db.OutsideInterests.Remove((OutsideInterestList.ToArray()[0]));

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

        public bool updateOutsideInterest(OutsideInterest obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<OutsideInterest> OutsideInterestList = from outsideInterest in db.OutsideInterests
                                                                      where outsideInterest.ID == obj.ID
                                                                      select outsideInterest;

                    if ((OutsideInterestList.ToArray()).Length > 0)
                    {
                        foreach (OutsideInterest OutsideInterest in OutsideInterestList)
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

        public List<OutsideInterest> selectAllOutsideInterests()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<OutsideInterest> OutsideInterestList = from outsideInterest in db.OutsideInterests
                                                                  select outsideInterest;

                return OutsideInterestList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public OutsideInterest selectOutsideInterest(OutsideInterest obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<OutsideInterest> OutsideInterestList = from outsideInterest in db.OutsideInterests
                                                                  where outsideInterest.ID == obj.ID
                                                                  select outsideInterest;

                return (OutsideInterestList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}