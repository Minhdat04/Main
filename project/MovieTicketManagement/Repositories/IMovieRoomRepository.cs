using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMovieRoomRepository
    {
        List<MovieRoom> getAll();
    }
    public void addRoom(MovieRoom room);
    public void updateRoom(MovieRoom room);
}
