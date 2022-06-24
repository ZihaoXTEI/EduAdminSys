namespace EduAdminSys.frmMang
{
    partial class frmStatiStud
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
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.labResult = new System.Windows.Forms.Label();
            this.butEnter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboxYear = new System.Windows.Forms.ComboBox();
            this.chkboxYear = new System.Windows.Forms.CheckBox();
            this.comboxAge = new System.Windows.Forms.ComboBox();
            this.comboxSex = new System.Windows.Forms.ComboBox();
            this.labMessage1 = new System.Windows.Forms.Label();
            this.chkboxSex = new System.Windows.Forms.CheckBox();
            this.chkboxAge = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboxRange = new System.Windows.Forms.ComboBox();
            this.radbutClass = new System.Windows.Forms.RadioButton();
            this.radbutCourse = new System.Windows.Forms.RadioButton();
            this.radbutDepart = new System.Windows.Forms.RadioButton();
            this.radbutSchol = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息统计";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxNum);
            this.groupBox1.Controls.Add(this.labResult);
            this.groupBox1.Controls.Add(this.butEnter);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(41, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人数统计";
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(649, 112);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.ReadOnly = true;
            this.txtboxNum.Size = new System.Drawing.Size(160, 26);
            this.txtboxNum.TabIndex = 8;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labResult.Location = new System.Drawing.Point(592, 115);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(51, 20);
            this.labResult.TabIndex = 7;
            this.labResult.Text = "结果：";
            // 
            // butEnter
            // 
            this.butEnter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter.Location = new System.Drawing.Point(734, 194);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(75, 30);
            this.butEnter.TabIndex = 6;
            this.butEnter.Text = "统计";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.ButEnter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboxYear);
            this.groupBox3.Controls.Add(this.chkboxYear);
            this.groupBox3.Controls.Add(this.comboxAge);
            this.groupBox3.Controls.Add(this.comboxSex);
            this.groupBox3.Controls.Add(this.labMessage1);
            this.groupBox3.Controls.Add(this.chkboxSex);
            this.groupBox3.Controls.Add(this.chkboxAge);
            this.groupBox3.Location = new System.Drawing.Point(312, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 245);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择性别和年龄的范围";
            // 
            // comboxYear
            // 
            this.comboxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxYear.FormattingEnabled = true;
            this.comboxYear.Location = new System.Drawing.Point(43, 171);
            this.comboxYear.Name = "comboxYear";
            this.comboxYear.Size = new System.Drawing.Size(121, 28);
            this.comboxYear.TabIndex = 7;
            // 
            // chkboxYear
            // 
            this.chkboxYear.AutoSize = true;
            this.chkboxYear.Location = new System.Drawing.Point(43, 143);
            this.chkboxYear.Name = "chkboxYear";
            this.chkboxYear.Size = new System.Drawing.Size(84, 24);
            this.chkboxYear.TabIndex = 6;
            this.chkboxYear.Text = "入学年份";
            this.chkboxYear.UseVisualStyleBackColor = true;
            // 
            // comboxAge
            // 
            this.comboxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAge.FormattingEnabled = true;
            this.comboxAge.Location = new System.Drawing.Point(43, 111);
            this.comboxAge.Name = "comboxAge";
            this.comboxAge.Size = new System.Drawing.Size(121, 28);
            this.comboxAge.TabIndex = 5;
            // 
            // comboxSex
            // 
            this.comboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex.FormattingEnabled = true;
            this.comboxSex.Location = new System.Drawing.Point(43, 51);
            this.comboxSex.Name = "comboxSex";
            this.comboxSex.Size = new System.Drawing.Size(121, 28);
            this.comboxSex.TabIndex = 4;
            // 
            // labMessage1
            // 
            this.labMessage1.AutoSize = true;
            this.labMessage1.ForeColor = System.Drawing.Color.Red;
            this.labMessage1.Location = new System.Drawing.Point(26, 222);
            this.labMessage1.Name = "labMessage1";
            this.labMessage1.Size = new System.Drawing.Size(205, 20);
            this.labMessage1.TabIndex = 3;
            this.labMessage1.Text = "注意：不勾选任何选项代表全选";
            // 
            // chkboxSex
            // 
            this.chkboxSex.AutoSize = true;
            this.chkboxSex.Location = new System.Drawing.Point(43, 23);
            this.chkboxSex.Name = "chkboxSex";
            this.chkboxSex.Size = new System.Drawing.Size(84, 24);
            this.chkboxSex.TabIndex = 2;
            this.chkboxSex.Text = "学生性别";
            this.chkboxSex.UseVisualStyleBackColor = true;
            // 
            // chkboxAge
            // 
            this.chkboxAge.AutoSize = true;
            this.chkboxAge.Location = new System.Drawing.Point(43, 83);
            this.chkboxAge.Name = "chkboxAge";
            this.chkboxAge.Size = new System.Drawing.Size(84, 24);
            this.chkboxAge.TabIndex = 1;
            this.chkboxAge.Text = "学生年龄";
            this.chkboxAge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxRange);
            this.groupBox2.Controls.Add(this.radbutClass);
            this.groupBox2.Controls.Add(this.radbutCourse);
            this.groupBox2.Controls.Add(this.radbutDepart);
            this.groupBox2.Controls.Add(this.radbutSchol);
            this.groupBox2.Location = new System.Drawing.Point(30, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择统计范围";
            // 
            // comboxRange
            // 
            this.comboxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxRange.FormattingEnabled = true;
            this.comboxRange.Location = new System.Drawing.Point(33, 147);
            this.comboxRange.Name = "comboxRange";
            this.comboxRange.Size = new System.Drawing.Size(188, 28);
            this.comboxRange.TabIndex = 4;
            // 
            // radbutClass
            // 
            this.radbutClass.AutoSize = true;
            this.radbutClass.Location = new System.Drawing.Point(148, 89);
            this.radbutClass.Name = "radbutClass";
            this.radbutClass.Size = new System.Drawing.Size(55, 24);
            this.radbutClass.TabIndex = 3;
            this.radbutClass.TabStop = true;
            this.radbutClass.Text = "班级";
            this.radbutClass.UseVisualStyleBackColor = true;
            this.radbutClass.CheckedChanged += new System.EventHandler(this.RadbutClass_CheckedChanged);
            // 
            // radbutCourse
            // 
            this.radbutCourse.AutoSize = true;
            this.radbutCourse.Location = new System.Drawing.Point(33, 89);
            this.radbutCourse.Name = "radbutCourse";
            this.radbutCourse.Size = new System.Drawing.Size(55, 24);
            this.radbutCourse.TabIndex = 2;
            this.radbutCourse.TabStop = true;
            this.radbutCourse.Text = "课程";
            this.radbutCourse.UseVisualStyleBackColor = true;
            this.radbutCourse.CheckedChanged += new System.EventHandler(this.RadbutCourse_CheckedChanged);
            // 
            // radbutDepart
            // 
            this.radbutDepart.AutoSize = true;
            this.radbutDepart.Location = new System.Drawing.Point(148, 39);
            this.radbutDepart.Name = "radbutDepart";
            this.radbutDepart.Size = new System.Drawing.Size(55, 24);
            this.radbutDepart.TabIndex = 1;
            this.radbutDepart.TabStop = true;
            this.radbutDepart.Text = "院系";
            this.radbutDepart.UseVisualStyleBackColor = true;
            this.radbutDepart.CheckedChanged += new System.EventHandler(this.RadbutDepart_CheckedChanged);
            // 
            // radbutSchol
            // 
            this.radbutSchol.AutoSize = true;
            this.radbutSchol.Checked = true;
            this.radbutSchol.Location = new System.Drawing.Point(33, 40);
            this.radbutSchol.Name = "radbutSchol";
            this.radbutSchol.Size = new System.Drawing.Size(55, 24);
            this.radbutSchol.TabIndex = 0;
            this.radbutSchol.TabStop = true;
            this.radbutSchol.Text = "全校";
            this.radbutSchol.UseVisualStyleBackColor = true;
            this.radbutSchol.CheckedChanged += new System.EventHandler(this.RadbutSchol_CheckedChanged);
            // 
            // frmStatiStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStatiStud";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxSex;
        private System.Windows.Forms.CheckBox chkboxAge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboxRange;
        private System.Windows.Forms.RadioButton radbutClass;
        private System.Windows.Forms.RadioButton radbutCourse;
        private System.Windows.Forms.RadioButton radbutDepart;
        private System.Windows.Forms.RadioButton radbutSchol;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Label labMessage1;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.ComboBox comboxYear;
        private System.Windows.Forms.CheckBox chkboxYear;
        private System.Windows.Forms.ComboBox comboxAge;
        private System.Windows.Forms.ComboBox comboxSex;
    }
}
