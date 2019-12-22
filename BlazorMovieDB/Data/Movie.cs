using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieDB.Data
{
    public class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
            MovieTags = new HashSet<MovieTag>();
        }

        [Key]
        public string TconstId { get; set; }

        public string Title { get; set; }
        public HashSet<MovieActor> MovieActors { get; set; }
        public HashSet<MovieTag> MovieTags { get; set; }
        public string Rating { get; set; }
        public string MovieId { get; set; }
        public string tmdbId { get; set; }

        public links_IMDB_MovieLens link { get; set; }

        public void similar()
        {
            var simular_movies = new HashSet<Movie>();
            var client = new RestClient($"https://api.themoviedb.org/3/movie/{tmdbId}/similar?page=1&language=en-US&api_key=7869fcb463cd3b1f40161bb8d85c011f");
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var content = response.Content;
                var data = JsonConvert.DeserializeObject<JObject>(content);
                var results = data["results"];
                foreach (var movie in results)
                {
                    simular_movies.Add(new Movie() { tmdbId = movie["id"].ToString(), Title = movie["title"].ToString() });
                }
            }
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine(" Similar:");
            foreach (var VARIABLE in simular_movies)
            {
                Console.WriteLine($"    Title: {VARIABLE.Title}");
            }
        }

        public void Write()
        {
            Console.WriteLine($"\nTitle: {Title}");
            if (Rating != null)
            {
                Console.WriteLine($" Reting: {Rating}");
            }

            var actors = MovieActors.Select(ma => ma.Actor).ToList();
            foreach (Actor a in actors)
                Console.WriteLine($"    Actor: {a.Name}");
            var tags = MovieTags.Select(mt => mt.Tag).ToList();
            foreach (Tag t in tags)
                Console.WriteLine($"    Tag: {t.tag}");
            Console.WriteLine($"____________________________");
        }
    }
}
