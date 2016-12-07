using BusinessEntites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PlanGoGoService.Interfaces
{
    [ServiceContract]
    public interface ISchedulers
    {
        [OperationContract]
        List<AttractionsDTO> Admin_GetNearestLocations();
    }
}