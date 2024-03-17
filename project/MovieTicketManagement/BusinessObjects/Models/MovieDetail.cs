using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MovieDetail
    {
        public int MovieDetailId { get; set; }
        public int MovieId { get; set; }
        public int ReleasedYear { get; set; }
        public string Country { get; set; } = null!;
        public string DirectorName { get; set; } = null!;
        public byte[] ImagePoster { get; set; } = null!;
        public int LimitAge { get; set; }
        public string? MovieDescription { get; set; }

        public virtual Movie Movie { get; set; } = null!;
    }
}
