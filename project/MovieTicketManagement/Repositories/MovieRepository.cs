using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> getAll() => MovieDAO.getAll();
        public void addMovie(Movie movie) => MovieDAO.AddMovie(movie);
        public int countID() => MovieDAO.countID();

    }
}
