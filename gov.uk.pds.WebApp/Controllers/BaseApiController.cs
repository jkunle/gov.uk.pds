using gov.uk.pds.ExternalApiRepository;
using gov.uk.pds.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace gov.uk.pds.WebApp.Controllers
{
    public class BaseApiController : ApiController
    {
        private BusinessAppServices _AppService;
        public BaseApiController()
        {
            _AppService = new BusinessAppServices(
                new MemberRepository(),
                new BusinessItemRepository());
        }
        public BusinessAppServices AppService {
            get { return _AppService; }
        }
    }
}
