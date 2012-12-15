using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Service;

namespace RealService2.Business
{
    public abstract class BusinessManager
    {
        protected IService getService(String name)
        {
            return (Factory.getInstance()).getService(name);
        }
    }
}