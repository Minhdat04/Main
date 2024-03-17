using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MoviewScheduleDetailDAO
    {
        public static List<MoviewScheduleDetail> getAll()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MoviewScheduleDetails.Include(x => x.Movie).Include(x => x.MovieRoom).Include(x => x.MovieSche).ToList();
            }
        }

        public static int countID()
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MoviewScheduleDetails.Count() + 1;
            }
        }

        public static void AddScheduleDetail(MoviewScheduleDetail m)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(m);
                context.SaveChanges();
            }
        }

        public static void updateEmptySlot(int id, string emptySlot)
        {
            using (MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                MoviewScheduleDetail a = context.MoviewScheduleDetails.FirstOrDefault(x => x.MovSdid == id);
                if (a != null)
                {
                    a.EmptySlot = emptySlot;
                    context.SaveChanges();
                }
            }
        }
    }
}
