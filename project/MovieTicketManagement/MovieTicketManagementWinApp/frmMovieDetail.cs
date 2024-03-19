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
    public partial class frmMovieDetail : Form
    {
        MovieDetailRepository movieDetailRepo = new MovieDetailRepository();
        public frmMovieDetail(int movieID)
        {
            InitializeComponent();
            loadDetail();
            txtMovieID.Text = movieID.ToString();
            txtID.Text = movieDetailRepo.CountID().ToString();
            btnDone.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int MovieDetailId = int.Parse(txtMovieID.Text);
            int MovieId = int.Parse(txtID.Text);

            if (string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Please input year");
                return;
            }
            int ReleasedYear;
            if (!int.TryParse(txtYear.Text, out ReleasedYear))
            {
                MessageBox.Show("Please input year: integer");
                return;

            }

            string Country = txtCountry.Text;
            if (string.IsNullOrEmpty(Country))
            {
                MessageBox.Show("Please input country");
                return;
            }

            string DirectorName = txtDirector.Text;
            if (string.IsNullOrEmpty(DirectorName))
            {
                MessageBox.Show("Please input Director Name");
                return;
            }
            if (string.IsNullOrEmpty(txtFileImg.Text))
            {
                MessageBox.Show("Please choose image");
                return;
            }
            byte[] ImagePoster = File.ReadAllBytes(txtFileImg.Text);

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please input age");
                return;
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please input age");
                return;
            }
            int LimitAge;
            if (!int.TryParse(txtAge.Text, out LimitAge))
            {
                MessageBox.Show("Please input age: integer");
                return;

            }
            string? MovieDescription = txtDirector.Text;

            MovieDetail m = new MovieDetail()
            {
                MovieDetailId = MovieDetailId,
                MovieId = MovieId,
                ReleasedYear = ReleasedYear,
                Country = Country,
                DirectorName = DirectorName,
                ImagePoster = ImagePoster,
                LimitAge = LimitAge,
                MovieDescription = MovieDescription
            };

            if (m != null)
            {
                DialogResult d = MessageBox.Show("Do youy want to create movie detail", "Create movie detail", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    movieDetailRepo.AddMovieDetail(m);
                    loadDetail();
                    btnCreate.Enabled = false;
                    btnDone.Enabled = true;
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "Tệp ảnh (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tất cả các tệp (*.*)|*.*";
            DialogResult d = openFileDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                picture.ImageLocation = openFileDialog.FileName;
                txtFileImg.Text = openFileDialog.FileName;
            }
        }

        public void loadDetail()
        {
            dgvDetail.DataSource = movieDetailRepo.getAll().ToList();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void dgvDetail_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
