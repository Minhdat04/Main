using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieDetails = new HashSet<MovieDetail>();
            MoviewScheduleDetails = new HashSet<MoviewScheduleDetail>();
        }

        public int MovieId { get; set; }
        public string MovieName { get; set; } = null!;
        public int MovieLength { get; set; }
        public DateTime MovieOpeningDay { get; set; }
        public int CatId { get; set; }
        public bool Status { get; set; }

        public virtual MovieCategory Cat { get; set; } = null!;
        public virtual ICollection<MovieDetail> MovieDetails { get; set; }
        public virtual ICollection<MoviewScheduleDetail> MoviewScheduleDetails { get; set; }
    }
}
