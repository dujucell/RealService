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
    public class LocationManager : BusinessManager
    {
        public List<Location> selectAllLocations()
        {
            try
            {
                ILocationSvc svc = (ILocationSvc)this.getService(typeof(ILocationSvc).Name);
                return svc.selectAllLocations();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Location selectLocation(Location obj)
        {
            try
            {
                ILocationSvc svc = (ILocationSvc)this.getService(typeof(ILocationSvc).Name);
                return svc.selectLocation(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean updateLocation(Location obj)
        {
            try
            {
                ILocationSvc svc = (ILocationSvc)this.getService(typeof(ILocationSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateLocation(obj);
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

        public Boolean insertLocation(Location obj)
        {
            try
            {
                ILocationSvc svc = (ILocationSvc)this.getService(typeof(ILocationSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertLocation(obj);
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

        public Boolean deleteLocation(Location obj)
        {
            try
            {
                ILocationSvc svc = (ILocationSvc)this.getService(typeof(ILocationSvc).Name);
                return svc.deleteLocation(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}