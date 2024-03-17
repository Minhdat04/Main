using BusinessObjects.Models;
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
    public partial class frmBookTicket : Form
    {
        int accid;
        MoviewScheduleDetailRepository msdRepo = new MoviewScheduleDetailRepository();
        public frmBookTicket(int MemAccId)
        {
            InitializeComponent();
            accid = MemAccId;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string movieName = txtFind.Text;
            if(string.IsNullOrEmpty(movieName) )
            {
                MessageBox.Show("Please enter movie name");
                return;
            }
            DateTime d = dtpDate.Value.Date;

            var list = msdRepo.getAll().Where(x => x.Date == d).Select(x => new
            {
                ID = x.MovSdid,
                Room = x.MovieRoom.MovieRoomName,
                Schedule = x.MovieSche.TimeSlot,
                Movie = x.Movie.MovieName,
                Date = x.Date
            });

            var find = list.Where(x => x.Movie.ToString().Contains(movieName)).ToList();

            dgvPhim.DataSource = find;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if(dgvPhim.SelectedRows.Count > 0)
            {
                int MovSdid = (int)dgvPhim.SelectedRows[0].Cells["ID"].Value;
                DateTime d = dtpDate.Value.Date;
                frmBookTicketDetail frmBookTicketDetail = new frmBookTicketDetail(MovSdid ,accid, d);
                frmBookTicketDetail.Show();
                
            }
            else
            {
                MessageBox.Show("Please choose to book ticket");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
