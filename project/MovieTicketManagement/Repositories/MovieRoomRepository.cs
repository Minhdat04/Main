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
}
