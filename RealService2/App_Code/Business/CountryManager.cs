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
    public class CountryManager : BusinessManager
    {
        public List<Country> selectAllCountries()
        {
            try
            {
                ICountrySvc svc = (ICountrySvc)this.getService(typeof(ICountrySvc).Name);
                return svc.selectAllCountries();
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Country selectCountry(Country obj)
        {
            try
            {
                ICountrySvc svc = (ICountrySvc)this.getService(typeof(ICountrySvc).Name);
                return svc.selectCountry(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }

        public Boolean insertCountry(Country obj)
        {
            try
            {
                ICountrySvc svc = (ICountrySvc)this.getService(typeof(ICountrySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.insertCountry(obj);
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

        public Boolean updateCountry(Country obj)
        {
            try
            {
                ICountrySvc svc = (ICountrySvc)this.getService(typeof(ICountrySvc).Name);
                if (obj.isDataEntered())
                {
                    return svc.updateCountry(obj);
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

        public Boolean deleteCountry(Country obj)
        {
            try
            {
                ICountrySvc svc = (ICountrySvc)this.getService(typeof(ICountrySvc).Name);
                return svc.deleteCountry(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}