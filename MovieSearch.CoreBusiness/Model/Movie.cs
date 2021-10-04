using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieSearch.CoreBusiness.Model
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }

        public string language { get; set; }

        public string overview { get; set; }

        public double popularity { get; set; }
        
        public DateTime? release_date { get; set; }

        public double vote_average { get; set; }
        public string poster_path { get; set; }

        public int? runtime { get; set; }

        public List<Genre>? genres{ get; set; }

        public string? original_language { get; set; }


    }
}
