using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class Actor
    {
        [Key]
        public string NconstId { get; set; }

        public HashSet<MovieActor> MovieActors { get; set; }

        public string Name { get; set; }

        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public void Write()
        {
            Console.WriteLine($"\nActor: {Name}");
            var movies = MovieActors.Select(ma => ma.Movie).ToList();
            foreach (Movie m in movies)
            {
                Console.WriteLine($" Movie: {m.Title} (rating: {m.Rating})");
            }

            Console.WriteLine($"____________________________");
        }
    }
}
