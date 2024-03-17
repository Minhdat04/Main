using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MovieRoom
    {
        public MovieRoom()
        {
            MoviewScheduleDetails = new HashSet<MoviewScheduleDetail>();
        }

        public int MovieRoomId { get; set; }
        public string MovieRoomName { get; set; } = null!;
        public int SitPlaceTotal { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<MoviewScheduleDetail> MoviewScheduleDetails { get; set; }
    }
}
