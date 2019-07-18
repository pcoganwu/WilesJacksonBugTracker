using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WilesJacksonBugTracker.Client_APP.Helper
{
    public class BugApi
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://localhost:5001/api/bugs");
            return Client;
        }
    }
}
