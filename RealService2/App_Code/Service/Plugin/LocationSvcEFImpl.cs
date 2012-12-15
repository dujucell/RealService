using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class LocationSvcEFImpl : ILocationSvc
    {
        public bool insertLocation(Location obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Locations.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteLocation(Location obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Location> LocationList = from location in db.Locations
                                                        where location.Location_ID == obj.Location_ID
                                                        select location;

                    if ((LocationList.ToArray().Length > 0))
                    {

                        foreach (Location location in LocationList)
                        {
                            location.Properties.Clear();
                            location.Country = null;
                        }

                        db.Locations.Remove((LocationList.ToArray())[0]);

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

        public bool updateLocation(Location obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Location> LocationList = from location in db.Locations
                                                        where location.Location_ID == obj.Location_ID
                                                        select location;

                    if ((LocationList.ToArray()).Length > 0)
                    {
                        foreach (Location location in LocationList)
                        {
                            location.City = obj.City;
                            location.Country_ID = obj.Country_ID;
                            location.Country = null;
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

        public List<Location> selectAllLocations()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Location> LocationList = from location in db.Locations
                                                    select location;

                return LocationList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Location selectLocation(Location obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Location> LocationList = from location in db.Locations
                                                    where location.Location_ID == obj.Location_ID
                                                    select location;

                return (LocationList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}