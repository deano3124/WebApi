using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApi.Interfaces;
using WebApi.Interfaces.Models;

namespace WebApi.Controllers
{
    public class DemoController : ApiController
    {
        //private readonly IDemoTasks DemoTasks;

        //public DemoController(IDemoTasks demoTasks)
        //{
        //    DemoTasks = demoTasks;
        //}

        public string Get()
        {
            return "Welcome To Web API";
        }
        public List<string> Get( int Id )
        {
            return new List<string> {
                                            "Data1",
                                            "Data2"
                                        };
        }

        /// <summary>
        ///     returns number1.
        /// </summary>
        //[Route("api/Demo/Number1")]
        //public ApiResultModel Number1()
        //{
        //    var result = DemoTasks.Number1();

        //    return result;
        //}
    }
}
