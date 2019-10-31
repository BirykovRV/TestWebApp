using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestWebApp.Models;

namespace TestWebApp
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //using SearchContext searchContext = new SearchContext();

            //List<SearchEngine> engine = new List<SearchEngine>
            //{
            //    new SearchEngine()
            //    {
            //        Name = "Google",
            //        Url = "https://www.google.ru/"
            //    },
            //    new SearchEngine()
            //    {
            //        Name = "Yandex",
            //        Url = "https://yandex.ru/"
            //    },
            //    new SearchEngine()
            //    {
            //        Name = "Bing",
            //        Url = "https://www.bing.com/"
            //    }
            //};
            //searchContext.SearchEngines.AddRange(engine);
            //searchContext.SaveChanges();
        }
    }
}
