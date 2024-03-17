namespace MovieTicketManagementWinApp
{
    partial class frmManageCategory
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
            dgvCategory = new DataGridView();
            label1 = new Label();
            btnCreate = new Button();
            label2 = new Label();
            txtNewID = new TextBox();
            txtNewName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            btnUpdate = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(328, 58);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new Size(300, 252);
            dgvCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "New category";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(57, 124);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 35);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "Load Category";
            // 
            // txtNewID
            // 
            txtNewID.Location = new Point(57, 58);
            txtNewID.Name = "txtNewID";
            txtNewID.ReadOnly = true;
            txtNewID.Size = new Size(213, 27);
            txtNewID.TabIndex = 4;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(57, 91);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(213, 27);
            txtNewName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 94);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 251);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(57, 215);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(213, 27);
            textBox4.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 192);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 12;
            label7.Text = "Update category";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(57, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(119, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmManageCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 360);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNewName);
            Controls.Add(txtNewID);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(dgvCategory);
            Name = "frmManageCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmManageCategory";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private Label label1;
        private Button btnCreate;
        private Label label2;
        private TextBox txtNewID;
        private TextBox txtNewName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Button btnUpdate;
        private Button btnBack;
    }
}