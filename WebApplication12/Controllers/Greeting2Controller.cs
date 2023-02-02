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
        /// <summary>
        /// API to display string  at a route with an input 
        /// </summary>
        /// <returns> displays string with input  </returns>
        /// <example>
        /// GET http://localhost:59124/api/Greeting2/2  -> Greetings to 2 people
        /// GET  http://localhost:59124/api/Greeting2/6  -> Greetings to 6 people
        ///  
        /// </example>
        /// 

        [HttpGet]
        [Route("api/Greeting2/{num}")]
        public string Get(int num)
        {
            return "Greetings to " + num + " people"; 
        }
    }
}
