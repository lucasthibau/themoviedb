using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMovieDb.Models
{
    public class CompaniesModel
    {
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }
    }
}