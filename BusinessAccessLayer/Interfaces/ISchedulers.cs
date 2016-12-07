using BusinessEntites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Interfaces
{
    public interface ISchedulers
    {
        List<AttractionsDTO> Admin_GetNearestLocations();
    }
}
