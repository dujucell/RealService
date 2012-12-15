using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IAgentSvc : IService
    {
        bool insertAgent(Agent obj);
        bool deleteAgent(Agent obj);
        bool updateAgent(Agent obj);
        List<Agent> selectAllAgents();
        Agent selectAgent(Agent obj);
    }
}