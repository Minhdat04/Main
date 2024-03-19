namespace MovieTicketManagementWinApp
{
    partial class frmMovieBannerDetail
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
            movieName1 = new TextBox();
            movieLength = new TextBox();
            movieOpeningDay = new TextBox();
            movieReleaseYear = new TextBox();
            movieCountry = new TextBox();
            movieDirectorName = new TextBox();
            movieLimitAge = new TextBox();
            movieDescription = new TextBox();
            moviePicBox = new PictureBox();
            backMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)moviePicBox).BeginInit();
            SuspendLayout();
            // 
            // movieName1
            // 
            movieName1.Location = new Point(290, 26);
            movieName1.Name = "movieName1";
            movieName1.Size = new Size(301, 23);
            movieName1.TabIndex = 0;
            // 
            // movieLength
            // 
            movieLength.Location = new Point(290, 55);
            movieLength.Name = "movieLength";
            movieLength.Size = new Size(301, 23);
            movieLength.TabIndex = 1;
            // 
            // movieOpeningDay
            // 
            movieOpeningDay.Location = new Point(290, 84);
            movieOpeningDay.Name = "movieOpeningDay";
            movieOpeningDay.Size = new Size(301, 23);
            movieOpeningDay.TabIndex = 2;
            // 
            // movieReleaseYear
            // 
            movieReleaseYear.Location = new Point(290, 113);
            movieReleaseYear.Name = "movieReleaseYear";
            movieReleaseYear.Size = new Size(301, 23);
            movieReleaseYear.TabIndex = 3;
            // 
            // movieCountry
            // 
            movieCountry.Location = new Point(290, 142);
            movieCountry.Name = "movieCountry";
            movieCountry.Size = new Size(301, 23);
            movieCountry.TabIndex = 4;
            // 
            // movieDirectorName
            // 
            movieDirectorName.Location = new Point(290, 171);
            movieDirectorName.Name = "movieDirectorName";
            movieDirectorName.Size = new Size(301, 23);
            movieDirectorName.TabIndex = 5;
            // 
            // movieLimitAge
            // 
            movieLimitAge.Location = new Point(290, 200);
            movieLimitAge.Name = "movieLimitAge";
            movieLimitAge.Size = new Size(301, 23);
            movieLimitAge.TabIndex = 6;
            // 
            // movieDescription
            // 
            movieDescription.Location = new Point(290, 229);
            movieDescription.Name = "movieDescription";
            movieDescription.Size = new Size(301, 23);
            movieDescription.TabIndex = 7;
            // 
            // moviePicBox
            // 
            moviePicBox.Location = new Point(35, 26);
            moviePicBox.Name = "moviePicBox";
            moviePicBox.Size = new Size(249, 226);
            moviePicBox.TabIndex = 8;
            moviePicBox.TabStop = false;
            moviePicBox.Click += moviePicBox_Click;
            // 
            // backMenuButton
            // 
            backMenuButton.Location = new Point(261, 276);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(75, 23);
            backMenuButton.TabIndex = 9;
            backMenuButton.Text = "Back";
            backMenuButton.UseVisualStyleBackColor = true;
            backMenuButton.Click += backMenuButton_Click;
            // 
            // frmMovieBannerDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 331);
            Controls.Add(backMenuButton);
            Controls.Add(moviePicBox);
            Controls.Add(movieDescription);
            Controls.Add(movieLimitAge);
            Controls.Add(movieDirectorName);
            Controls.Add(movieCountry);
            Controls.Add(movieReleaseYear);
            Controls.Add(movieOpeningDay);
            Controls.Add(movieLength);
            Controls.Add(movieName1);
            Name = "frmMovieBannerDetail";
            Text = "frmMovieBannerDetail";
            ((System.ComponentModel.ISupportInitialize)moviePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox movieName1;
        private TextBox movieLength;
        private TextBox movieOpeningDay;
        private TextBox movieReleaseYear;
        private TextBox movieCountry;
        private TextBox movieDirectorName;
        private TextBox movieLimitAge;
        private TextBox movieDescription;
        private PictureBox moviePicBox;
        private Button backMenuButton;
    }
}