namespace EduAdminSys.frmStudt
{
    partial class frmStudCourses
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
            this.radbutCredit = new System.Windows.Forms.RadioButton();
            this.radbutCouHour = new System.Windows.Forms.RadioButton();
            this.butCancelS = new System.Windows.Forms.Button();
            this.radbutCouType = new System.Windows.Forms.RadioButton();
            this.butEnterS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxScreen = new System.Windows.Forms.ComboBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.butCancelC = new System.Windows.Forms.Button();
            this.butEnterC = new System.Windows.Forms.Button();
            this.radbutTeachName = new System.Windows.Forms.RadioButton();
            this.radbutCouName = new System.Windows.Forms.RadioButton();
            this.courseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbutCredit);
            this.groupBox1.Controls.Add(this.radbutCouHour);
            this.groupBox1.Controls.Add(this.butCancelS);
            this.groupBox1.Controls.Add(this.radbutCouType);
            this.groupBox1.Controls.Add(this.butEnterS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboxScreen);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(456, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // radbutCredit
            // 
            this.radbutCredit.AutoSize = true;
            this.radbutCredit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutCredit.Location = new System.Drawing.Point(23, 89);
            this.radbutCredit.Name = "radbutCredit";
            this.radbutCredit.Size = new System.Drawing.Size(125, 24);
            this.radbutCredit.TabIndex = 7;
            this.radbutCredit.TabStop = true;
            this.radbutCredit.Text = "按课程学分筛选";
            this.radbutCredit.UseVisualStyleBackColor = true;
            this.radbutCredit.CheckedChanged += new System.EventHandler(this.RadbutCredit_CheckedChanged);
            // 
            // radbutCouHour
            // 
            this.radbutCouHour.AutoSize = true;
            this.radbutCouHour.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutCouHour.Location = new System.Drawing.Point(23, 56);
            this.radbutCouHour.Name = "radbutCouHour";
            this.radbutCouHour.Size = new System.Drawing.Size(125, 24);
            this.radbutCouHour.TabIndex = 6;
            this.radbutCouHour.TabStop = true;
            this.radbutCouHour.Text = "按课程学时筛选";
            this.radbutCouHour.UseVisualStyleBackColor = true;
            this.radbutCouHour.CheckedChanged += new System.EventHandler(this.RadbutCouHour_CheckedChanged);
            // 
            // butCancelS
            // 
            this.butCancelS.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancelS.Location = new System.Drawing.Point(345, 81);
            this.butCancelS.Name = "butCancelS";
            this.butCancelS.Size = new System.Drawing.Size(75, 40);
            this.butCancelS.TabIndex = 2;
            this.butCancelS.Text = "取消";
            this.butCancelS.UseVisualStyleBackColor = true;
            // 
            // radbutCouType
            // 
            this.radbutCouType.AutoSize = true;
            this.radbutCouType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutCouType.Location = new System.Drawing.Point(23, 23);
            this.radbutCouType.Name = "radbutCouType";
            this.radbutCouType.Size = new System.Drawing.Size(125, 24);
            this.radbutCouType.TabIndex = 5;
            this.radbutCouType.TabStop = true;
            this.radbutCouType.Text = "按课程类型筛选";
            this.radbutCouType.UseVisualStyleBackColor = true;
            this.radbutCouType.CheckedChanged += new System.EventHandler(this.RadbutCouType_CheckedChanged);
            // 
            // butEnterS
            // 
            this.butEnterS.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnterS.Location = new System.Drawing.Point(345, 15);
            this.butEnterS.Name = "butEnterS";
            this.butEnterS.Size = new System.Drawing.Size(75, 40);
            this.butEnterS.TabIndex = 1;
            this.butEnterS.Text = "确认";
            this.butEnterS.UseVisualStyleBackColor = true;
            this.butEnterS.Click += new System.EventHandler(this.ButEnterS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择范围或类型：";
            // 
            // comboxScreen
            // 
            this.comboxScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxScreen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxScreen.FormattingEnabled = true;
            this.comboxScreen.Location = new System.Drawing.Point(173, 48);
            this.comboxScreen.Name = "comboxScreen";
            this.comboxScreen.Size = new System.Drawing.Size(150, 28);
            this.comboxScreen.TabIndex = 3;
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseno,
            this.coursename,
            this.coutype,
            this.couhour,
            this.classname,
            this.credit,
            this.teachername,
            this.departname});
            this.dgvCourse.Location = new System.Drawing.Point(43, 31);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(844, 284);
            this.dgvCourse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "课程信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtboxCheck);
            this.groupBox2.Controls.Add(this.butCancelC);
            this.groupBox2.Controls.Add(this.butEnterC);
            this.groupBox2.Controls.Add(this.radbutTeachName);
            this.groupBox2.Controls.Add(this.radbutCouName);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(43, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查找";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入相应的值：";
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(63, 89);
            this.txtboxCheck.MaxLength = 100;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(184, 23);
            this.txtboxCheck.TabIndex = 4;
            // 
            // butCancelC
            // 
            this.butCancelC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancelC.Location = new System.Drawing.Point(296, 81);
            this.butCancelC.Name = "butCancelC";
            this.butCancelC.Size = new System.Drawing.Size(75, 40);
            this.butCancelC.TabIndex = 3;
            this.butCancelC.Text = "取消";
            this.butCancelC.UseVisualStyleBackColor = true;
            // 
            // butEnterC
            // 
            this.butEnterC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnterC.Location = new System.Drawing.Point(296, 15);
            this.butEnterC.Name = "butEnterC";
            this.butEnterC.Size = new System.Drawing.Size(75, 40);
            this.butEnterC.TabIndex = 2;
            this.butEnterC.Text = "确认";
            this.butEnterC.UseVisualStyleBackColor = true;
            this.butEnterC.Click += new System.EventHandler(this.ButEnterC_Click);
            // 
            // radbutTeachName
            // 
            this.radbutTeachName.AutoSize = true;
            this.radbutTeachName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutTeachName.Location = new System.Drawing.Point(154, 28);
            this.radbutTeachName.Name = "radbutTeachName";
            this.radbutTeachName.Size = new System.Drawing.Size(125, 24);
            this.radbutTeachName.TabIndex = 1;
            this.radbutTeachName.TabStop = true;
            this.radbutTeachName.Text = "按任课老师查找";
            this.radbutTeachName.UseVisualStyleBackColor = true;
            // 
            // radbutCouName
            // 
            this.radbutCouName.AutoSize = true;
            this.radbutCouName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutCouName.Location = new System.Drawing.Point(20, 28);
            this.radbutCouName.Name = "radbutCouName";
            this.radbutCouName.Size = new System.Drawing.Size(125, 24);
            this.radbutCouName.TabIndex = 0;
            this.radbutCouName.TabStop = true;
            this.radbutCouName.Text = "按课程名称查找";
            this.radbutCouName.UseVisualStyleBackColor = true;
            // 
            // courseno
            // 
            this.courseno.DataPropertyName = "courseno";
            this.courseno.HeaderText = "课程编号";
            this.courseno.Name = "courseno";
            this.courseno.ReadOnly = true;
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "coursename";
            this.coursename.HeaderText = "课程名称";
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            // 
            // coutype
            // 
            this.coutype.DataPropertyName = "coutype";
            this.coutype.HeaderText = "课程类型";
            this.coutype.Name = "coutype";
            this.coutype.ReadOnly = true;
            // 
            // couhour
            // 
            this.couhour.DataPropertyName = "couhour";
            this.couhour.HeaderText = "课时";
            this.couhour.Name = "couhour";
            this.couhour.ReadOnly = true;
            // 
            // classname
            // 
            this.classname.DataPropertyName = "classname";
            this.classname.HeaderText = "班级";
            this.classname.Name = "classname";
            this.classname.ReadOnly = true;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // teachername
            // 
            this.teachername.DataPropertyName = "teachname";
            this.teachername.HeaderText = "任课教师";
            this.teachername.Name = "teachername";
            this.teachername.ReadOnly = true;
            // 
            // departname
            // 
            this.departname.DataPropertyName = "departname";
            this.departname.HeaderText = "院系名称";
            this.departname.Name = "departname";
            this.departname.ReadOnly = true;
            // 
            // frmStudCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudCourses";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxScreen;
        private System.Windows.Forms.Button butEnterS;
        private System.Windows.Forms.Button butCancelS;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.RadioButton radbutCredit;
        private System.Windows.Forms.RadioButton radbutCouHour;
        private System.Windows.Forms.RadioButton radbutCouType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butCancelC;
        private System.Windows.Forms.Button butEnterC;
        private System.Windows.Forms.RadioButton radbutTeachName;
        private System.Windows.Forms.RadioButton radbutCouName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutype;
        private System.Windows.Forms.DataGridViewTextBoxColumn couhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachername;
        private System.Windows.Forms.DataGridViewTextBoxColumn departname;
    }
}
