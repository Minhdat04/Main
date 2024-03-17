using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieRoomDAO
    {
        public static List<MovieRoom> getAll()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            { 
                return context.MovieRooms.ToList();
            }
        }
    }
}
