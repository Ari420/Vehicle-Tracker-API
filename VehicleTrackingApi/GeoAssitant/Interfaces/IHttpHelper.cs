using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeoAssitant.Interfaces
{
    public interface IHttpHelper
    {
        HttpClient GetClient();
    }
}
