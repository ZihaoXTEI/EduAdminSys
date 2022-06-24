namespace EduAdminSys.frmTeach
{
    partial class frmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.担任课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登记成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusTeachno = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusTeachname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看消息ToolStripMenuItem,
            this.选择ToolStripMenuItem,
            this.登记成绩ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看消息ToolStripMenuItem
            // 
            this.查看消息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人资料ToolStripMenuItem,
            this.担任课程ToolStripMenuItem,
            this.学生信息ToolStripMenuItem});
            this.查看消息ToolStripMenuItem.Name = "查看消息ToolStripMenuItem";
            this.查看消息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查看消息ToolStripMenuItem.Text = "查看信息";
            // 
            // 个人资料ToolStripMenuItem
            // 
            this.个人资料ToolStripMenuItem.Name = "个人资料ToolStripMenuItem";
            this.个人资料ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.个人资料ToolStripMenuItem.Text = "个人资料";
            this.个人资料ToolStripMenuItem.Click += new System.EventHandler(this.个人资料ToolStripMenuItem_Click);
            // 
            // 担任课程ToolStripMenuItem
            // 
            this.担任课程ToolStripMenuItem.Name = "担任课程ToolStripMenuItem";
            this.担任课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.担任课程ToolStripMenuItem.Text = "担任课程";
            this.担任课程ToolStripMenuItem.Click += new System.EventHandler(this.担任课程ToolStripMenuItem_Click);
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选择ToolStripMenuItem.Text = "选择课程";
            this.选择ToolStripMenuItem.Click += new System.EventHandler(this.选择ToolStripMenuItem_Click);
            // 
            // 登记成绩ToolStripMenuItem
            // 
            this.登记成绩ToolStripMenuItem.Name = "登记成绩ToolStripMenuItem";
            this.登记成绩ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.登记成绩ToolStripMenuItem.Text = "登记成绩";
            this.登记成绩ToolStripMenuItem.Click += new System.EventHandler(this.登记成绩ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(3, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(930, 460);
            this.panel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStatusTeachno,
            this.toolStatusTeachname,
            this.toolStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "登陆用户信息：";
            // 
            // toolStatusTeachno
            // 
            this.toolStatusTeachno.Name = "toolStatusTeachno";
            this.toolStatusTeachno.Size = new System.Drawing.Size(48, 17);
            this.toolStatusTeachno.Text = "工号 ：";
            // 
            // toolStatusTeachname
            // 
            this.toolStatusTeachname.Name = "toolStatusTeachname";
            this.toolStatusTeachname.Size = new System.Drawing.Size(44, 17);
            this.toolStatusTeachname.Text = "姓名：";
            // 
            // toolStatusTime
            // 
            this.toolStatusTime.Name = "toolStatusTime";
            this.toolStatusTime.Size = new System.Drawing.Size(68, 17);
            this.toolStatusTime.Text = "登陆时间：";
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(934, 516);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTeacher";
            this.Text = "教务管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTeacher_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 担任课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登记成绩ToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusTeachno;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusTeachname;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusTime;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
    }
}