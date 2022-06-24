namespace EduAdminSys.frmMang
{
    partial class frmStatiMark
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxReuslt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxMax = new System.Windows.Forms.TextBox();
            this.butEnter = new System.Windows.Forms.Button();
            this.txtboxMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butFail = new System.Windows.Forms.Button();
            this.butPass = new System.Windows.Forms.Button();
            this.butGood = new System.Windows.Forms.Button();
            this.butExcellent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxSex = new System.Windows.Forms.ComboBox();
            this.chkboxSex = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboxRange = new System.Windows.Forms.ComboBox();
            this.radbutClass = new System.Windows.Forms.RadioButton();
            this.radbutCourse = new System.Windows.Forms.RadioButton();
            this.radbutDepart = new System.Windows.Forms.RadioButton();
            this.radbutSchool = new System.Windows.Forms.RadioButton();
            this.chkboxBukao = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "成绩信息统计";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(25, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人数统计";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkboxBukao);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtboxReuslt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtboxMax);
            this.groupBox3.Controls.Add(this.butEnter);
            this.groupBox3.Controls.Add(this.txtboxMin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.butFail);
            this.groupBox3.Controls.Add(this.butPass);
            this.groupBox3.Controls.Add(this.butGood);
            this.groupBox3.Controls.Add(this.butExcellent);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboxSex);
            this.groupBox3.Controls.Add(this.chkboxSex);
            this.groupBox3.Location = new System.Drawing.Point(256, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 217);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择性别和分数等级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "人";
            // 
            // txtboxReuslt
            // 
            this.txtboxReuslt.Location = new System.Drawing.Point(378, 148);
            this.txtboxReuslt.Name = "txtboxReuslt";
            this.txtboxReuslt.ReadOnly = true;
            this.txtboxReuslt.Size = new System.Drawing.Size(100, 26);
            this.txtboxReuslt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "结果：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "~";
            // 
            // txtboxMax
            // 
            this.txtboxMax.Location = new System.Drawing.Point(451, 64);
            this.txtboxMax.Name = "txtboxMax";
            this.txtboxMax.Size = new System.Drawing.Size(45, 26);
            this.txtboxMax.TabIndex = 10;
            // 
            // butEnter
            // 
            this.butEnter.Location = new System.Drawing.Point(513, 64);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(57, 27);
            this.butEnter.TabIndex = 9;
            this.butEnter.Text = "确认";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.ButEnter_Click);
            // 
            // txtboxMin
            // 
            this.txtboxMin.Location = new System.Drawing.Point(378, 64);
            this.txtboxMin.Name = "txtboxMin";
            this.txtboxMin.Size = new System.Drawing.Size(45, 26);
            this.txtboxMin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "输入分数段：";
            // 
            // butFail
            // 
            this.butFail.Location = new System.Drawing.Point(187, 172);
            this.butFail.Name = "butFail";
            this.butFail.Size = new System.Drawing.Size(155, 30);
            this.butFail.TabIndex = 6;
            this.butFail.Text = "不及格(60以下)";
            this.butFail.UseVisualStyleBackColor = true;
            this.butFail.Click += new System.EventHandler(this.ButFail_Click);
            // 
            // butPass
            // 
            this.butPass.Location = new System.Drawing.Point(187, 135);
            this.butPass.Name = "butPass";
            this.butPass.Size = new System.Drawing.Size(155, 30);
            this.butPass.TabIndex = 5;
            this.butPass.Text = "及格(60~79)";
            this.butPass.UseVisualStyleBackColor = true;
            this.butPass.Click += new System.EventHandler(this.ButPass_Click);
            // 
            // butGood
            // 
            this.butGood.Location = new System.Drawing.Point(187, 99);
            this.butGood.Name = "butGood";
            this.butGood.Size = new System.Drawing.Size(155, 30);
            this.butGood.TabIndex = 4;
            this.butGood.Text = "良好(80~89)";
            this.butGood.UseVisualStyleBackColor = true;
            this.butGood.Click += new System.EventHandler(this.ButGood_Click);
            // 
            // butExcellent
            // 
            this.butExcellent.Location = new System.Drawing.Point(187, 64);
            this.butExcellent.Name = "butExcellent";
            this.butExcellent.Size = new System.Drawing.Size(155, 30);
            this.butExcellent.TabIndex = 3;
            this.butExcellent.Text = "优秀(90~100)";
            this.butExcellent.UseVisualStyleBackColor = true;
            this.butExcellent.Click += new System.EventHandler(this.ButExcellent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "分数等级：";
            // 
            // comboxSex
            // 
            this.comboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex.FormattingEnabled = true;
            this.comboxSex.Location = new System.Drawing.Point(26, 64);
            this.comboxSex.Name = "comboxSex";
            this.comboxSex.Size = new System.Drawing.Size(94, 28);
            this.comboxSex.TabIndex = 1;
            // 
            // chkboxSex
            // 
            this.chkboxSex.AutoSize = true;
            this.chkboxSex.Location = new System.Drawing.Point(26, 34);
            this.chkboxSex.Name = "chkboxSex";
            this.chkboxSex.Size = new System.Drawing.Size(56, 24);
            this.chkboxSex.TabIndex = 0;
            this.chkboxSex.Text = "性别";
            this.chkboxSex.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxRange);
            this.groupBox2.Controls.Add(this.radbutClass);
            this.groupBox2.Controls.Add(this.radbutCourse);
            this.groupBox2.Controls.Add(this.radbutDepart);
            this.groupBox2.Controls.Add(this.radbutSchool);
            this.groupBox2.Location = new System.Drawing.Point(21, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择统计范围";
            // 
            // comboxRange
            // 
            this.comboxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxRange.FormattingEnabled = true;
            this.comboxRange.Location = new System.Drawing.Point(23, 94);
            this.comboxRange.Name = "comboxRange";
            this.comboxRange.Size = new System.Drawing.Size(170, 28);
            this.comboxRange.TabIndex = 4;
            // 
            // radbutClass
            // 
            this.radbutClass.AutoSize = true;
            this.radbutClass.Location = new System.Drawing.Point(138, 64);
            this.radbutClass.Name = "radbutClass";
            this.radbutClass.Size = new System.Drawing.Size(55, 24);
            this.radbutClass.TabIndex = 3;
            this.radbutClass.Text = "班级";
            this.radbutClass.UseVisualStyleBackColor = true;
            this.radbutClass.CheckedChanged += new System.EventHandler(this.RadbutClass_CheckedChanged);
            // 
            // radbutCourse
            // 
            this.radbutCourse.AutoSize = true;
            this.radbutCourse.Location = new System.Drawing.Point(23, 64);
            this.radbutCourse.Name = "radbutCourse";
            this.radbutCourse.Size = new System.Drawing.Size(55, 24);
            this.radbutCourse.TabIndex = 2;
            this.radbutCourse.Text = "课程";
            this.radbutCourse.UseVisualStyleBackColor = true;
            this.radbutCourse.CheckedChanged += new System.EventHandler(this.RadbutCourse_CheckedChanged);
            // 
            // radbutDepart
            // 
            this.radbutDepart.AutoSize = true;
            this.radbutDepart.Location = new System.Drawing.Point(138, 34);
            this.radbutDepart.Name = "radbutDepart";
            this.radbutDepart.Size = new System.Drawing.Size(55, 24);
            this.radbutDepart.TabIndex = 1;
            this.radbutDepart.Text = "院系";
            this.radbutDepart.UseVisualStyleBackColor = true;
            this.radbutDepart.CheckedChanged += new System.EventHandler(this.RadbutDepart_CheckedChanged);
            // 
            // radbutSchool
            // 
            this.radbutSchool.AutoSize = true;
            this.radbutSchool.Checked = true;
            this.radbutSchool.Location = new System.Drawing.Point(23, 34);
            this.radbutSchool.Name = "radbutSchool";
            this.radbutSchool.Size = new System.Drawing.Size(55, 24);
            this.radbutSchool.TabIndex = 0;
            this.radbutSchool.TabStop = true;
            this.radbutSchool.Text = "全校";
            this.radbutSchool.UseVisualStyleBackColor = true;
            this.radbutSchool.CheckedChanged += new System.EventHandler(this.RadbutSchool_CheckedChanged);
            // 
            // chkboxBukao
            // 
            this.chkboxBukao.AutoSize = true;
            this.chkboxBukao.Location = new System.Drawing.Point(26, 116);
            this.chkboxBukao.Name = "chkboxBukao";
            this.chkboxBukao.Size = new System.Drawing.Size(112, 24);
            this.chkboxBukao.TabIndex = 15;
            this.chkboxBukao.Text = "统计补考成绩";
            this.chkboxBukao.UseVisualStyleBackColor = true;
            // 
            // frmStatiMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmStatiMark";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbutDepart;
        private System.Windows.Forms.RadioButton radbutSchool;
        private System.Windows.Forms.RadioButton radbutCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxReuslt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxMax;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butFail;
        private System.Windows.Forms.Button butPass;
        private System.Windows.Forms.Button butGood;
        private System.Windows.Forms.Button butExcellent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxSex;
        private System.Windows.Forms.CheckBox chkboxSex;
        private System.Windows.Forms.ComboBox comboxRange;
        private System.Windows.Forms.RadioButton radbutClass;
        private System.Windows.Forms.TextBox txtboxMin;
        private System.Windows.Forms.CheckBox chkboxBukao;
    }
}
