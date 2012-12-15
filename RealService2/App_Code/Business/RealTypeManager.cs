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
    public class RealTypeManager : BusinessManager
    {
        public List<RealType> selectAllRealTypes()
        {
            try
            {
                IRealTypeSvc svc = (IRealTypeSvc)this.getService(typeof(IRealTypeSvc).Name);
                return svc.selectAllRealTypes();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public RealType selectRealType(RealType obj)
        {
            try
            {
                IRealTypeSvc svc = (IRealTypeSvc)this.getService(typeof(IRealTypeSvc).Name);
                return svc.selectRealType(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertRealType(RealType obj)
        {
            try
            {
                IRealTypeSvc svc = (IRealTypeSvc)this.getService(typeof(IRealTypeSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertRealType(obj);
                }
                else
                {
                    throw new BusinessValidationException(CustomErrors.REQUIRED_FIELD);
                }
            }
            catch (ServiceLoadException ex)
            {
                return false;
            }
        }

        public Boolean updateRealType(RealType obj)
        {
            try
            {
                IRealTypeSvc svc = (IRealTypeSvc)this.getService(typeof(IRealTypeSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateRealType(obj);
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

        public Boolean deleteRealType(RealType obj)
        {
            try
            {
                IRealTypeSvc svc = (IRealTypeSvc)this.getService(typeof(IRealTypeSvc).Name);
                return svc.deleteRealType(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}