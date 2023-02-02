using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    public class Greeting2Controller : ApiController
    {
        [HttpGet]
        [Route("api/Greeting2/{num}")]
        public string Get(int num)
        {
            return "Greetings to " + num + " people"; 
        }
    }
}
