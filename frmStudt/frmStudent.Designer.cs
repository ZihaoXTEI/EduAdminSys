namespace EduAdminSys.frmStudt
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已选修课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选修课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选修课程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.未进入课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusMess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusStuno = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusStuname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem,
            this.选修课程ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.已选修课程ToolStripMenuItem,
            this.考试成绩ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 已选修课程ToolStripMenuItem
            // 
            this.已选修课程ToolStripMenuItem.Name = "已选修课程ToolStripMenuItem";
            this.已选修课程ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.已选修课程ToolStripMenuItem.Text = "已选修课程";
            this.已选修课程ToolStripMenuItem.Click += new System.EventHandler(this.已选修课程ToolStripMenuItem_Click);
            // 
            // 考试成绩ToolStripMenuItem
            // 
            this.考试成绩ToolStripMenuItem.Name = "考试成绩ToolStripMenuItem";
            this.考试成绩ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.考试成绩ToolStripMenuItem.Text = "考试成绩";
            this.考试成绩ToolStripMenuItem.Click += new System.EventHandler(this.考试成绩ToolStripMenuItem_Click);
            // 
            // 选修课程ToolStripMenuItem
            // 
            this.选修课程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选修课程ToolStripMenuItem1,
            this.未进入课程ToolStripMenuItem});
            this.选修课程ToolStripMenuItem.Name = "选修课程ToolStripMenuItem";
            this.选修课程ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选修课程ToolStripMenuItem.Text = "选修课程";
            // 
            // 选修课程ToolStripMenuItem1
            // 
            this.选修课程ToolStripMenuItem1.Name = "选修课程ToolStripMenuItem1";
            this.选修课程ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.选修课程ToolStripMenuItem1.Text = "选修课程";
            this.选修课程ToolStripMenuItem1.Click += new System.EventHandler(this.选修课程ToolStripMenuItem1_Click);
            // 
            // 未进入课程ToolStripMenuItem
            // 
            this.未进入课程ToolStripMenuItem.Name = "未进入课程ToolStripMenuItem";
            this.未进入课程ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.未进入课程ToolStripMenuItem.Text = "未入选课程";
            this.未进入课程ToolStripMenuItem.Click += new System.EventHandler(this.未进入课程ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出程序ToolStripMenuItem1});
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
            // 退出程序ToolStripMenuItem1
            // 
            this.退出程序ToolStripMenuItem1.Name = "退出程序ToolStripMenuItem1";
            this.退出程序ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem1.Text = "退出程序";
            this.退出程序ToolStripMenuItem1.Click += new System.EventHandler(this.退出程序ToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusMess,
            this.toolStatusStuno,
            this.toolStatusStuname,
            this.toolStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusMess
            // 
            this.toolStatusMess.Name = "toolStatusMess";
            this.toolStatusMess.Size = new System.Drawing.Size(92, 17);
            this.toolStatusMess.Text = "登陆用户信息：";
            // 
            // toolStatusStuno
            // 
            this.toolStatusStuno.Name = "toolStatusStuno";
            this.toolStatusStuno.Size = new System.Drawing.Size(44, 17);
            this.toolStatusStuno.Text = "学号：";
            // 
            // toolStatusStuname
            // 
            this.toolStatusStuname.Name = "toolStatusStuname";
            this.toolStatusStuname.Size = new System.Drawing.Size(44, 17);
            this.toolStatusStuname.Text = "姓名：";
            // 
            // toolStatusTime
            // 
            this.toolStatusTime.Name = "toolStatusTime";
            this.toolStatusTime.Size = new System.Drawing.Size(68, 17);
            this.toolStatusTime.Text = "登陆时间：";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(930, 460);
            this.panel.TabIndex = 2;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(934, 516);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudent";
            this.Text = "教务管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudent_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选修课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已选修课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusMess;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusStuno;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem 选修课程ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 未进入课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusStuname;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusTime;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem1;
    }
}