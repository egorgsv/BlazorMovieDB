using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class MovieTag
    {
        public string TagId { get; set; }
        public Tag Tag { get; set; }

        public string MovieTconstId { get; set; }
        public Movie Movie { get; set; }
    }
}
