using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606327Assignment01.Controllers
{
    public class MachineController : ApiController {

        /// <summary>
        /// This method has an input {id} and applies four mathematical operations to it
        /// </summary>
        /// <param name="id">the input id is an integer</param>
        /// <returns>
        /// GET api/Machine/10 --> 30
        /// GET api/Machine/-5 --> -22
        /// GET api/Machine/30 --> 100
        /// </returns>

        public int Get(int id)
        {
            int operations = (((id * 7)/2) + 5 - 10);
            return operations;
        }

    }
}
