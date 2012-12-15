using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class WishSvcEFImpl : IWishSvc
    {
        public bool insertWish(Wish obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Wishes.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteWish(Wish obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Wish> WishList = from Wish in db.Wishes
                                                where Wish.Wish_ID == obj.Wish_ID
                                                select Wish;

                    if ((WishList.ToArray().Length > 0))
                    {
                        db.Wishes.Remove((WishList.ToArray())[0]);

                        #region Database Submission

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool updateWish(Wish obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Wish> WishList = from Wish in db.Wishes
                                                where Wish.Wish_ID == obj.Wish_ID
                                                select Wish;

                    if ((WishList.ToArray()).Length > 0)
                    {
                        foreach (Wish Wish in WishList)
                        {
                            //Modify Attributes
                        }

                        #region Database Submission with Rollback

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public List<Wish> selectAllWishes()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Wish> WishList = from Wish in db.Wishes
                                            select Wish;

                return WishList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Wish selectWish(Wish obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Wish> WishList = from Wish in db.Wishes
                                            where Wish.Wish_ID == obj.Wish_ID
                                            select Wish;

                return (WishList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}