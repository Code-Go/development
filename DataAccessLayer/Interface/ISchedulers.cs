using BusinessEntites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ISchedulers
    {
        List<AttractionsDTO> Admin_GetNearestLocations();
    }
}
