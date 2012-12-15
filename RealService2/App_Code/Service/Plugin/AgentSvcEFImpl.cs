using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Service.Interface;
using RealService2.Models;

namespace RealService2.Service.Plugin
{
    public class AgentSvcEFImpl : IAgentSvc
    {
        public bool insertAgent(Agent obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    db.Agents.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deleteAgent(Agent obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {
                    IQueryable<Agent> AgentList = from agent in db.Agents
                                                    where agent.Agent_ID == obj.Agent_ID
                                                    select agent;

                    if ((AgentList.ToArray().Length > 0))
                    {

                        //Remove Dependencies
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

        public bool updateAgent(Agent obj)
        {
            using (RealReportContext db = new RealReportContext())
            {
                try
                {

                    IQueryable<Agent> AgentList = from agent in db.Agents
                                                    where agent.Agent_ID == obj.Agent_ID
                                                    select agent;

                    if ((AgentList.ToArray()).Length > 0)
                    {
                        foreach (Agent Agent in AgentList)
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

        public List<Agent> selectAllAgents()
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agent> AgentList = from agent in db.Agents
                                                select agent;

                return AgentList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Agent selectAgent(Agent obj)
        {
            RealReportContext db = new RealReportContext();

            try
            {
                IQueryable<Agent> AgentList = from agent in db.Agents
                                                where agent.Agent_ID == obj.Agency_ID
                                                select agent;

                return (AgentList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}