using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class ClientSvcEFImpl : IClientSvc
    {
        public bool insertClient(Client obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Clients.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteClient(Client obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Client> ClientList = from client in db.Clients
                                                    where client.ClientID == obj.ClientID
                                                    select client;

                    if ((ClientList.ToArray().Length > 0))
                    {
                        //
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

        public bool updateClient(Client obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Client> ClientList = from Client in db.Clients
                                                    where Client.ClientID == obj.ClientID
                                                    select Client;

                    if ((ClientList.ToArray()).Length > 0)
                    {
                        foreach (Client Client in ClientList)
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

        public List<Client> selectAllClients()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Client> ClientList = from Client in db.Clients
                                                select Client;

                return ClientList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Client selectClient(Client obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Client> ClientList = from Client in db.Clients
                                                where Client.ClientID == obj.ClientID
                                                select Client;

                return (ClientList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}