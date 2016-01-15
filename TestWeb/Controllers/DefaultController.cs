using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace TestWeb.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("test")]
        [ResponseType(typeof(string))]
        [HttpGet]
        public string Get()
        {
            return "hello";
        }
    }
}
