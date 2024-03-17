using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MovieCategory
    {
        public MovieCategory()
        {
            Movies = new HashSet<Movie>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; } = null!;

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
