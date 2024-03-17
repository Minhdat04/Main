using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieDAO
    {
        public static List<Movie> getAll()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext()) 
            {
                return context.Movies.ToList();
            }
        }

        public static void AddMovie(Movie movie) 
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(movie);
                context.SaveChanges();
            }
        }

        public static int countID()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.Movies.Count() + 1;
            }
        }
    }
}
