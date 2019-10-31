using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class SearchContext: DbContext
    {
        public SearchContext() : base("DBConnection") { }

        public DbSet<SearchResult> SearchResults { get; set; }
        public DbSet<SearchEngine> SearchEngines { get; set; }
    }
}