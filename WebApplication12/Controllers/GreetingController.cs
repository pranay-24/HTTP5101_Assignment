using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    
    public class GreetingController : ApiController
    {
        /// <summary>
        /// API to POST  string  at a route
        /// </summary>
        /// <returns> Hello World string </returns>
        /// <example>
        /// 
        /// </example>
        [HttpPost]

        [Route("api/Greeting")]
        public string Post()
        {
            return "Hello World!";
        }
    }
}
