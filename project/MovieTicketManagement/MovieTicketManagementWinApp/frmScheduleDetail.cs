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
    public partial class frmScheduleDetail : Form
    {
        MoviewScheduleDetailRepository msdRepo = new MoviewScheduleDetailRepository();
        MovieRoomRepository movieRoomRepo = new MovieRoomRepository();
        MovieScheduleRepository movieScheduleRepo = new MovieScheduleRepository();
        MovieRepository movieRepo = new MovieRepository();
        public frmScheduleDetail()
        {
            InitializeComponent();
            loadAll();
            txtID.Text = msdRepo.countID().ToString();
            comboboxRoom();
            comboboxSchedule();
            comboboxMovie();
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomid = (cmbRoom.SelectedItem as MovieRoom).MovieRoomId;
            DateTime d = dtpDate.Value.Date;
            loadAllWithCondition(roomid, d);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            int roomid = (cmbRoom.SelectedItem as MovieRoom).MovieRoomId;
            DateTime d = dtpDate.Value.Date;
            loadAllWithCondition(roomid, d);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string testMovieScheId = (cmbSchedule.SelectedItem as MovieSchedule).MovieScheId;
            int testRoomid = (cmbRoom.SelectedItem as MovieRoom).MovieRoomId;
            DateTime testDate = dtpDate.Value.Date;

            List<MoviewScheduleDetail> test = msdRepo.getAll().Where(x => x.MovieRoomId == testRoomid && x.Date == testDate && x.MovieScheId == testMovieScheId).ToList();
            if (test.Any())
            {
                MessageBox.Show("Already have schedule");
                return;
            }

            int MovSdid = int.Parse(txtID.Text);
            int MovieRoomId = (int)cmbRoom.SelectedValue;
            string MovieScheId = (string)cmbSchedule.SelectedValue;
            int Movieid = (int)cmbMovie.SelectedValue;
            DateTime Date = dtpDate.Value;
            string EmptySlot = "0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0 - 0";

            MoviewScheduleDetail m = new MoviewScheduleDetail()
            {
                MovSdid = MovSdid,
                MovieRoomId = MovieRoomId,
                MovieScheId = MovieScheId,
                MovieId = Movieid,
                Date = Date,
                EmptySlot = EmptySlot
            };

            DialogResult d = MessageBox.Show("Do you want to create schedule ", "Create schedule", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                msdRepo.addNew(m);
                txtID.Clear();
                txtID.Text = msdRepo.countID().ToString();
                loadAll();
            }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        public void loadAll()
        {
            var list = msdRepo.getAll().Select(x => new
            {
                ID = x.MovSdid,
                Room = x.MovieRoom.MovieRoomName,
                Schedule = x.MovieSche.TimeSlot,
                Movie = x.Movie.MovieName,
                Date = x.Date
            }).ToList();

            dgvDetail.DataSource = list;
        }

        public void loadAllWithCondition(int room, DateTime date)
        {
            var list = msdRepo.getAll().Where(x => x.MovieRoomId == room && x.Date == date).Select(x => new
            {
                ID = x.MovSdid,
                Room = x.MovieRoom.MovieRoomName,
                Schedule = x.MovieSche.TimeSlot,
                Movie = x.Movie.MovieName,
                Date = x.Date
            }).ToList();

            dgvDetail.DataSource = list;
        }

        public void comboboxRoom()
        {
            cmbRoom.DataSource = movieRoomRepo.getAll().Where(x => x.Status).ToList();
            cmbRoom.DisplayMember = "MovieRoomName";
            cmbRoom.ValueMember = "MovieRoomId";
            cmbRoom.SelectedIndex = 0;
        }

        public void comboboxSchedule()
        {
            cmbSchedule.DataSource = movieScheduleRepo.GetAll().ToList();
            cmbSchedule.DisplayMember = "TimeSlot";
            cmbSchedule.ValueMember = "MovieScheId";
            cmbSchedule.SelectedIndex = 0;
        }

        public void comboboxMovie()
        {
            cmbMovie.DataSource = movieRepo.getAll().Where(m => m.Status).ToList();
            cmbMovie.DisplayMember = "MovieName";
            cmbMovie.ValueMember = "MovieId";
            cmbMovie.SelectedIndex = 0;
        }

        private void cmbRoom_TextChanged(object sender, EventArgs e)
        {

        }
          
        private void btnFind_Click(object sender, EventArgs e)
        {


            string MovieScheId = (cmbSchedule.SelectedItem as MovieSchedule).MovieScheId;
            int roomid = (cmbRoom.SelectedItem as MovieRoom).MovieRoomId;
            DateTime d = dtpDate.Value.Date;

            List<MoviewScheduleDetail> test = msdRepo.getAll().Where(x => x.MovieRoomId == roomid && x.Date == d && x.MovieScheId == MovieScheId).ToList();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
