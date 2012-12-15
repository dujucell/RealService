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
    public class AgencyManager : BusinessManager
    {
        public List<Agency> selectAllAgencies()
        {
            try
            {
                IAgencySvc svc = (IAgencySvc)this.getService(typeof(IAgencySvc).Name);
                return svc.selectAllAgencies();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Agency selectAgency(Agency obj)
        {
            try
            {
                IAgencySvc svc = (IAgencySvc)this.getService(typeof(IAgencySvc).Name);
                return svc.selectAgency(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertAgency(Agency obj)
        {
            try
            {
                IAgencySvc svc = (IAgencySvc)this.getService(typeof(IAgencySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertAgency(obj);
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

        public Boolean updateAgency(Agency obj)
        {
            try
            {
                IAgencySvc svc = (IAgencySvc)this.getService(typeof(IAgencySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateAgency(obj);
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

        public Boolean deleteAgency(Agency obj)
        {
            try
            {
                IAgencySvc svc = (IAgencySvc)this.getService(typeof(IAgencySvc).Name);
                return svc.deleteAgency(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new BusinessValidationException(CustomErrors.ROW_DELETED_ERROR);
            }
        }
    }
}