namespace MovieTicketManagementWinApp
{
    partial class frmMovieDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            txtCountry = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            Year = new Label();
            txtMovieDetailID = new Label();
            btnCreate = new Button();
            txtID = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txtMovieID = new TextBox();
            txtDirector = new TextBox();
            txtAge = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            picture = new PictureBox();
            txtFileImg = new TextBox();
            btnFile = new Button();
            dgvDetail = new DataGridView();
            btnDone = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 177);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 25;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 210);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 24;
            label5.Text = "Director";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(118, 144);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(98, 27);
            txtCountry.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 144);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 21;
            label4.Text = "Country";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(118, 111);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(98, 27);
            txtYear.TabIndex = 20;
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(27, 111);
            Year.Name = "Year";
            Year.Size = new Size(37, 20);
            Year.TabIndex = 19;
            Year.Text = "Year";
            // 
            // txtMovieDetailID
            // 
            txtMovieDetailID.AutoSize = true;
            txtMovieDetailID.Location = new Point(27, 78);
            txtMovieDetailID.Name = "txtMovieDetailID";
            txtMovieDetailID.Size = new Size(24, 20);
            txtMovieDetailID.TabIndex = 18;
            txtMovieDetailID.Text = "ID";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(18, 286);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(118, 78);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(98, 27);
            txtID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 14;
            label1.Text = "Movie detail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 45);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 27;
            label7.Text = "Movie ID";
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(118, 45);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.ReadOnly = true;
            txtMovieID.Size = new Size(98, 27);
            txtMovieID.TabIndex = 26;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(118, 210);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(218, 27);
            txtDirector.TabIndex = 28;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(118, 177);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(98, 27);
            txtAge.TabIndex = 29;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(118, 243);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(285, 27);
            txtDescription.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 243);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 31;
            label2.Text = "Description";
            // 
            // picture
            // 
            picture.Location = new Point(409, 78);
            picture.Name = "picture";
            picture.Size = new Size(206, 192);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 32;
            picture.TabStop = false;
            // 
            // txtFileImg
            // 
            txtFileImg.Location = new Point(365, 45);
            txtFileImg.Name = "txtFileImg";
            txtFileImg.Size = new Size(250, 27);
            txtFileImg.TabIndex = 34;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(250, 43);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(109, 29);
            btnFile.TabIndex = 35;
            btnFile.Text = "Choose file";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(118, 286);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.RowTemplate.Height = 29;
            dgvDetail.Size = new Size(497, 152);
            dgvDetail.TabIndex = 36;
            dgvDetail.SelectionChanged += dgvDetail_SelectionChanged;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(18, 321);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(94, 29);
            btnDone.TabIndex = 37;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // frmMovieDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(btnDone);
            Controls.Add(dgvDetail);
            Controls.Add(btnFile);
            Controls.Add(txtFileImg);
            Controls.Add(picture);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtAge);
            Controls.Add(txtDirector);
            Controls.Add(label7);
            Controls.Add(txtMovieID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(txtYear);
            Controls.Add(Year);
            Controls.Add(txtMovieDetailID);
            Controls.Add(btnCreate);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmMovieDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMovieDetail";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox txtCountry;
        private Label label4;
        private TextBox txtYear;
        private Label Year;
        private Label txtMovieDetailID;
        private Button btnCreate;
        private TextBox txtID;
        private Label label1;
        private Label label7;
        private TextBox txtMovieID;
        private TextBox txtDirector;
        private TextBox txtAge;
        private TextBox txtDescription;
        private Label label2;
        private PictureBox picture;
        private TextBox txtFileImg;
        private Button btnFile;
        private DataGridView dgvDetail;
        private Button btnDone;
    }
}