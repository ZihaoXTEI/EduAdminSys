namespace EduAdminSys
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.enterButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.TeacherRadBut = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagerRadBut = new System.Windows.Forms.RadioButton();
            this.StudentRadBut = new System.Windows.Forms.RadioButton();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.pswLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.pswTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enterButton.Location = new System.Drawing.Point(42, 217);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 36);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "确认";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButton.Location = new System.Drawing.Point(173, 217);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 36);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TeacherRadBut
            // 
            this.TeacherRadBut.AutoSize = true;
            this.TeacherRadBut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TeacherRadBut.Location = new System.Drawing.Point(11, 5);
            this.TeacherRadBut.Name = "TeacherRadBut";
            this.TeacherRadBut.Size = new System.Drawing.Size(50, 21);
            this.TeacherRadBut.TabIndex = 2;
            this.TeacherRadBut.TabStop = true;
            this.TeacherRadBut.Text = "教师";
            this.TeacherRadBut.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ManagerRadBut);
            this.panel1.Controls.Add(this.StudentRadBut);
            this.panel1.Controls.Add(this.TeacherRadBut);
            this.panel1.Location = new System.Drawing.Point(42, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 36);
            this.panel1.TabIndex = 3;
            // 
            // ManagerRadBut
            // 
            this.ManagerRadBut.AutoSize = true;
            this.ManagerRadBut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerRadBut.Location = new System.Drawing.Point(145, 5);
            this.ManagerRadBut.Name = "ManagerRadBut";
            this.ManagerRadBut.Size = new System.Drawing.Size(62, 21);
            this.ManagerRadBut.TabIndex = 3;
            this.ManagerRadBut.TabStop = true;
            this.ManagerRadBut.Text = "管理员";
            this.ManagerRadBut.UseVisualStyleBackColor = true;
            // 
            // StudentRadBut
            // 
            this.StudentRadBut.AutoSize = true;
            this.StudentRadBut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentRadBut.Location = new System.Drawing.Point(78, 5);
            this.StudentRadBut.Name = "StudentRadBut";
            this.StudentRadBut.Size = new System.Drawing.Size(50, 21);
            this.StudentRadBut.TabIndex = 0;
            this.StudentRadBut.TabStop = true;
            this.StudentRadBut.Text = "学生";
            this.StudentRadBut.UseVisualStyleBackColor = true;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIdLabel.Location = new System.Drawing.Point(38, 102);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(51, 20);
            this.userIdLabel.TabIndex = 4;
            this.userIdLabel.Text = "用户名";
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswLabel.Location = new System.Drawing.Point(38, 135);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(49, 20);
            this.pswLabel.TabIndex = 5;
            this.pswLabel.Text = "密   码";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIdTextBox.Location = new System.Drawing.Point(106, 102);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(142, 23);
            this.userIdTextBox.TabIndex = 6;
            // 
            // pswTextBox
            // 
            this.pswTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswTextBox.Location = new System.Drawing.Point(106, 135);
            this.pswTextBox.Name = "pswTextBox";
            this.pswTextBox.Size = new System.Drawing.Size(142, 23);
            this.pswTextBox.TabIndex = 7;
            this.pswTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EduAdminSys.Properties.Resources.LoginImg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 77);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(290, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pswTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton TeacherRadBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox pswTextBox;
        private System.Windows.Forms.RadioButton ManagerRadBut;
        private System.Windows.Forms.RadioButton StudentRadBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

