using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class MovieActor
    {
        public string ActorNconstId { get; set; }
        public Actor Actor { get; set; }

        public string MovieTconstId { get; set; }
        public Movie Movie { get; set; }

    }
}
