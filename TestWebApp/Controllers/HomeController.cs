using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly SearchContext context = new SearchContext();
        public ActionResult Index()
        {
            IEnumerable<SearchEngine> engines = context.SearchEngines;
            IEnumerable<SearchResult> results = context.SearchResults;
            ViewBag.Engines = engines;
            ViewBag.SearchResult = results;
            return View();
        }
    }
}