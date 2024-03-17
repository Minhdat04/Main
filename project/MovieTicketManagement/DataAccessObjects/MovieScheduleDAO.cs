using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieScheduleDAO
    {
        public static List<MovieSchedule> getAll()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieSchedules.ToList();
            }
        }

        public static void addSchedule(MovieSchedule movieSchedule) 
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(movieSchedule);
                context.SaveChanges();
            }
        }
    }
}
