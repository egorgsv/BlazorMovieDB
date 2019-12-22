using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class links_IMDB_MovieLens
    {
        [Key]
        public string movieId { get; set; }
        public string TconstId { get; set; }

        public string tmdbId { get; set; }
    }
}
