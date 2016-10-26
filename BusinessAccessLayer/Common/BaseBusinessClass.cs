using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DataAccessLayer;
using System.Web.Mvc;
using Unity.Mvc5;

namespace BusinessAccessLayer.Common
{
    public class BaseBusinessClass
    {
        public DataAccessLayer.IGetListValues _dataAccess;
        public DataAccessLayer.IUser _dataAccessAdminUser;

        public BaseBusinessClass()
        {
            _dataAccess = new DataAccessLayer.GetListValues();
            _dataAccessAdminUser = new DataAccessLayer.User();
            //IUnityContainer container = GetUnityContainer();
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        /// <summary>
        /// gets the unity container.
        /// </summary>
        /// <returns></returns>
        private IUnityContainer GetUnityContainer()
        {
            //create unitycontainer          
            IUnityContainer container = new UnityContainer()
                .RegisterType<DataAccessLayer.IGetListValues, DataAccessLayer.GetListValues>();
            return container;
        }
    }
}
