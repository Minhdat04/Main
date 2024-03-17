namespace MovieTicketManagementWinApp
{
    partial class frmEmployeePage
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
            btnRoom = new Button();
            btnCategory = new Button();
            btnSchedule = new Button();
            btnManageMovie = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(50, 101);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(143, 29);
            btnRoom.TabIndex = 8;
            btnRoom.Text = "Manage Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(50, 66);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(143, 29);
            btnCategory.TabIndex = 7;
            btnCategory.Text = "Manage Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(50, 136);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(143, 29);
            btnSchedule.TabIndex = 6;
            btnSchedule.Text = "Manage Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnManageMovie
            // 
            btnManageMovie.Location = new Point(50, 31);
            btnManageMovie.Name = "btnManageMovie";
            btnManageMovie.Size = new Size(143, 29);
            btnManageMovie.TabIndex = 5;
            btnManageMovie.Text = "Manage Movie";
            btnManageMovie.UseVisualStyleBackColor = true;
            btnManageMovie.Click += btnManageMovie_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 171);
            button1.Name = "button1";
            button1.Size = new Size(229, 29);
            button1.TabIndex = 9;
            button1.Text = "Manage Schedule Detail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEmployeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 246);
            Controls.Add(button1);
            Controls.Add(btnRoom);
            Controls.Add(btnCategory);
            Controls.Add(btnSchedule);
            Controls.Add(btnManageMovie);
            Name = "frmEmployeePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmployeePage";
            Load += frmEmployeePage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRoom;
        private Button btnCategory;
        private Button btnSchedule;
        private Button btnManageMovie;
        private Button button1;
    }
}