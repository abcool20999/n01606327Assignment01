using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606327Assignment01.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input {id} when receiving a Get request
        /// </summary>
        /// <param name="id">the input id is an integer</param>
        /// <returns>
        /// Get api/AddTen/21 -- > 31
        /// Get api/AddTen/0  -- > 10
        /// Get api/AddTen/-9 -- >  1
        /// </returns>
        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
          
    }
}
