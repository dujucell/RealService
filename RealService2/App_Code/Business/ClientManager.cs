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
    public class ClientManager : BusinessManager
    {
        public List<Client> selectAllClients()
        {
            try
            {
                IClientSvc svc = (IClientSvc)this.getService(typeof(IClientSvc).Name);
                return svc.selectAllClients();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Client selectClient(Client obj)
        {
            try
            {
                IClientSvc svc = (IClientSvc)this.getService(typeof(IClientSvc).Name);
                return svc.selectClient(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertClient(Client obj)
        {
            try
            {
                IClientSvc svc = (IClientSvc)this.getService(typeof(IClientSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertClient(obj);
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

        public Boolean updateClient(Client obj)
        {
            try
            {
                IClientSvc svc = (IClientSvc)this.getService(typeof(IClientSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateClient(obj);
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

        public Boolean deleteClient(Client obj)
        {
            try
            {
                IClientSvc svc = (IClientSvc)this.getService(typeof(IClientSvc).Name);
                return svc.deleteClient(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}