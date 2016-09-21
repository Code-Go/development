using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanGoGoService.BaseClasses
{
    public class BaseReference
    {
        public BusinessAccessLayer.IGetListValues _businessAccess;
        public BaseReference()
        {
            _businessAccess = new BusinessAccessLayer.GetListValues();
        }
    }
}