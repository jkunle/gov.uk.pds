using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.ExternalApiRepository
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public object Notes { get; set; }
        public int SortOrder { get; set; }
        public string Type { get; set; }
        public string House { get; set; }
        public string Category { get; set; }
        public object Location { get; set; }
        public object LocationMetadata { get; set; }
        public bool HasSpeakers { get; set; }
        public object Committee { get; set; }
        public object[] Tags { get; set; }
        public IList<Member> Members { get; set; }
        public object[] Metadata { get; set; }
        public string SummarisedDetails { get; set; }
    }
    public partial class Member {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}

