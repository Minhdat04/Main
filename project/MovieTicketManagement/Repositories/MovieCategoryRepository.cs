using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieCategoryRepository : IMovieCategoryRepository
    {
        public List<MovieCategory> GetAll() => MovieCategoryDAO.getAllCategory();
        public void Add(MovieCategory movieCategory) => MovieCategoryDAO.addNewCategory(movieCategory);
        public int Count() => MovieCategoryDAO.countID();
    }
}
