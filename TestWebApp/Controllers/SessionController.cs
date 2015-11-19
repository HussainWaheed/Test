using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TestWebApp.Controllers
{
    public class ApplicationController:ApiController
    {
        [HttpPost]
        public IHttpActionResult Session(SessionPostViewModel model)
        {
            Debug.WriteLine(model);
            return default(IHttpActionResult);
        }
    }
}