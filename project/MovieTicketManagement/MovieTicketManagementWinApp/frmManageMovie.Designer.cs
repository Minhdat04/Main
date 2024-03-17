namespace MovieTicketManagementWinApp
{
    partial class frmManageMovie
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
            btnCreate = new Button();
            dgvMovie = new DataGridView();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtLength = new TextBox();
            dtpOpeningdate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Create new movie";
            // 
            // txtID
            // 
            txtID.Location = new Point(87, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(98, 27);
            txtID.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(87, 211);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvMovie
            // 
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(359, 39);
            dgvMovie.Name = "dgvMovie";
            dgvMovie.RowHeadersWidth = 51;
            dgvMovie.RowTemplate.Height = 29;
            dgvMovie.Size = new Size(381, 201);
            dgvMovie.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(87, 177);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Length";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(87, 105);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(98, 27);
            txtLength.TabIndex = 10;
            // 
            // dtpOpeningdate
            // 
            dtpOpeningdate.Location = new Point(87, 144);
            dtpOpeningdate.Name = "dtpOpeningdate";
            dtpOpeningdate.Size = new Size(244, 27);
            dtpOpeningdate.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 149);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 12;
            label5.Text = "Open";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Category";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(359, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmManageMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 329);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpOpeningdate);
            Controls.Add(txtLength);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(dgvMovie);
            Controls.Add(btnCreate);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmManageMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageMovie";
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Button btnCreate;
        private DataGridView dgvMovie;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtLength;
        private DateTimePicker dtpOpeningdate;
        private Label label5;
        private Label label6;
        private Button btnUpdate;
    }
}