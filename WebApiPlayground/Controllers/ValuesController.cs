using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiPlayground.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Post(GuidValue val)
        {
            // Do what you want with Guid (val.Id)
            return Created("", val);
        }
    }

    public class GuidValue
    {
        public string Id { get; set; }
    }
}
