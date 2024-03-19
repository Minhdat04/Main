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
    public partial class frmMovieBannerDetail : Form
    {
        MovieDetailRepository movieDetailRepo = new MovieDetailRepository();
        int moviewDetailId;
        public frmMovieBannerDetail(int moviewDetailID)
        {
            InitializeComponent();
            moviewDetailId = moviewDetailID;
            LoadImages();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moviePicBox_Click(object sender, EventArgs e)
        {

        }
        private void LoadImages()
        {
            var movie = movieDetailRepo.getAllId(moviewDetailId);
            movieName1.Text = movie.Movie.MovieName.ToString();
            movieLength.Text = movie.Movie.MovieLength.ToString();
            movieOpeningDay.Text = movie.Movie.MovieOpeningDay.ToString();
            movieReleaseYear.Text = movie.ReleasedYear.ToString();
            movieCountry.Text = movie.Country.ToString();
            movieDirectorName.Text = movie.DirectorName.ToString();
            movieLimitAge.Text = movie.LimitAge.ToString();
            movieDescription.Text = movie.MovieDescription.ToString();
            moviePicBox.Image = ByteArrayToImage(movie.ImagePoster);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

    }
}
