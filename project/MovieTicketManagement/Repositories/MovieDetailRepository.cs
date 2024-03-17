using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieDetailRepository : IMovieDetailRepository
    {
        public List<MovieDetail> getAll() => MovieDetailDAO.getAll();
        public void AddMovieDetail(MovieDetail movieDetail) => MovieDetailDAO.addNewMovieDetail(movieDetail);
        public int CountID() => MovieDetailDAO.countID();
    }
}
