using gov.uk.pds.Domain;
using gov.uk.pds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.ExternalApiRepository
{
    public class BusinessItemRepository : IBusinessItemRepository
    {
        public BusinessItem Find(int id)
        {
            var context = new DataContext();
            return FindAll().Result.FirstOrDefault(b => b.Id == id);     
        }

        public async Task<IEnumerable<BusinessItem>> FindAll()
        {
            var context = new DataContext();
            return await context.GetBusinessItemsAsync();
        }
       
    }
}
