namespace EduAdminSys
{
    partial class frmPasswordSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordSet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxOldPSW = new System.Windows.Forms.TextBox();
            this.txtboxNewPSW = new System.Windows.Forms.TextBox();
            this.txtboxCheckPSW = new System.Windows.Forms.TextBox();
            this.butEnter = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(69, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次输入确认：";
            // 
            // txtboxOldPSW
            // 
            this.txtboxOldPSW.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxOldPSW.Location = new System.Drawing.Point(91, 61);
            this.txtboxOldPSW.Name = "txtboxOldPSW";
            this.txtboxOldPSW.Size = new System.Drawing.Size(210, 29);
            this.txtboxOldPSW.TabIndex = 3;
            this.txtboxOldPSW.UseSystemPasswordChar = true;
            // 
            // txtboxNewPSW
            // 
            this.txtboxNewPSW.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxNewPSW.Location = new System.Drawing.Point(91, 129);
            this.txtboxNewPSW.Name = "txtboxNewPSW";
            this.txtboxNewPSW.Size = new System.Drawing.Size(210, 29);
            this.txtboxNewPSW.TabIndex = 4;
            this.txtboxNewPSW.UseSystemPasswordChar = true;
            // 
            // txtboxCheckPSW
            // 
            this.txtboxCheckPSW.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxCheckPSW.Location = new System.Drawing.Point(91, 202);
            this.txtboxCheckPSW.Name = "txtboxCheckPSW";
            this.txtboxCheckPSW.Size = new System.Drawing.Size(210, 29);
            this.txtboxCheckPSW.TabIndex = 5;
            this.txtboxCheckPSW.UseSystemPasswordChar = true;
            // 
            // butEnter
            // 
            this.butEnter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter.Location = new System.Drawing.Point(73, 273);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(75, 30);
            this.butEnter.TabIndex = 6;
            this.butEnter.Text = "确认";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.ButEnter_Click);
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancel.Location = new System.Drawing.Point(236, 273);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 30);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(101, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码只能包含数字和英文字母大小写";
            // 
            // frmPasswordSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(392, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.txtboxCheckPSW);
            this.Controls.Add(this.txtboxNewPSW);
            this.Controls.Add(this.txtboxOldPSW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasswordSet";
            this.Text = "密码设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPasswordSet_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxOldPSW;
        private System.Windows.Forms.TextBox txtboxNewPSW;
        private System.Windows.Forms.TextBox txtboxCheckPSW;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label4;
    }
}