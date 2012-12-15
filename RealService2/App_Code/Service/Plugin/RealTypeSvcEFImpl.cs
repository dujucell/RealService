using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class RealTypeSvcEFImpl : IRealTypeSvc
    {
        public bool insertRealType(RealType obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.RealTypes.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteRealType(RealType obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<RealType> RealTypeList = from realType in db.RealTypes
                                                        where realType.RealType_ID == obj.RealType_ID
                                                        select realType;

                    if ((RealTypeList.ToArray().Length > 0))
                    {
                        db.RealTypes.Remove(RealTypeList.ToArray()[0]);

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

        public bool updateRealType(RealType obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<RealType> RealTypeList = from RealType in db.RealTypes
                                                    where RealType.RealType_ID == obj.RealType_ID
                                                    select RealType;

                    if ((RealTypeList.ToArray()).Length > 0)
                    {
                        foreach (RealType RealType in RealTypeList)
                        {
                            RealType.RealType_Name = obj.RealType_Name;
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

        public List<RealType> selectAllRealTypes()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<RealType> RealTypeList = from RealType in db.RealTypes
                                                select RealType;

                return RealTypeList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public RealType selectRealType(RealType obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<RealType> RealTypeList = from RealType in db.RealTypes
                                                where RealType.RealType_ID == obj.RealType_ID
                                                select RealType;

                return (RealTypeList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}