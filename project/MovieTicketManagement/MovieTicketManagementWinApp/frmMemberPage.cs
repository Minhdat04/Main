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
    public partial class frmMemberPage : Form
    {
        MovieDetailRepository movieDetailRepo = new MovieDetailRepository();
        MovieRepository movieRepo = new MovieRepository();
        MemberAccount m = new MemberAccount();
        public frmMemberPage(MemberAccount memberAccount)
        {
            m = memberAccount;
            InitializeComponent();
            lbCusName.Text = m.MemName.ToString();
            LoadImagesFromDatabase();

        }

        private void frmMemberPage_Load(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            frmBookTicket frmBookTicket = new frmBookTicket(m.MemAccId);
            frmBookTicket.Show();
        }

        private void lbVeCuaToi_DoubleClick(object sender, EventArgs e)
        {
            frmMyTicket frmMyTicket = new frmMyTicket();
            frmMyTicket.Show();
        }
        private void LoadImagesFromDatabase()
        {
            List<PictureBox> listpicturebox = new List<PictureBox>();
            listpicturebox.Add(moviePic1);
            listpicturebox.Add(moviePic2);
            listpicturebox.Add(moviePic3);
            listpicturebox.Add(moviePic4);
            var movieimg = movieDetailRepo.getAll().ToList();
            int numberOfPictures = Math.Min(movieimg.Count, listpicturebox.Count);
            for (int i = 0; i < numberOfPictures; i++)
            {
                listpicturebox[i].Image = ByteArrayToImage(movieimg[i].ImagePoster);
                listpicturebox[i].Tag = movieimg[i].MovieDetailId;

                // Gỡ bỏ sự kiện DoubleClick trước khi gán lại
                listpicturebox[i].DoubleClick -= moviePic1_DoubleClick;
                listpicturebox[i].DoubleClick += moviePic1_DoubleClick;
            }
        }
        private void LoadImagesFromDatabaseWithName(string name)
        {
            List<PictureBox> listpicturebox = new List<PictureBox>();
            listpicturebox.Add(moviePic1);
            listpicturebox.Add(moviePic2);
            listpicturebox.Add(moviePic3);
            listpicturebox.Add(moviePic4);
            var movieimg = movieDetailRepo.getAllName(name).ToList();
            int numberOfPictures = Math.Min(movieimg.Count, listpicturebox.Count);
            for (int i = 0; i < numberOfPictures; i++)
            {
                listpicturebox[i].Image = ByteArrayToImage(movieimg[i].ImagePoster);
                listpicturebox[i].Tag = movieimg[i].MovieDetailId;

                // Gỡ bỏ sự kiện DoubleClick trước khi gán lại
                listpicturebox[i].DoubleClick -= moviePic1_DoubleClick;
                listpicturebox[i].DoubleClick += moviePic1_DoubleClick;
            }
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void moviePic1_DoubleClick(object sender, EventArgs e)
        {
            // Lấy PictureBox mà người dùng đã nhấp đúp chuột
            PictureBox pictureBox = sender as PictureBox;

            // Lấy ID của phim từ Tag của PictureBox
            int movieID = (int)pictureBox.Tag;

            // Mở formDetail với ID của phim
            frmMovieBannerDetail frmMovieBannerDetail = new frmMovieBannerDetail(movieID);
            frmMovieBannerDetail.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemPhim_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(searchBox.Text.ToString()))
            {
                moviePic1.Image = null;
                moviePic2.Image = null;
                moviePic3.Image = null;
                moviePic4.Image = null;
                LoadImagesFromDatabaseWithName(searchBox.Text.ToString());
            }
            else
            {
                moviePic1.Image = null;
                moviePic2.Image = null;
                moviePic3.Image = null;
                moviePic4.Image = null;
                LoadImagesFromDatabase();
            }
        }
    }
}
