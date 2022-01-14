using GeoAssitant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeoAssitant.Classes
{
    public class HttpHelper : IHttpHelper
    {
        private HttpClient _httpClient;
        public HttpHelper(HttpClient httpClient)
        {
            if (httpClient == null)
            {
                _httpClient = new HttpClient();
            }
            else
            {
                _httpClient = httpClient;
            }
        }
        public HttpClient GetClient()
        {
            return _httpClient;
        }
    }
}
