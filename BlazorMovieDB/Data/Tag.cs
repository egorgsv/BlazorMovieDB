using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class Tag
    {
        public string tag { get; set; }
        public string tagId { get; set; }
        public HashSet<MovieTag> MovieTags { get; set; }

        public Tag()
        {
            MovieTags = new HashSet<MovieTag>();
        }

        public void Write()
        {
            Console.WriteLine($"\nTag: {tag}");
            var movies = MovieTags.Select(mt => mt.Movie).ToList();
            foreach (Movie m in movies)
                Console.WriteLine($" Movie: {m.Title} (rating: {m.Rating})");
            Console.WriteLine($"____________________________");
        }
    }
}
