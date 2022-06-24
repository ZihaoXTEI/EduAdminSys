namespace EduAdminSys.frmMang.classes
{
    partial class frmMangTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMangTable));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生表ToolStripMenuItem,
            this.教师表ToolStripMenuItem,
            this.课程表ToolStripMenuItem,
            this.登录表ToolStripMenuItem,
            this.退出界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "学生表";
            // 
            // 学生表ToolStripMenuItem
            // 
            this.学生表ToolStripMenuItem.Name = "学生表ToolStripMenuItem";
            this.学生表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.学生表ToolStripMenuItem.Text = "学生表";
            this.学生表ToolStripMenuItem.Click += new System.EventHandler(this.学生表ToolStripMenuItem_Click);
            // 
            // 教师表ToolStripMenuItem
            // 
            this.教师表ToolStripMenuItem.Name = "教师表ToolStripMenuItem";
            this.教师表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.教师表ToolStripMenuItem.Text = "教师表";
            this.教师表ToolStripMenuItem.Click += new System.EventHandler(this.教师表ToolStripMenuItem_Click);
            // 
            // 课程表ToolStripMenuItem
            // 
            this.课程表ToolStripMenuItem.Name = "课程表ToolStripMenuItem";
            this.课程表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.课程表ToolStripMenuItem.Text = "课程表";
            this.课程表ToolStripMenuItem.Click += new System.EventHandler(this.课程表ToolStripMenuItem_Click);
            // 
            // 登录表ToolStripMenuItem
            // 
            this.登录表ToolStripMenuItem.Name = "登录表ToolStripMenuItem";
            this.登录表ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.登录表ToolStripMenuItem.Text = "登录表";
            this.登录表ToolStripMenuItem.Click += new System.EventHandler(this.登录表ToolStripMenuItem_Click);
            // 
            // 退出界面ToolStripMenuItem
            // 
            this.退出界面ToolStripMenuItem.Name = "退出界面ToolStripMenuItem";
            this.退出界面ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出界面ToolStripMenuItem.Text = "退出界面";
            this.退出界面ToolStripMenuItem.Click += new System.EventHandler(this.退出界面ToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(560, 480);
            this.panel.TabIndex = 1;
            // 
            // frmMangTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 511);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMangTable";
            this.Text = "信息表的高级功能";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录表ToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem 退出界面ToolStripMenuItem;
    }
}