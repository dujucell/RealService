using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface ICountrySvc : IService
    {
        bool insertCountry(Country obj);
        bool deleteCountry(Country obj);
        bool updateCountry(Country obj);
        List<Country> selectAllCountries();
        Country selectCountry(Country obj);
    }
}