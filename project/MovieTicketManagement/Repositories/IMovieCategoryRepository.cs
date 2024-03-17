using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMovieCategoryRepository
    {
        List<MovieCategory> GetAll();
        void Add(MovieCategory category);
        int Count();
    }
}
