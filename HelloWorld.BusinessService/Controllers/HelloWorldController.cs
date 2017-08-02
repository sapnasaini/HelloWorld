using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
/// <summary>
///     API controller for getting string.
/// </summary>
namespace HelloWorld.BusinessService.Controllers
{
    public class HelloWorldController : ApiController
    {
      
        public string Get()
        {
            return  "Hello World" ;
        }

        // GET api/helloworld/5
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
