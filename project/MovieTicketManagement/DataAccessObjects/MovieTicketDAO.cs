using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieTicketDAO
    {
       public static List<MovieTicket> getAll()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieTickets.ToList();
            }
        }

        public static int countID()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieTickets.Count() + 1;
            }
        }

        public static void addTicket(MovieTicket ticket)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(ticket);
                context.SaveChanges();
            }
        }

        public static List<MovieTicket> getAllWithID(int MemAccId)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieTickets.Where(x => x.MemAccId == MemAccId).Include(x => x.MovSd)
                    .Include(x => x.MovSd.MovieRoom).Include(x => x.MovSd.MovieSche).Include(x => x.MovSd.Movie)
                    .ToList();
            }
        }
    }
}
