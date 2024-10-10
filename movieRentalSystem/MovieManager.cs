using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieRentalSystem
{
    public  class MovieManager
    {
        public List<Movie> MovieList = new List<Movie>();

        public void CreateMovie(int movieId, string title, string director, decimal rentalprice)
        {
            Movie movie = new Movie(movieId, title, director, rentalprice);
            MovieList.Add(movie);
        }
        public void ReadMovie()
        {
            if (MovieList.Count > 0)
            {
                foreach (Movie movie in MovieList)
                {
                    Console.WriteLine(movie.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no movies");
            }
        }

        public void updateMovie(int movieId, string NewTitle, string NewDirector, decimal NewRentalprice)
        {
            var movie = MovieList.FirstOrDefault(m=> m.MovieId == movieId);
            if (movie != null)
            {
                movie.Title = NewTitle;
                movie.Director = NewDirector;
                movie.Rentalprice = NewRentalprice;
                Console.WriteLine("movie updated successfully");
            }
            else
            {
                Console.WriteLine("movie is not found");
            }
        }

        public void DeleteMovie(int movieId)
        {
            var movie = MovieList.FirstOrDefault(m => m.MovieId == movieId);
            if (movie != null)
            {
               MovieList.Remove(movie);
                Console.WriteLine("movie deleted successfully");
            }
            else
            {
                Console.WriteLine("movie is not found");
            }
        }
    }
}
