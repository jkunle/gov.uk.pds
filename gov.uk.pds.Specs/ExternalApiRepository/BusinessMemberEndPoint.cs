using gov.uk.pds.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Specs.ExternalApiRepository
{
    public class BusinessMemberEndPoint
    {
        public async Task<EndPointStatus> Status(string uri)
        {
            HttpClient client = HttpClientHelper.GetClient();
            Uri url = new Uri(uri);

            HttpResponseMessage response = await client.GetAsync(url);

            return new EndPointStatus { Reason = response.ReasonPhrase, Status = Convert.ToInt16(response.StatusCode) };
        
        }

    }
}
