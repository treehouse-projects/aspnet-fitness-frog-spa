using System;
using System.Web;
using System.Web.Http;

namespace Treehouse.FitnessFrog.Spa
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
