namespace EduAdminSys.frmTeach
{
    partial class frmTeachPersInfor
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labBirth = new System.Windows.Forms.Label();
            this.labSalary = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labDepart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxSex = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxDepart = new System.Windows.Forms.TextBox();
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.txtboxBirth = new System.Windows.Forms.TextBox();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(22, 72);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(51, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labID.Location = new System.Drawing.Point(22, 28);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(51, 20);
            this.labID.TabIndex = 1;
            this.labID.Text = "工号：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSex.Location = new System.Drawing.Point(322, 72);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(51, 20);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性别：";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAge.Location = new System.Drawing.Point(322, 28);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(51, 20);
            this.labAge.TabIndex = 3;
            this.labAge.Text = "年龄：";
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBirth.Location = new System.Drawing.Point(322, 116);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(79, 20);
            this.labBirth.TabIndex = 4;
            this.labBirth.Text = "出生日期：";
            // 
            // labSalary
            // 
            this.labSalary.AutoSize = true;
            this.labSalary.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSalary.Location = new System.Drawing.Point(590, 68);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(79, 20);
            this.labSalary.TabIndex = 5;
            this.labSalary.Text = "基本工资：";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(22, 116);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(51, 20);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "职称：";
            // 
            // labDepart
            // 
            this.labDepart.AutoSize = true;
            this.labDepart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDepart.Location = new System.Drawing.Point(590, 117);
            this.labDepart.Name = "labDepart";
            this.labDepart.Size = new System.Drawing.Size(79, 20);
            this.labDepart.TabIndex = 7;
            this.labDepart.Text = "所属院系：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxSex);
            this.groupBox1.Controls.Add(this.txtboxAge);
            this.groupBox1.Controls.Add(this.txtboxDepart);
            this.groupBox1.Controls.Add(this.txtboxSalary);
            this.groupBox1.Controls.Add(this.txtboxBirth);
            this.groupBox1.Controls.Add(this.txtboxTitle);
            this.groupBox1.Controls.Add(this.txtboxName);
            this.groupBox1.Controls.Add(this.txtboxId);
            this.groupBox1.Controls.Add(this.labBirth);
            this.groupBox1.Controls.Add(this.labDepart);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.labSalary);
            this.groupBox1.Controls.Add(this.labTitle);
            this.groupBox1.Controls.Add(this.labID);
            this.groupBox1.Controls.Add(this.labSex);
            this.groupBox1.Controls.Add(this.labAge);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // txtboxSex
            // 
            this.txtboxSex.Location = new System.Drawing.Point(402, 75);
            this.txtboxSex.Name = "txtboxSex";
            this.txtboxSex.ReadOnly = true;
            this.txtboxSex.Size = new System.Drawing.Size(78, 23);
            this.txtboxSex.TabIndex = 15;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(402, 29);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.ReadOnly = true;
            this.txtboxAge.Size = new System.Drawing.Size(78, 23);
            this.txtboxAge.TabIndex = 14;
            // 
            // txtboxDepart
            // 
            this.txtboxDepart.Location = new System.Drawing.Point(698, 117);
            this.txtboxDepart.Name = "txtboxDepart";
            this.txtboxDepart.ReadOnly = true;
            this.txtboxDepart.Size = new System.Drawing.Size(168, 23);
            this.txtboxDepart.TabIndex = 13;
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.Location = new System.Drawing.Point(698, 69);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.ReadOnly = true;
            this.txtboxSalary.Size = new System.Drawing.Size(168, 23);
            this.txtboxSalary.TabIndex = 12;
            // 
            // txtboxBirth
            // 
            this.txtboxBirth.Location = new System.Drawing.Point(402, 117);
            this.txtboxBirth.Name = "txtboxBirth";
            this.txtboxBirth.ReadOnly = true;
            this.txtboxBirth.Size = new System.Drawing.Size(168, 23);
            this.txtboxBirth.TabIndex = 11;
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(105, 115);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.ReadOnly = true;
            this.txtboxTitle.Size = new System.Drawing.Size(168, 23);
            this.txtboxTitle.TabIndex = 10;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(105, 75);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.ReadOnly = true;
            this.txtboxName.Size = new System.Drawing.Size(168, 23);
            this.txtboxName.TabIndex = 9;
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(105, 28);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.ReadOnly = true;
            this.txtboxId.Size = new System.Drawing.Size(168, 23);
            this.txtboxId.TabIndex = 8;
            // 
            // frmTeachPersInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeachPersInfor";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labSalary;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labDepart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxSex;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxDepart;
        private System.Windows.Forms.TextBox txtboxSalary;
        private System.Windows.Forms.TextBox txtboxBirth;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxId;
    }
}
