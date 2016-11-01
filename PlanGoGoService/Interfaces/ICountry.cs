using BusinessEntites.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace PlanGoGoService.Interfaces
{
    [ServiceContract]
    public interface ICountry
    {
        [OperationContract]
        void Admin_UpdateCountry(int countryId, string countryName, string countryShortName, string createdBy);

        [OperationContract]
        List<MasterCountryDTO> Admin_GetCountry();


        [OperationContract]
        List<MasterCountryDTO> Admin_CheckCountryExist(string countryName, int countryId);
    }
}