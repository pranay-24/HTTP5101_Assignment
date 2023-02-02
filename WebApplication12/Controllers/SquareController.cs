using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// API to return square of integer input num
        /// </summary>
        /// <param name="num"> integer input num </param>
        /// <returns> Square of num </returns>
        /// <example>
        /// GET http://localhost:59124/api/Square/10 -> 100
        /// GET http://localhost:59124/api/Square/-2  -> 4
        /// </example>

        [HttpGet]
        [Route("api/Square/{num}")]
        public int Get(int num)
        {
            return num*num;
        }
    }
}
