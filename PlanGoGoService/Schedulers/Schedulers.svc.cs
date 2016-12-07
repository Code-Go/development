using PlanGoGoService.BaseClasses;
using PlanGoGoService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessEntites.Common;

namespace PlanGoGoService.Schedulers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Schedulers" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Schedulers.svc or Schedulers.svc.cs at the Solution Explorer and start debugging.
    public class Schedulers : BaseReference, ISchedulers
    {
        public List<AttractionsDTO> Admin_GetNearestLocations()
        {
            try
            {
                return _businessSchedulers.Admin_GetNearestLocations();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
