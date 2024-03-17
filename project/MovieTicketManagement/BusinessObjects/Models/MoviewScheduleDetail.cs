using System;
using System.Collections.Generic;

namespace BusinessObjects.Models
{
    public partial class MoviewScheduleDetail
    {
        public MoviewScheduleDetail()
        {
            MovieTickets = new HashSet<MovieTicket>();
        }

        public int MovSdid { get; set; }
        public int MovieRoomId { get; set; }
        public string MovieScheId { get; set; } = null!;
        public int MovieId { get; set; }
        public DateTime Date { get; set; }
        public string EmptySlot { get; set; } = null!;

        public virtual Movie Movie { get; set; } = null!;
        public virtual MovieRoom MovieRoom { get; set; } = null!;
        public virtual MovieSchedule MovieSche { get; set; } = null!;
        public virtual ICollection<MovieTicket> MovieTickets { get; set; }
    }
}
