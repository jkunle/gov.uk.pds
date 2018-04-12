using gov.uk.pds.Domain;
using gov.uk.pds.ExternalApiRepository;
using gov.uk.pds.Specs.ExternalApiRepository;
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

    public class DataContextSpecs
    {
        public class when_calling_DataContext_BusinessItems : SpecsFor<DataContext>
        {
            //TODO: Put your result type here!
            private IEnumerable<BusinessItem> _result;

            protected override void When()
            {
                //TODO: Put your action here!
                _result = SUT.GetBusinessItemsAsync().Result;
            }
            [Test]
            public void then_it_returns_businessItems()
            {
                //TODO: Put your assertion here!
                _result.ShouldNotBeNull();
            }
        }
        public class when_calling_DataContext_GetMemberAsync : SpecsFor<DataContext>
        {
            //TODO: Put your result type here!
            private Domain.Member _result;

            protected override void When()
            {
                //TODO: Put your action here!
                _result = SUT.GetMemberAsync(579).Result;
            }
            [Test]
            public void then_it_returns_GetMemberAsync()
            {
                //TODO: Put your assertion here!
                _result.ShouldNotBeNull();
            }
        }
    }
}
