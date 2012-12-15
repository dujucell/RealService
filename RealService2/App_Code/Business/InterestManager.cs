using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BobsEnterpriseSystem.Exceptions.Service;
using RealService2.Models;
using RealService2.Service.Interface;
using BobsEnterpriseSystem.Exceptions.Business;

namespace RealService2.Business
{
    public class InterestManager : BusinessManager
    {
        public List<Interest> selectAllInterests()
        {
            try
            {
                IInterestSvc svc = (IInterestSvc)this.getService(typeof(IInterestSvc).Name);
                return svc.selectAllInterests();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Interest selectInterest(Interest obj)
        {
            try
            {
                IInterestSvc svc = (IInterestSvc)this.getService(typeof(IInterestSvc).Name);
                return svc.selectInterest(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertInterest(Interest obj)
        {
            try
            {
                IInterestSvc svc = (IInterestSvc)this.getService(typeof(IInterestSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertInterest(obj);
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

        public Boolean deleteInterest(Interest obj)
        {
            try
            {
                IInterestSvc svc = (IInterestSvc)this.getService(typeof(IInterestSvc).Name);
                return svc.deleteInterest(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}