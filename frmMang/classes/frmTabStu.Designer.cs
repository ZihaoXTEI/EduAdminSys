namespace EduAdminSys.frmMang.classes
{
    partial class frmTabStu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxDepartName = new System.Windows.Forms.TextBox();
            this.txtboxStuNo = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpate = new System.Windows.Forms.Button();
            this.comboxSex1 = new System.Windows.Forms.ComboBox();
            this.txtboxName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpInput = new System.Windows.Forms.DateTimePicker();
            this.butInsert = new System.Windows.Forms.Button();
            this.txtboxNo = new System.Windows.Forms.TextBox();
            this.comboxSex2 = new System.Windows.Forms.ComboBox();
            this.txtboxName2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboxDepart = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butAddOne = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxDepartName);
            this.groupBox1.Controls.Add(this.txtboxStuNo);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.butUpate);
            this.groupBox1.Controls.Add(this.comboxSex1);
            this.groupBox1.Controls.Add(this.txtboxName1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.butFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改";
            // 
            // txtboxDepartName
            // 
            this.txtboxDepartName.Location = new System.Drawing.Point(69, 27);
            this.txtboxDepartName.Name = "txtboxDepartName";
            this.txtboxDepartName.ReadOnly = true;
            this.txtboxDepartName.Size = new System.Drawing.Size(135, 23);
            this.txtboxDepartName.TabIndex = 15;
            // 
            // txtboxStuNo
            // 
            this.txtboxStuNo.Location = new System.Drawing.Point(270, 26);
            this.txtboxStuNo.MaxLength = 50;
            this.txtboxStuNo.Name = "txtboxStuNo";
            this.txtboxStuNo.Size = new System.Drawing.Size(131, 23);
            this.txtboxStuNo.TabIndex = 14;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "yyyy-MM-dd";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(93, 115);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(168, 23);
            this.dtp.TabIndex = 13;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(424, 113);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 30);
            this.butDelete.TabIndex = 12;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // butUpate
            // 
            this.butUpate.Location = new System.Drawing.Point(424, 66);
            this.butUpate.Name = "butUpate";
            this.butUpate.Size = new System.Drawing.Size(75, 30);
            this.butUpate.TabIndex = 11;
            this.butUpate.Text = "修改";
            this.butUpate.UseVisualStyleBackColor = true;
            this.butUpate.Click += new System.EventHandler(this.ButUpate_Click);
            // 
            // comboxSex1
            // 
            this.comboxSex1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex1.FormattingEnabled = true;
            this.comboxSex1.Location = new System.Drawing.Point(270, 73);
            this.comboxSex1.Name = "comboxSex1";
            this.comboxSex1.Size = new System.Drawing.Size(81, 25);
            this.comboxSex1.TabIndex = 8;
            // 
            // txtboxName1
            // 
            this.txtboxName1.Location = new System.Drawing.Point(71, 73);
            this.txtboxName1.Name = "txtboxName1";
            this.txtboxName1.Size = new System.Drawing.Size(133, 23);
            this.txtboxName1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "出生日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(424, 23);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 30);
            this.butFind.TabIndex = 3;
            this.butFind.Text = "查找";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.ButFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "院系：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpInput);
            this.groupBox2.Controls.Add(this.butInsert);
            this.groupBox2.Controls.Add(this.txtboxNo);
            this.groupBox2.Controls.Add(this.comboxSex2);
            this.groupBox2.Controls.Add(this.txtboxName2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboxDepart);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "增加";
            // 
            // dtpInput
            // 
            this.dtpInput.CustomFormat = "yyyy-MM-dd";
            this.dtpInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput.Location = new System.Drawing.Point(294, 86);
            this.dtpInput.Name = "dtpInput";
            this.dtpInput.Size = new System.Drawing.Size(169, 23);
            this.dtpInput.TabIndex = 19;
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(424, 133);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(75, 30);
            this.butInsert.TabIndex = 18;
            this.butInsert.Text = "确定";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.ButInsert_Click);
            // 
            // txtboxNo
            // 
            this.txtboxNo.Location = new System.Drawing.Point(294, 37);
            this.txtboxNo.Name = "txtboxNo";
            this.txtboxNo.ReadOnly = true;
            this.txtboxNo.Size = new System.Drawing.Size(126, 23);
            this.txtboxNo.TabIndex = 16;
            // 
            // comboxSex2
            // 
            this.comboxSex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex2.FormattingEnabled = true;
            this.comboxSex2.Location = new System.Drawing.Point(69, 129);
            this.comboxSex2.Name = "comboxSex2";
            this.comboxSex2.Size = new System.Drawing.Size(83, 25);
            this.comboxSex2.TabIndex = 15;
            // 
            // txtboxName2
            // 
            this.txtboxName2.Location = new System.Drawing.Point(69, 83);
            this.txtboxName2.Name = "txtboxName2";
            this.txtboxName2.Size = new System.Drawing.Size(135, 23);
            this.txtboxName2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "性别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "出生日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "姓名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "学号：";
            // 
            // comboxDepart
            // 
            this.comboxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepart.FormattingEnabled = true;
            this.comboxDepart.Location = new System.Drawing.Point(69, 37);
            this.comboxDepart.Name = "comboxDepart";
            this.comboxDepart.Size = new System.Drawing.Size(135, 25);
            this.comboxDepart.TabIndex = 8;
            this.comboxDepart.SelectedIndexChanged += new System.EventHandler(this.ComboxDepart_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "院系：";
            // 
            // butAddOne
            // 
            this.butAddOne.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butAddOne.Location = new System.Drawing.Point(113, 416);
            this.butAddOne.Name = "butAddOne";
            this.butAddOne.Size = new System.Drawing.Size(153, 30);
            this.butAddOne.TabIndex = 10;
            this.butAddOne.Text = "所有学生年龄加一";
            this.butAddOne.UseVisualStyleBackColor = true;
            this.butAddOne.Click += new System.EventHandler(this.ButAddOne_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(42, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "批量操作";
            // 
            // frmTabStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butAddOne);
            this.Name = "frmTabStu";
            this.Size = new System.Drawing.Size(560, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpate;
        private System.Windows.Forms.ComboBox comboxSex1;
        private System.Windows.Forms.TextBox txtboxName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.TextBox txtboxNo;
        private System.Windows.Forms.ComboBox comboxSex2;
        private System.Windows.Forms.TextBox txtboxName2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboxDepart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butAddOne;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtboxStuNo;
        private System.Windows.Forms.TextBox txtboxDepartName;
        private System.Windows.Forms.DateTimePicker dtpInput;
    }
}
