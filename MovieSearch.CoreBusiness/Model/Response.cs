using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSearch.CoreBusiness.Model
{
    public class Response
    {
        public int page { get; set; }

        public List<Movie> results { get; set; }

        public int total_pages { get; set; }
    }
}
