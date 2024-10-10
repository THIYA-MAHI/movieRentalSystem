using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieRentalSystem
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public decimal Rentalprice {  get; set; }

        public Movie(int movieId, string title, string director, decimal rentalprice)
        {
            MovieId = movieId;
            Title = title;
            Director = director;
            Rentalprice = rentalprice;
        }

        public override string ToString()
        {
            return $"ID: {MovieId}, Title: {Title}, Director: {Director}, RentalPrice: {RentalPrice}";
        }
    }
}
