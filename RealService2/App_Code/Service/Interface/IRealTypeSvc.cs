using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IRealTypeSvc : IService
    {
        bool insertRealType(RealType obj);
        bool deleteRealType(RealType obj);
        bool updateRealType(RealType obj);
        List<RealType> selectAllRealTypes();
        RealType selectRealType(RealType obj);
    }
}