using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieScheduleRepository : IMovieScheduleRepository
    {
        public List<MovieSchedule> GetAll() => MovieScheduleDAO.getAll();
        public void Add(MovieSchedule movieSchedule) => MovieScheduleDAO.addSchedule(movieSchedule);
        
    }
}
