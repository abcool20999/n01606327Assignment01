using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606327Assignment01.Controllers
{
    
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns a single string, when receiving a post request
        /// </summary>
        /// <greeting> POST api/greeting </greeting>
        /// <returns> [ "Hello World" ]</returns>

        public string Post()
        {
            return "Hello world!";
        }



        /// <summary>
        /// This method returns a single string, when receiving a get request
        /// </summary>
        /// <param name="id">The input id is an integer format</param>
        /// <returns>
        /// Get api/Greeting/3 => "Greetings to 3 people!"
        /// Get api/Greeting/6 => "Greetings to 6 people!"
        /// Get api/Greeting/0 => "Greetings to 0 people!"
        /// </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people";
        }

    }
}