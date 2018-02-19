using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ADTest.Models;
using System.IO;

namespace ADTest.Controllers
{
    public class CalcController : ApiController
    {

        [Route("api/add")]
        [HttpPost]
        public HttpResponseMessage Add([FromUri]CalcInput input)
        {

            HttpResponseMessage response = Request.CreateResponse();

            return response;
        }

        [Route("api/subtract")]
        [HttpPost]
        public HttpResponseMessage Subtract([FromUri]CalcInput input)
        {

            HttpResponseMessage response = Request.CreateResponse();

            return response;
        }
    }
}
