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
        /// 
        /// </summary>
        /// <param name="num">Integer input</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/AddTen/{num}")]
        public int Get( int num)
        {
            return num+10;
        }

       
    }
}
