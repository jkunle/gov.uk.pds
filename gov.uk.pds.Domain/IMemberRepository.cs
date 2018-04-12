using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Domain
{
    public interface IMemberRepository
    {
        Task<Domain.Member> Find(int id);
       
    }
}
