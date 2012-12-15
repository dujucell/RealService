using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IPropertySvc : IService
    {
        bool insertProperty(Property obj);
        bool deleteProperty(Property obj);
        bool updateProperty(Property obj);
        List<Property> selectAllProperties();
        Property selectProperty(Property obj);
    }
}