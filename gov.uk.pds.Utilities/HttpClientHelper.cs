using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Utilities
{
    public static class HttpClientHelper
    {
        public static HttpClient GetClient()
        {
            var handler = new HttpClientHandler
            {
                Proxy = System.Net.WebRequest.DefaultWebProxy
            };
            handler.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            HttpClient client = new HttpClient(handler);
            return client;
        }
    }
}
