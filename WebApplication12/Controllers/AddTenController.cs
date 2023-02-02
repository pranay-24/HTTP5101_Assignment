using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///  API to return an input with 10 added to it 
        /// </summary>
        /// <param name="num">Integer input</param>
        /// <returns> Result of addition </returns>
        ///  <example>
        /// GET http://localhost:59124/api/AddTen/10  -> 20 
        /// </example>
        /// 
        [HttpGet]
        [Route("api/AddTen/{num}")]
        public int Get( int num)
        {
            return num+10;
        }

       
    }
}
