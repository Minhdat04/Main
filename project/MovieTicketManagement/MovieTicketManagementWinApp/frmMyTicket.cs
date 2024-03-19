using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketManagementWinApp
{
    public partial class frmMyTicket : Form
    {
        MovieTicketRepository movieTicketRepo = new MovieTicketRepository();
        public frmMyTicket(int MemAccId)
        {
            InitializeComponent();
            loadTicket(MemAccId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvTicket.Rows.Count > 0)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadTicket(int MemAccId)
        {
            dgvTicket.DataSource = movieTicketRepo.getAllWithID(MemAccId).Select(x => new
            {
                ID = x.TicketId,
                DATE = x.TicketDate,
                Movie = x.MovSd.Movie.MovieName,
                Time = x.MovSd.MovieSche.TimeSlot,
                Room = x.MovSd.MovieRoom.MovieRoomName,
                Quantity = x.Quantity,
                Price = x.TotalTicketPrice,
                Sit = x.SitDetail
            }).ToList();
        }
    }
}
