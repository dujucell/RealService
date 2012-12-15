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
    public class AgreementManager : BusinessManager
    {
        public List<Agreement> selectAllAgreements()
        {
            try
            {
                IAgreementSvc svc = (IAgreementSvc)this.getService(typeof(IAgreementSvc).Name);
                return svc.selectAllAgreements();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Agreement selectAgreement(Agreement obj)
        {
            try
            {
                IAgreementSvc svc = (IAgreementSvc)this.getService(typeof(IAgreementSvc).Name);
                return svc.selectAgreement(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertAgreement(Agreement obj)
        {
            try
            {
                IAgreementSvc svc = (IAgreementSvc)this.getService(typeof(IAgreementSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertAgreement(obj);
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

        public Boolean updateAgreement(Agreement obj)
        {
            try
            {
                IAgreementSvc svc = (IAgreementSvc)this.getService(typeof(IAgreementSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateAgreement(obj);
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

        public Boolean deleteAgreement(Agreement obj)
        {
            try
            {
                IAgreementSvc svc = (IAgreementSvc)this.getService(typeof(IAgreementSvc).Name);
                return svc.deleteAgreement(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}