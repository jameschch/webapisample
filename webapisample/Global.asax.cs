﻿using System;
using System.Web.Http;
using System.Web.Routing;

namespace webapisample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configuration.Routes.MapHttpRoute("Default", "{controller}/{id}", new { id = RouteParameter.Optional });
        }
    }
}
