using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;
using RealService2.Service.Interface;
using BobsEnterpriseSystem.Exceptions.Service;
using BobsEnterpriseSystem.Exceptions.Business;

namespace RealService2.Business
{
    public class PropertyManager : BusinessManager
    {
        public List<Property> selectAllProperties()
        {
            try
            {
                IPropertySvc svc = (IPropertySvc)this.getService(typeof(IPropertySvc).Name);
                return svc.selectAllProperties();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Property selectProperty(Property obj)
        {
            try
            {
                IPropertySvc svc = (IPropertySvc)this.getService(typeof(IPropertySvc).Name);
                return svc.selectProperty(obj);
            }
            catch (ServiceLoadException ex)
            {
                return null;
            }
        }

        public Boolean insertProperty(Property obj)
        {
            try
            {
                IPropertySvc svc = (IPropertySvc)this.getService(typeof(IPropertySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertProperty(obj);
                }
                else
                {
                    throw new BusinessValidationException(CustomErrors.REQUIRED_FIELD);
                }
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean updateProperty(Property obj)
        {
            try
            {
                IPropertySvc svc = (IPropertySvc)this.getService(typeof(IPropertySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateProperty(obj);
                }
                else
                {
                    throw new BusinessValidationException(CustomErrors.REQUIRED_FIELD);
                }
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean deleteProperty(Property obj)
        {
            try
            {
                IPropertySvc svc = (IPropertySvc)this.getService(typeof(IPropertySvc).Name);
                return svc.deleteProperty(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}