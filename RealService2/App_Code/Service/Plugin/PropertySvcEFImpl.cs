using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class PropertySvcEFImpl : IPropertySvc
    {
        public bool insertProperty(Property obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Properties.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteProperty(Property obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Property> PropertyList = from property in db.Properties
                                                        where property.MLS_Prop_ID == obj.MLS_Prop_ID
                                                        select property;

                    if ((PropertyList.ToArray().Length > 0))
                    {
                        foreach(Property proper in PropertyList.ToList())
                        {
                            for (int n = 0; n < (proper.Interests.ToList()).Count; n++)
                            {
                                db.Interests.Remove((proper.Interests.ToList()[0]));
                            }
                        }
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

        public bool updateProperty(Property obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Property> PropertyList = from property in db.Properties
                                                        where property.MLS_Prop_ID == obj.MLS_Prop_ID
                                                        select property;

                    if ((PropertyList.ToArray()).Length > 0)
                    {
                        foreach (Property property in PropertyList)
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

        public List<Property> selectAllProperties()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Property> PropertyList = from property in db.Properties
                                                    select property;

                return PropertyList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Property selectProperty(Property obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Property> PropertyList = from property in db.Properties
                                                    where property.MLS_Prop_ID == obj.MLS_Prop_ID
                                                    select property;

                return (PropertyList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}