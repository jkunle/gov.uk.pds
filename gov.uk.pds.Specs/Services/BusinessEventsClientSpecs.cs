using gov.uk.pds.Domain;
using gov.uk.pds.Specs;
using Newtonsoft.Json;
using NUnit.Framework;
using Should;
using SpecsFor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gov.uk.pds.Specs.Specs
{
    public class BusinessEventsClientSpecs
    {
        public class when_calling_businessitems_events_url : SpecsFor<BusinessEvents>
        {
            //TODO: Put your result type here!
            private IEnumerable<BusinessItem> _result;

            protected override void When()
            {
                //TODO: Put your action here!
                //_result = SUT.DoSomething();
                _result = SUT.GetAsync().Result;
            }

            [Test]
            public void then_it_returns_businessitem_payload()
            {
                //TODO: Put your assertion here!
                _result.ShouldNotBeNull();
            }
        }
        public class when_calling_PDSMember_events_url : SpecsFor<PDSMember>
        {
            //TODO: Put your result type here!
            private Members _result;

            protected override void When()
            {
                //TODO: Put your action here!
                //_result = SUT.DoSomething();
                _result = SUT.GetAsync().Result;
            }

            [Test]
            public void then_it_returns_Members_payload()
            {
                //TODO: Put your assertion here!
                //_result.ShouldNotBeNull();
                _result.ShouldNotBeNull();
            }
        }
    }
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
    public class PDSMember {
        public async Task<Members> GetAsync() {

            var client = HttpClientHelper.GetClient();
            var url = new Uri("http://data.parliament.uk/membersdataplatform/services/mnis/members/query/id=579/");

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                string content = await response.Content.ReadAsStringAsync();

                var buffer = Encoding.UTF8.GetBytes(content);
                using (var stream = new MemoryStream(buffer))
                {
                    var serializer = new XmlSerializer(typeof(Members));
                    return (Members)serializer.Deserialize(stream);
                }
            }
            else {
                return new Members();
            }


        }
    }
  
    public class BusinessEvents
    {
        public async Task<IEnumerable<BusinessItem>> GetAsync()
        {
            HttpClient client = HttpClientHelper.GetClient();
            Uri url = new Uri("http://service.calendar.parliament.uk/calendar/events/list.json?startdate=2015-11-16&enddate=2015-11-20");

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<BusinessItem>>(content);
            }
            else
            {
                return Enumerable.Empty<BusinessItem>();
            }

        }

        
    }

    

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Members
    {

        private Member memberField;

        /// <remarks/>
        public Member Member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Member
    {

        private string displayAsField;

        private string listAsField;

        private string fullTitleField;

        private object layingMinisterNameField;

        private System.DateTime dateOfBirthField;

        private object dateOfDeathField;

        private string genderField;

        private Party partyField;

        private string houseField;

        private string memberFromField;

        private System.DateTime houseStartDateField;

        private object houseEndDateField;

        private CurrentStatus currentStatusField;

        private ushort member_IdField;

        private ushort dods_IdField;

        private ushort pims_IdField;

        private byte clerks_IdField;

        /// <remarks/>
        public string DisplayAs
        {
            get
            {
                return this.displayAsField;
            }
            set
            {
                this.displayAsField = value;
            }
        }

        /// <remarks/>
        public string ListAs
        {
            get
            {
                return this.listAsField;
            }
            set
            {
                this.listAsField = value;
            }
        }

        /// <remarks/>
        public string FullTitle
        {
            get
            {
                return this.fullTitleField;
            }
            set
            {
                this.fullTitleField = value;
            }
        }

        /// <remarks/>
        public object LayingMinisterName
        {
            get
            {
                return this.layingMinisterNameField;
            }
            set
            {
                this.layingMinisterNameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DateOfDeath
        {
            get
            {
                return this.dateOfDeathField;
            }
            set
            {
                this.dateOfDeathField = value;
            }
        }

        /// <remarks/>
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public Party Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        public string House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }

        /// <remarks/>
        public string MemberFrom
        {
            get
            {
                return this.memberFromField;
            }
            set
            {
                this.memberFromField = value;
            }
        }

        /// <remarks/>
        public System.DateTime HouseStartDate
        {
            get
            {
                return this.houseStartDateField;
            }
            set
            {
                this.houseStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object HouseEndDate
        {
            get
            {
                return this.houseEndDateField;
            }
            set
            {
                this.houseEndDateField = value;
            }
        }

        /// <remarks/>
        public CurrentStatus CurrentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Member_Id
        {
            get
            {
                return this.member_IdField;
            }
            set
            {
                this.member_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Dods_Id
        {
            get
            {
                return this.dods_IdField;
            }
            set
            {
                this.dods_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Pims_Id
        {
            get
            {
                return this.pims_IdField;
            }
            set
            {
                this.pims_IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Clerks_Id
        {
            get
            {
                return this.clerks_IdField;
            }
            set
            {
                this.clerks_IdField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Party
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CurrentStatus
    {

        private string nameField;

        private object reasonField;

        private System.DateTime startDateField;

        private byte idField;

        private string isActiveField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }
    }




    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Events
    {

        private Event eventField;

        /// <remarks/>
        public Event Event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Event
    {

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        private string startTimeField;

        private object endTimeField;

        private string descriptionField;

        private byte sortOrderField;

        private string typeField;

        private string houseField;

        private string categoryField;

        private bool hasSpeakersField;

        private object committeeField;

        private object tagsField;

        private object membersField;

        private object metadataField;

        private ushort idField;

        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public string StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public object EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public byte SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string House
        {
            get
            {
                return this.houseField;
            }
            set
            {
                this.houseField = value;
            }
        }

        /// <remarks/>
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public bool HasSpeakers
        {
            get
            {
                return this.hasSpeakersField;
            }
            set
            {
                this.hasSpeakersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Committee
        {
            get
            {
                return this.committeeField;
            }
            set
            {
                this.committeeField = value;
            }
        }

        /// <remarks/>
        public object Tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public object Members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }

        /// <remarks/>
        public object Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }



}
