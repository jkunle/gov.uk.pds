using gov.uk.pds.Domain;
using gov.uk.pds.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gov.uk.pds.ExternalApiRepository
{
    public class DataContext
    {

        public async Task<IEnumerable<BusinessItem>> GetBusinessItemsAsync()
        {
            var client = HttpClientHelper.GetClient();
            var response = await client.GetAsync(DataContextConstants.EventsAPI);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return ConvertToBusinessItems(content);
            }
            else
            {
                return Enumerable.Empty<BusinessItem>();
            }
        }

        public async Task<gov.uk.pds.Domain.Member> GetMemberAsync(int id)
        {

            var client = HttpClientHelper.GetClient();
            var response = await client.GetAsync(string.Format(DataContextConstants.MemberAPI, id));
            string content = await response.Content.ReadAsStringAsync();

            var buffer = Encoding.UTF8.GetBytes(content);
            using (var stream = new MemoryStream(buffer))
            {
                var serializer = new XmlSerializer(typeof(Members));
                return ConvertToMember(stream, serializer);
            }

        }

        private Domain.Member ConvertToMember(MemoryStream stream, XmlSerializer serializer)
        {
            var result = (Members)serializer.Deserialize(stream);
            return new Domain.Member
            {
                Id = result.Member.Id,
                FullTitle = result.Member.FullTitle,
                MemberFrom = result.Member.MemberFrom,
                Party = result.Member.Party.Value
            };
        }

        private IEnumerable<BusinessItem> ConvertToBusinessItems(string content)
        {
            var businessItems = new List<BusinessItem>();
            var results = JsonConvert.DeserializeObject<IEnumerable<Event>>(content);
            results.Select(x => new BusinessItem
            {
                Id = x.Id,
                Description = x.Description,
                Category = x.Category,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
            });

            foreach (var business in results)
            {

                var item = new BusinessItem
                {
                    Id = business.Id,
                    Description = business.Description,
                    Category = business.Category,
                    StartDate = business.StartDate,
                    EndDate = business.EndDate
                };
                if (business.Members.Count() > 0)
                {
                    var memberlist = new List<Domain.Member>();
                    foreach (var member in business.Members)
                    {
                        memberlist.Add(new gov.uk.pds.Domain.Member
                        {
                            Id = member.Id,
                            FullTitle = member.FullTitle,
                            MemberFrom = member.MemberFrom
                        });
                    }
                    item.Members = memberlist;
                }
                businessItems.Add(item);

            }
            return businessItems;
        }



    }
}
