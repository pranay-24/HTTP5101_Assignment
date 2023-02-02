using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    
    public class numberMachineController : ApiController
    {
        /// <summary>
        /// API which applies four mathematical operations to an int input 
        /// </summary>
        /// <param name="number">int input number</param>
        /// <returns> result of four maths operations to the input</returns>
        /// <example>
        /// GET http://localhost:59124/api/NumberMachine/10 -> 10
        /// GET http://localhost:59124/api/NumberMachine/100  -> 100
        /// </example>
        /// 
        [HttpGet]
        [Route("api/numberMachine/{number}")]
        public int Get(int number)
        {
            var result = ((((number + 5) * 2) / 2) - 5);
            return result;
        }
    }
}
