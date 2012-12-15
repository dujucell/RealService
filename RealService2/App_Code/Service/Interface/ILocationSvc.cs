using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface ILocationSvc : IService
    {
        bool insertLocation(Location obj);
        bool deleteLocation(Location obj);
        bool updateLocation(Location obj);
        List<Location> selectAllLocations();
        Location selectLocation(Location obj);
    }
}