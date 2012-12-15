using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class AgencySvcEFImpl : IAgencySvc
    {
        public bool insertAgency(Agency obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Agencies.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }   
        }

        public bool deleteAgency(Agency obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Agency> AgencyList = from agency in db.Agencies
                                                        where agency.Agency_ID == obj.Agency_ID
                                                        select agency;

                    if ((AgencyList.ToArray().Length > 0))
                    {
                        foreach (Agency agency in AgencyList.ToList())
                        {
                            for (int n = 0; n < agency.Agents.Count; n++)
                            {
                                db.Agents.Remove((agency.Agents.ToArray())[0]);
                            }
                        }

                        db.Agencies.Remove((AgencyList.ToArray())[0]);

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

        public bool updateAgency(Agency obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Agency> AgencyList = from agency in db.Agencies
                                                        where agency.Agency_ID == obj.Agency_ID
                                                        select agency;

                    if ((AgencyList.ToArray()).Length > 0)
                    {
                        foreach (Agency agency in AgencyList)
                        {
                            agency.Agency_Name = obj.Agency_Name;

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

        public List<Agency> selectAllAgencies()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agency> AgencyList = from agency in db.Agencies
                                                    select agency;

                return AgencyList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Agency selectAgency(Agency obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agency> AgencyList = from agency in db.Agencies
                                                    where agency.Agency_ID == obj.Agency_ID
                                                    select agency;

                return (AgencyList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}