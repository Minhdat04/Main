using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MovieSchedule
    {
        public MovieSchedule()
        {
            MoviewScheduleDetails = new HashSet<MoviewScheduleDetail>();
        }

        public string MovieScheId { get; set; } = null!;
        public string TimeSlot { get; set; } = null!;

        public virtual ICollection<MoviewScheduleDetail> MoviewScheduleDetails { get; set; }
    }
}
