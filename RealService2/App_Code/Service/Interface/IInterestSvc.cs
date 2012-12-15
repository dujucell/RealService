using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IInterestSvc : IService
    {
        bool insertInterest(Interest obj);
        bool deleteInterest(Interest obj);
        List<Interest> selectAllInterests();
        Interest selectInterest(Interest obj);
    }
}