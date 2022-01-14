using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoAssitant.Interfaces
{
    public interface IGeoHelper
    {
        Task<string> GetIPAddress();
        Task<string> GetGeoInfo();
        Task<string> GetGeoInfo(string ipAddress);
    }
}
