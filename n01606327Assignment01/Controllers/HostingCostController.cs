using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606327Assignment01.Controllers
{

    
    public class HostingCostController : ApiController
    {
        ///<summary>
        /// This method takes an integer input {id} which represents the number of days elapsed, and applies
        /// a charge of $5.50 every 14 days for web hosting and maintenance, plus 13% HST and
        /// outputs three strings describing the total cost based on the elapsed days.
        /// </summary>
        /// <param name="id">the input id is an integer</param>
        /// <returns>
        /// GET api/HostingCost/0  --> 1 fortnights at $5.50/FN = $5.50 CAD”“HST 13% = $0.72 CAD”“Total = $6.22 CAD
        /// GET api/HostingCost/14 --> 2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD
        /// GET api/HostingCost/15 --> 2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD
        /// GET api/HostingCost/21 --> 2 fortnights at $5.50/FN = $11.00 CAD”“HST 13% = $1.43 CAD”“Total = $12.43 CAD
        /// GET api/HostingCost/28 --> 3 fortnights at $5.50/FN = $16.50 CAD”“HST 13% = $2.14 CAD”“Total = $18.64 CAD
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            double hosting = (id / 14 + 1);
            double cost = hosting * 5.50;
            double hst = cost * 0.13;
            double total = cost + hst;
            string costPrice = cost.ToString("0.00");
            string hostingPrice = hosting.ToString("0.00");
            string hstInterest = hst.ToString("0.00");
            string totalInterest = total.ToString("0.00");


            return new string[] 
            {
                hosting + "fortnights at $5.50/FN = $" + costPrice + "CAD",  "HST 13% = $" + hstInterest + "CAD", "Total = $" + totalInterest + "CAD" 
            };
        }
        

    }


}
