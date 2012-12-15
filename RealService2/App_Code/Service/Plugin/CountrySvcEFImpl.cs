using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class CountrySvcEFImpl : ICountrySvc
    {
        public bool insertCountry(Country obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Countries.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteCountry(Country obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Country> CountryList = from country in db.Countries
                                                      where country.Country_ID == obj.Country_ID
                                                      select country;

                    if ((CountryList.ToArray().Length > 0))
                    {

                        foreach (Country country in CountryList)
                        {
                            for (int n = 0; n < country.Locations.Count; n++)
                            {
                                db.Locations.Remove((country.Locations.ToArray())[0]);
                            } 
                        }

                        db.Countries.Remove((CountryList.ToArray())[0]);
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

        public bool updateCountry(Country obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Country> CountryList = from country in db.Countries
                                                      where country.Country_ID == obj.Country_ID
                                                      select country;

                    if ((CountryList.ToArray()).Length > 0)
                    {
                        foreach (Country country in CountryList)
                        {
                            country.Country_Name = obj.Country_Name;
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

        public List<Country> selectAllCountries()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Country> CountryList = from country in db.Countries
                                                  select country;

                return CountryList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Country selectCountry(Country obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Country> CountryList = from country in db.Countries
                                                  where country.Country_ID == obj.Country_ID
                                                  select country;

                return (CountryList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}