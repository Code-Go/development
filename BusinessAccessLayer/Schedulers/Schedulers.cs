using BusinessAccessLayer.Common;
using BusinessAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites.Common;

namespace BusinessAccessLayer.Schedulers
{
    public class Schedulers : BaseBusinessClass, ISchedulers, IDisposable
    {
        public List<AttractionsDTO> Admin_GetNearestLocations()
        {
            try
            {
                return _dataAccessSchedulers.Admin_GetNearestLocations();
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
