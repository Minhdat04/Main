using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieRoomRepository : IMovieRoomRepository
    {
        public List<MovieRoom> getAll() => MovieRoomDAO.getAll();
    }
    public void addRoom(MovieRoom room) => MovieRoomDAO.addRoom(room);
    public void updateRoom(MovieRoom room) => MovieRoomDAO.updateRoom(room);
}
