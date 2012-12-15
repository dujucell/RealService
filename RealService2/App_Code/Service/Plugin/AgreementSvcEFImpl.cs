using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class AgreementSvcEFImpl : IAgreementSvc
    {
        public bool insertAgreement(Agreement obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Agreements.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteAgreement(Agreement obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Agreement> AgreementList = from agreement in db.Agreements
                                                          where agreement.Agreement_ID == obj.Agreement_ID
                                                          select agreement;

                    if ((AgreementList.ToArray().Length > 0))
                    {

                        foreach (Agreement agreement in AgreementList.ToList())
                        {
                            for (int n = 0; n < (agreement.Properties.ToArray()).Length; n++ )
                            {
                                db.Properties.Remove((agreement.Properties.ToArray())[0]);
                            }
                        }

                        db.Agreements.Remove((AgreementList.ToArray())[0]);

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

        public bool updateAgreement(Agreement obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Agreement> AgreementList = from agreement in db.Agreements
                                                          where agreement.Agreement_ID == obj.Agreement_ID
                                                          select agreement;

                    if ((AgreementList.ToArray()).Length > 0)
                    {
                        foreach (Agreement agreement in AgreementList)
                        {
                            agreement.Agreement_Name = obj.Agreement_Name;
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

        public List<Agreement> selectAllAgreements()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agreement> AgreementList = from agreement in db.Agreements
                                                      select agreement;

                return AgreementList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Agreement selectAgreement(Agreement obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agreement> AgreementList = from agreement in db.Agreements
                                                      where agreement.Agreement_ID == obj.Agreement_ID
                                                      select agreement;

                return (AgreementList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}