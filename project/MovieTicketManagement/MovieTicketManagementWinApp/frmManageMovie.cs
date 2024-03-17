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
    public partial class frmManageMovie : Form
    {
        MovieRepository movieRepo = new MovieRepository();
        MovieCategoryRepository movieCategoryRepo = new MovieCategoryRepository();
        EmployeeAccount a = new EmployeeAccount();
        public frmManageMovie(EmployeeAccount employeeAccount)
        {
            InitializeComponent();
            a = employeeAccount;
            txtID.Text = movieRepo.countID().ToString();
            loadMovie();
            loadCombobox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int MovieId = int.Parse(txtID.Text);
            string MovieName = txtName.Text;
            if (string.IsNullOrEmpty(MovieName))
            {
                MessageBox.Show("Please input name");
                return;
            }

            if (string.IsNullOrEmpty(txtLength.Text))
            {
                MessageBox.Show("Please input length");
                return;
            }
            int MovieLength;
            if (!int.TryParse(txtLength.Text, out MovieLength))
            {
                MessageBox.Show("Please input length: integer");
                return;
            }

            DateTime MovieOpeningDay = dtpOpeningdate.Value;
            int CatId = (int)cmbCategory.SelectedValue;
            bool Status = true;

            Movie m = new Movie()
            {
                MovieId = MovieId,
                MovieName = MovieName,
                MovieLength = MovieLength,
                MovieOpeningDay = MovieOpeningDay,
                CatId = CatId,
                Status = Status
            };

            if (m != null)
            {
                DialogResult d = MessageBox.Show("Do you want to create new movie", "Create movie", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    movieRepo.addMovie(m);
                    loadMovie();
                    txtID.Clear();
                    txtName.Clear();
                    txtLength.Clear();
                    cmbCategory.SelectedIndex = 0;
                    frmMovieDetail frmMovieDetail = new frmMovieDetail(MovieId);
                    frmMovieDetail.Show();
                }
            }
        }
        public void loadMovie()
        {
            dgvMovie.DataSource = movieRepo.getAll().ToList();
        }

        public void loadCombobox()
        {
            cmbCategory.DataSource = movieCategoryRepo.GetAll().ToList();
            cmbCategory.SelectedIndex = 0;
            cmbCategory.DisplayMember = "CatName";
            cmbCategory.ValueMember = "CatId";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
