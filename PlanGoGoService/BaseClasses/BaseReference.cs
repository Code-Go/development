using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanGoGoService.BaseClasses
{
    public class BaseReference
    {
        public BusinessAccessLayer.IGetListValues _businessAccess;

        public BusinessAccessLayer.IUser _businessUser;

        public BusinessAccessLayer.Interfaces.ICountry _businessCountry;

        public BaseReference()
        {
            _businessAccess = new BusinessAccessLayer.GetListValues();
            _businessUser = new BusinessAccessLayer.User();
            _businessCountry = new BusinessAccessLayer.Admin.Country();
        }
    }
}