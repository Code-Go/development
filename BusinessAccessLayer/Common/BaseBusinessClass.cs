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
        public DataAccessLayer.Interface.ICountry _dataAccessCountry;
        public DataAccessLayer.Interface.IMasterState _dataAccessMasterState;
        public DataAccessLayer.Interface.IMasterCity _dataAccessMasterCity;
        public DataAccessLayer.Interface.IMasterCategory _dataAccessMasterCategory;
        public DataAccessLayer.Interface.IAttractions _dataAccessAttractions;


        public BaseBusinessClass()
        {
            _dataAccess = new DataAccessLayer.GetListValues();
            _dataAccessAdminUser = new DataAccessLayer.User();
            _dataAccessCountry = new DataAccessLayer.Admin.Country();
            _dataAccessMasterState = new DataAccessLayer.Admin.MasterState();
            _dataAccessMasterCity = new DataAccessLayer.Admin.MasterCity();
            _dataAccessMasterCategory = new DataAccessLayer.Admin.MasterCategory();
            _dataAccessAttractions = new DataAccessLayer.Common.Attractions();


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
