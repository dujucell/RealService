using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;


namespace RealService2.Service.Interface
{
    public interface IOutsideSvc : IService
    {
        bool insertOutsideInterest(OutsideInterest obj);
        bool deleteOutsideInterest(OutsideInterest obj);
        bool updateOutsideInterest(OutsideInterest obj);
        List<OutsideInterest> selectAllOutsideInterests();
        OutsideInterest selectOutsideInterest(OutsideInterest obj);
    }
}