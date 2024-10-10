using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager manager = new MovieManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Movie Rental Management System:");
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Update a Movie");
                Console.WriteLine("4. Delete a Movie");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Createmovie(manager);

                        break;
                    case 2:
                        Console.Clear();
                        manager.ReadMovie();

                        break;
                    case 3:
                        Console.Clear();
                       updateMovie(manager);
                        break;
                    case 4:
                        Console.Clear();
                        deleteMovie(manager);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("please select valid option");
                        break;
                }
            }
        }
        static void Createmovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieid = int.Parse( Console.ReadLine());
            Console.WriteLine("2. enter the movie title");
            string movietitle = Console.ReadLine();
            Console.WriteLine("3. enther the movie director name");
            string moviedirector = Console.ReadLine();
            Console.WriteLine("4. enther the rental parice");
            int rentalprice = int.Parse(Console.ReadLine());
            manager1.CreateMovie(movieid, movietitle, moviedirector, rentalprice);
        }
        static void updateMovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieid = int.Parse(Console.ReadLine());
            Console.WriteLine("2. enter the new movie title");
            string newtitle = Console.ReadLine();
            Console.WriteLine("3. enther the new movie director name");
            string newdirector = Console.ReadLine();
            Console.WriteLine("4. enther the new rental parice");
            int newprice = int.Parse(Console.ReadLine());
            manager1.updateMovie(movieid,newtitle,newdirector,newprice);
        }

        static void deleteMovie(MovieManager manager1)
        {
            Console.WriteLine("1. enter the movie id");
            int movieid = int.Parse(Console.ReadLine());
            manager1 .DeleteMovie(movieid);
        }
    }
}
