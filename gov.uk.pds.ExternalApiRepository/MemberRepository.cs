using gov.uk.pds.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.ExternalApiRepository
{
    public class MemberRepository : IMemberRepository
    {
        public async Task<Domain.Member> Find(int id)
        {
            var context = new DataContext();
            return await context.GetMemberAsync(id);
        }

       
    }
}
