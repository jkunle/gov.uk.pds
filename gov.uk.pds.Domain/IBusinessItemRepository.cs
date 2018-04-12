using gov.uk.pds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Services
{
    public interface IBusinessItemRepository
    {
       
       Task<IEnumerable<BusinessItem>> FindAll();
       BusinessItem Find(int id);
    }
}
