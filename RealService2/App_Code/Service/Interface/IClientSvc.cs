using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IClientSvc : IService
    {
        bool insertClient(Client obj);
        bool deleteClient(Client obj);
        bool updateClient(Client obj);
        List<Client> selectAllClients();
        Client selectClient(Client obj);
    }
}