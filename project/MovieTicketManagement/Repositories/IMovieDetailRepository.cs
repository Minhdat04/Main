using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMovieDetailRepository
    {
        List<MovieDetail> getAll();
        List<MovieDetail> getAllName(string name);
        void AddMovieDetail(MovieDetail movieDetail);
        int CountID();
        MovieDetail getAllId(int movieDetailID);
    }
}
