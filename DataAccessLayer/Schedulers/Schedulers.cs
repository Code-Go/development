using BusinessEntites.Common;
using Dapper;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Schedulers
{
    public class Schedulers: ISchedulers, IDisposable
    {
        public List<AttractionsDTO> Admin_GetNearestLocations()
        {
            try
            {
                List<AttractionsDTO> _returnResult = SqlHelper.QuerySP<AttractionsDTO>("Admin_GetNearestLocations").ToList();
                return _returnResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
