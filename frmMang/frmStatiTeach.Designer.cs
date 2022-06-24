namespace EduAdminSys.frmMang
{
    partial class frmStatiTeach
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radbutSchool = new System.Windows.Forms.RadioButton();
            this.radbutDepart = new System.Windows.Forms.RadioButton();
            this.radbutCourse = new System.Windows.Forms.RadioButton();
            this.comboxRange = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkboxSex = new System.Windows.Forms.CheckBox();
            this.chkboxAge = new System.Windows.Forms.CheckBox();
            this.comboxSex = new System.Windows.Forms.ComboBox();
            this.comboxAge = new System.Windows.Forms.ComboBox();
            this.butNumStati = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxSalary = new System.Windows.Forms.ComboBox();
            this.butSalary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师信息统计";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butNumStati);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(41, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人数统计";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxRange);
            this.groupBox2.Controls.Add(this.radbutCourse);
            this.groupBox2.Controls.Add(this.radbutDepart);
            this.groupBox2.Controls.Add(this.radbutSchool);
            this.groupBox2.Location = new System.Drawing.Point(31, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 310);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择统计范围";
            // 
            // radbutSchool
            // 
            this.radbutSchool.AutoSize = true;
            this.radbutSchool.Checked = true;
            this.radbutSchool.Location = new System.Drawing.Point(23, 56);
            this.radbutSchool.Name = "radbutSchool";
            this.radbutSchool.Size = new System.Drawing.Size(55, 24);
            this.radbutSchool.TabIndex = 0;
            this.radbutSchool.TabStop = true;
            this.radbutSchool.Text = "全校";
            this.radbutSchool.UseVisualStyleBackColor = true;
            this.radbutSchool.CheckedChanged += new System.EventHandler(this.RadbutSchool_CheckedChanged);
            // 
            // radbutDepart
            // 
            this.radbutDepart.AutoSize = true;
            this.radbutDepart.Location = new System.Drawing.Point(145, 56);
            this.radbutDepart.Name = "radbutDepart";
            this.radbutDepart.Size = new System.Drawing.Size(55, 24);
            this.radbutDepart.TabIndex = 1;
            this.radbutDepart.Text = "院系";
            this.radbutDepart.UseVisualStyleBackColor = true;
            this.radbutDepart.CheckedChanged += new System.EventHandler(this.RadbutDepart_CheckedChanged);
            // 
            // radbutCourse
            // 
            this.radbutCourse.AutoSize = true;
            this.radbutCourse.Location = new System.Drawing.Point(23, 102);
            this.radbutCourse.Name = "radbutCourse";
            this.radbutCourse.Size = new System.Drawing.Size(55, 24);
            this.radbutCourse.TabIndex = 2;
            this.radbutCourse.Text = "课程";
            this.radbutCourse.UseVisualStyleBackColor = true;
            this.radbutCourse.CheckedChanged += new System.EventHandler(this.RadbutCourse_CheckedChanged);
            // 
            // comboxRange
            // 
            this.comboxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxRange.FormattingEnabled = true;
            this.comboxRange.Location = new System.Drawing.Point(23, 157);
            this.comboxRange.Name = "comboxRange";
            this.comboxRange.Size = new System.Drawing.Size(177, 28);
            this.comboxRange.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboxAge);
            this.groupBox3.Controls.Add(this.comboxSex);
            this.groupBox3.Controls.Add(this.chkboxAge);
            this.groupBox3.Controls.Add(this.chkboxSex);
            this.groupBox3.Location = new System.Drawing.Point(298, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择性别和年龄段";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtboxSalary);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.butSalary);
            this.groupBox4.Controls.Add(this.comboxSalary);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(298, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 109);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "工资统计";
            // 
            // chkboxSex
            // 
            this.chkboxSex.AutoSize = true;
            this.chkboxSex.Location = new System.Drawing.Point(29, 26);
            this.chkboxSex.Name = "chkboxSex";
            this.chkboxSex.Size = new System.Drawing.Size(56, 24);
            this.chkboxSex.TabIndex = 0;
            this.chkboxSex.Text = "性别";
            this.chkboxSex.UseVisualStyleBackColor = true;
            // 
            // chkboxAge
            // 
            this.chkboxAge.AutoSize = true;
            this.chkboxAge.Location = new System.Drawing.Point(29, 91);
            this.chkboxAge.Name = "chkboxAge";
            this.chkboxAge.Size = new System.Drawing.Size(56, 24);
            this.chkboxAge.TabIndex = 1;
            this.chkboxAge.Text = "年龄";
            this.chkboxAge.UseVisualStyleBackColor = true;
            // 
            // comboxSex
            // 
            this.comboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex.FormattingEnabled = true;
            this.comboxSex.Location = new System.Drawing.Point(29, 56);
            this.comboxSex.Name = "comboxSex";
            this.comboxSex.Size = new System.Drawing.Size(121, 28);
            this.comboxSex.TabIndex = 2;
            // 
            // comboxAge
            // 
            this.comboxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAge.FormattingEnabled = true;
            this.comboxAge.Location = new System.Drawing.Point(29, 121);
            this.comboxAge.Name = "comboxAge";
            this.comboxAge.Size = new System.Drawing.Size(121, 28);
            this.comboxAge.TabIndex = 3;
            // 
            // butNumStati
            // 
            this.butNumStati.Location = new System.Drawing.Point(759, 163);
            this.butNumStati.Name = "butNumStati";
            this.butNumStati.Size = new System.Drawing.Size(75, 30);
            this.butNumStati.TabIndex = 2;
            this.butNumStati.Text = "统计";
            this.butNumStati.UseVisualStyleBackColor = true;
            this.butNumStati.Click += new System.EventHandler(this.ButNumStati_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "结果：";
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(594, 104);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.ReadOnly = true;
            this.txtboxNum.Size = new System.Drawing.Size(160, 26);
            this.txtboxNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "注意：不勾选任何选项代表全选";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(37, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "注意：请先选择统计范围再选择此方框的内容（选择“课程”选项无效）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "选择工资范围：";
            // 
            // comboxSalary
            // 
            this.comboxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSalary.FormattingEnabled = true;
            this.comboxSalary.Location = new System.Drawing.Point(47, 46);
            this.comboxSalary.Name = "comboxSalary";
            this.comboxSalary.Size = new System.Drawing.Size(157, 28);
            this.comboxSalary.TabIndex = 2;
            // 
            // butSalary
            // 
            this.butSalary.Location = new System.Drawing.Point(433, 46);
            this.butSalary.Name = "butSalary";
            this.butSalary.Size = new System.Drawing.Size(75, 35);
            this.butSalary.TabIndex = 3;
            this.butSalary.Text = "统计";
            this.butSalary.UseVisualStyleBackColor = true;
            this.butSalary.Click += new System.EventHandler(this.ButSalary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "结果：";
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.Location = new System.Drawing.Point(266, 47);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.ReadOnly = true;
            this.txtboxSalary.Size = new System.Drawing.Size(103, 26);
            this.txtboxSalary.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "人";
            // 
            // frmStatiTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmStatiTeach";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboxAge;
        private System.Windows.Forms.ComboBox comboxSex;
        private System.Windows.Forms.CheckBox chkboxAge;
        private System.Windows.Forms.CheckBox chkboxSex;
        private System.Windows.Forms.ComboBox comboxRange;
        private System.Windows.Forms.RadioButton radbutCourse;
        private System.Windows.Forms.RadioButton radbutDepart;
        private System.Windows.Forms.RadioButton radbutSchool;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butNumStati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butSalary;
        private System.Windows.Forms.ComboBox comboxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
