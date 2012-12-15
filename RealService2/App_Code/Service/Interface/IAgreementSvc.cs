using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealService2.Models;

namespace RealService2.Service.Interface
{
    public interface IAgreementSvc : IService
    {
        bool insertAgreement(Agreement obj);
        bool deleteAgreement(Agreement obj);
        bool updateAgreement(Agreement obj);
        List<Agreement> selectAllAgreements();
        Agreement selectAgreement(Agreement obj);
    }
}