using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IAgencySvc : IService
    {
        bool insertAgency(Agency obj);
        bool deleteAgency(Agency obj);
        bool updateAgency(Agency obj);
        List<Agency> selectAllAgencies();
        Agency selectAgency(Agency obj);
    }
}