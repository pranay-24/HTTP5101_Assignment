using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication12.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// API to calculate and output total hosting cost  given the number of days since hosting start
        /// </summary>
        /// <param name="id">No of days passing since start of Hosting</param>
        /// <returns>String message with details like subtotal cost , tax cost, total cost </returns>
        /// <examples>
        /// GET http://localhost:59124/api/HostingCost/0  -> 1 fortnights at $5.50/FN= $5.5 CADHST 13%= $0.715 CAD Total = $6.215 CAD
        ///  GET http://localhost:59124/api/HostingCost/14  ->  2 fortnights at $5.50/FN= $11 CADHST 13%= $1.43 CAD Total = $12.43 CAD
        ///  GET http://localhost:59124/api/HostingCost/28   ->  3 fortnights at $5.50/FN= $16.5 CADHST 13%= $2.145 CAD Total = $18.645 CAD
        /// </examples>

        [HttpGet] 
        [Route("api/HostingCost/{id}")]
        public string Get(int id) {

            var fortnight = id / 14;
            var subTotal = (fortnight + 1) * 5.5;
            var tax = subTotal * .13;
            var total = subTotal + tax;
            return ((fortnight + 1).ToString() + " fortnights at $5.50/FN= $" + subTotal.ToString() + " CAD " + "HST 13%= $" + tax.ToString() + " CAD \n" + "Total = $" + total.ToString() + " CAD" );     

            
        }
    }
}
