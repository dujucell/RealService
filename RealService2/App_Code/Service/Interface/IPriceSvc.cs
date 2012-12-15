using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IPriceSvc : IService
    {
        bool insertPrice(Price obj);
        bool deletePrice(Price obj);
        bool updatePrice(Price obj);
        List<Price> selectAllPrices();
        Price selectPrice(Price obj);
    }
}