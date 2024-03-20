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
    public static void addRoom(MovieRoom room)
{
    using var context = new MovieTicketManagementContext();
    context.MovieRooms.Add(room);
    context.SaveChanges();
}
public static void updateRoom(MovieRoom room)
{
    using var context = new MovieTicketManagementContext();
    context.MovieRooms.Update(new MovieRoom
    {
        MovieRoomId = room.MovieRoomId,
        MovieRoomName = room.MovieRoomName,
        SitPlaceTotal = 25,
        Status = room.Status,
    });
    context.SaveChanges();
}
}
