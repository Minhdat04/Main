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
        void AddMovieDetail(MovieDetail movieDetail);
        int CountID();
    }
}
