using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;
using BobsEnterpriseSystem.Exceptions.Service;
using RealService2.Service.Interface;
using BobsEnterpriseSystem.Exceptions.Business;

namespace RealService2.Business
{
    public class WishManager : BusinessManager
    {
        public List<Wish> selectAllWishes()
        {
            try
            {
                IWishSvc svc = (IWishSvc)this.getService(typeof(IWishSvc).Name);
                return svc.selectAllWishes();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Wish selectWish(Wish obj)
        {
            try
            {
                IWishSvc svc = (IWishSvc)this.getService(typeof(IWishSvc).Name);
                return svc.selectWish(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertWish(Wish obj)
        {
            try
            {
                IWishSvc svc = (IWishSvc)this.getService(typeof(IWishSvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertWish(obj);
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

        public Boolean deleteWish(Wish obj)
        {
            try
            {
                IWishSvc svc = (IWishSvc)this.getService(typeof(IWishSvc).Name);
                return svc.deleteWish(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}