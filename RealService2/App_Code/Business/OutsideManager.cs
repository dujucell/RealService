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
    public class OutsideManager : BusinessManager
    {
        public List<OutsideInterest> selectAllOutsideInterests()
        {
            try
            {
                IOutsideSvc svc = (IOutsideSvc)this.getService(typeof(IOutsideSvc).Name);
                return svc.selectAllOutsideInterests();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public OutsideInterest selectOutsideInterest(OutsideInterest obj)
        {
            try
            {
                IOutsideSvc svc = (IOutsideSvc)this.getService(typeof(IOutsideSvc).Name);
                return svc.selectOutsideInterest(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean updateOutside(OutsideInterest obj)
        {
            try
            {
                IOutsideSvc svc = (IOutsideSvc)this.getService(typeof(IOutsideSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateOutsideInterest(obj);
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

        public Boolean insertOutsideInterest(OutsideInterest obj)
        {
            try
            {
                IOutsideSvc svc = (IOutsideSvc)this.getService(typeof(IOutsideSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertOutsideInterest(obj);
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

        public Boolean deleteOutsideInterest(OutsideInterest obj)
        {
            try
            {
                IOutsideSvc svc = (IOutsideSvc)this.getService(typeof(IOutsideSvc).Name);
                return svc.deleteOutsideInterest(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}