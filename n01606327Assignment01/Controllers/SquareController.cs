using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606327Assignment01.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method returns the square of the integer input {id}, when receiving a Get request
        /// </summary>
        /// <param name="id">the input id is an integer</param>
        /// <returns>
        /// Get api/Square/2 --> 4
        /// Get api/Square/-2 --> 4
        /// Get api/Square/10 --> 100
        /// </returns>


        public int Get(int id)
        {
            int square = id * id;

            return square;

        }

    }
}
