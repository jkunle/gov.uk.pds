using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.ExternalApiRepository
{
    public class DataContextConstants
    {
        public const string EventsAPI = "http://service.calendar.parliament.uk/calendar/events/list.json?startdate=2015-11-16&enddate=2015-11-20";
        public const string MemberAPI = "http://data.parliament.uk/membersdataplatform/services/mnis/members/query/id={0}";
    }
}
