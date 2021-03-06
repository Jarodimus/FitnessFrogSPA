﻿using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Spa.App_Start;

namespace Treehouse.FitnessFrog.Spa
{
    public class WebApiApplication : HttpApplication
    {
        public object GlobalConfiugration { get; private set; }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
