using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Domain
{
    public class Member
    {
        public int Id { get; set; }
        public string Party { get; set; }
        public string MemberFrom { get; set; }
        public string FullTitle { get; set; }
    }
}
