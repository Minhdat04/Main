namespace MovieTicketManagementWinApp
{
    partial class frmScheduleDetail
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
            label1 = new Label();
            txtID = new TextBox();
            cmbRoom = new ComboBox();
            cmbMovie = new ComboBox();
            cmbSchedule = new ComboBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvDetail = new DataGridView();
            btnCreate = new Button();
            btnView = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(132, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(132, 62);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(151, 28);
            cmbRoom.TabIndex = 2;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            cmbRoom.TextChanged += cmbRoom_TextChanged;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(132, 133);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(151, 28);
            cmbMovie.TabIndex = 3;
            // 
            // cmbSchedule
            // 
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Location = new Point(132, 99);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(151, 28);
            cmbSchedule.TabIndex = 4;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(132, 167);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 5;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 62);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Date";
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(401, 22);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.RowTemplate.Height = 29;
            dgvDetail.Size = new Size(387, 209);
            dgvDetail.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(132, 202);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(288, 202);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 12;
            btnView.Text = "View all";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 202);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmScheduleDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnView);
            Controls.Add(btnCreate);
            Controls.Add(dgvDetail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(cmbSchedule);
            Controls.Add(cmbMovie);
            Controls.Add(cmbRoom);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmScheduleDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScheduleDetail";
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private ComboBox cmbRoom;
        private ComboBox cmbMovie;
        private ComboBox cmbSchedule;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvDetail;
        private Button btnCreate;
        private Button btnView;
        private Button btnClose;
    }
}