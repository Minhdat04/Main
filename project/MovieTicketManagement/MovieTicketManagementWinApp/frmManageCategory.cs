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
    public partial class frmManageCategory : Form
    {
        MovieCategoryRepository movieRepo = new MovieCategoryRepository();
        EmployeeAccount a = new EmployeeAccount();
        public frmManageCategory(EmployeeAccount employeeAccount)
        {
            a = employeeAccount;
            InitializeComponent();
            loadCategory();
            txtNewID.Text = movieRepo.Count().ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtNewID.Text);
            string name = txtNewName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name");
                return;
            }

            MovieCategory movieCategory = new MovieCategory()
            {
                CatId = id,
                CatName = name,
            };

            if (movieCategory != null)
            {
                DialogResult d = MessageBox.Show("Do you want to create category", "Create category", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    movieRepo.Add(movieCategory);
                    loadCategory();
                    txtNewID.Text = movieRepo.Count().ToString();
                    txtNewName.Clear();
                }
            }
        }

        public void loadCategory()
        {
            dgvCategory.DataSource = movieRepo.GetAll().ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
