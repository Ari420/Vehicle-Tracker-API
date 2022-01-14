using GeoAssitant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeoAssitant.Classes
{
    public class GeoHelper : IGeoHelper
    {
        private readonly HttpClient _httpClient;
        public GeoHelper(HttpHelper httpHelper)
        {
            _httpClient = httpHelper.GetClient();
        }
        public async Task<string> GetIPAddress()
        {
            var ipAddress = await _httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAddress.IsSuccessStatusCode)
            {
                var json = await ipAddress.Content.ReadAsStringAsync();
                return json.ToString();
            }
            return "";
        }
        public async Task<string> GetGeoInfo()
        {
            var ipAddress = await GetIPAddress();
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=24741cc9e998a352d8563444721f71a5");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
        public async Task<string> GetGeoInfo(string ipAddress)
        {
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=24741cc9e998a352d8563444721f71a5");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
    }
}
