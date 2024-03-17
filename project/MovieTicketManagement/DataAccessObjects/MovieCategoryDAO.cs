using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieCategoryDAO
    {
        public static List<MovieCategory> getAllCategory()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieCategories.ToList();
            }
        }

        public static void addNewCategory(MovieCategory c)
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(c);
                context.SaveChanges();
            }
        }

        public static int countID()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieCategories.Count() + 1;
            }
        }
    }
}
