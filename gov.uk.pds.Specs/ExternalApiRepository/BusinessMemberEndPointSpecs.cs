using gov.uk.pds.ExternalApiRepository;
using NUnit.Framework;
using Should;
using SpecsFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gov.uk.pds.Specs.ExternalApiRepository
{
    public class BusinessMemberEndPointSpecs
    {
        public class when_calling_BusinessEndPointEndPoint : SpecsFor<BusinessMemberEndPoint>
        {
            //TODO: Put your result type here!
            private EndPointStatus _result;

            protected override void When()
            {
                //TODO: Put your action here!
                _result = SUT.Status(DataContextConstants.EventsAPI).Result;
            }

            [Test]
            public void then_it_returns_200_OK_status()
            {
                //TODO: Put your assertion here!
                _result.Status.ShouldEqual(200);
                _result.Reason.ShouldEqual("OK");
            }
        }
        public class when_calling_MemberEndPointEndPoint : SpecsFor<BusinessMemberEndPoint>
        {
            //TODO: Put your result type here!
            private EndPointStatus _result;

            protected override void When()
            {
                //TODO: Put your action here!
                _result = SUT.Status(string.Format(DataContextConstants.MemberAPI, 579)).Result;
            }

            [Test]
            public void then_it_returns_200_OK_status()
            {
                //TODO: Put your assertion here!
                _result.Status.ShouldEqual(200);
                _result.Reason.ShouldEqual("OK");
            }
        }
    }
}
