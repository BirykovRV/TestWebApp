using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class SearchResult
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
    }
}