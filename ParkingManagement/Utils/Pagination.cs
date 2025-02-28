using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Utils
{
    public static class Pagination
    {
        public static int CalculateOffset(int page, int pageSize)
        {
            return (page - 1) * pageSize;
        }
    }
}
