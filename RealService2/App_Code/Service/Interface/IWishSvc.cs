using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IWishSvc : IService
    {
        bool insertWish(Wish obj);
        bool deleteWish(Wish obj);
        bool updateWish(Wish obj);
        List<Wish> selectAllWishes();
        Wish selectWish(Wish obj);
    }
}