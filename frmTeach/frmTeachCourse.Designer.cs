namespace EduAdminSys.frmTeach
{
    partial class frmTeachCourse
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
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radbutCouHour = new System.Windows.Forms.RadioButton();
            this.butSort = new System.Windows.Forms.Button();
            this.radbutStunum = new System.Windows.Forms.RadioButton();
            this.comboxSort = new System.Windows.Forms.ComboBox();
            this.butRecovery = new System.Windows.Forms.Button();
            this.classno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "任教课程：";
            // 
            // dgvcourse
            // 
            this.dgvcourse.AllowUserToAddRows = false;
            this.dgvcourse.AllowUserToDeleteRows = false;
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classno,
            this.classname,
            this.stunum,
            this.couhour,
            this.coutype});
            this.dgvcourse.Location = new System.Drawing.Point(42, 34);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.ReadOnly = true;
            this.dgvcourse.RowTemplate.Height = 23;
            this.dgvcourse.Size = new System.Drawing.Size(600, 396);
            this.dgvcourse.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(659, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCheck.Location = new System.Drawing.Point(111, 111);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(92, 30);
            this.butCheck.TabIndex = 2;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxCheck.Location = new System.Drawing.Point(37, 58);
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(166, 26);
            this.txtboxCheck.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入班级名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Controls.Add(this.radbutCouHour);
            this.groupBox2.Controls.Add(this.butSort);
            this.groupBox2.Controls.Add(this.radbutStunum);
            this.groupBox2.Controls.Add(this.comboxSort);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(659, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "排序";
            // 
            // radbutCouHour
            // 
            this.radbutCouHour.AutoSize = true;
            this.radbutCouHour.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutCouHour.Location = new System.Drawing.Point(37, 51);
            this.radbutCouHour.Name = "radbutCouHour";
            this.radbutCouHour.Size = new System.Drawing.Size(97, 24);
            this.radbutCouHour.TabIndex = 1;
            this.radbutCouHour.TabStop = true;
            this.radbutCouHour.Text = "按课时排序";
            this.radbutCouHour.UseVisualStyleBackColor = true;
            // 
            // butSort
            // 
            this.butSort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSort.Location = new System.Drawing.Point(111, 125);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(92, 30);
            this.butSort.TabIndex = 5;
            this.butSort.Text = "排序";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.ButSort_Click);
            // 
            // radbutStunum
            // 
            this.radbutStunum.AutoSize = true;
            this.radbutStunum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutStunum.Location = new System.Drawing.Point(37, 23);
            this.radbutStunum.Name = "radbutStunum";
            this.radbutStunum.Size = new System.Drawing.Size(125, 24);
            this.radbutStunum.TabIndex = 0;
            this.radbutStunum.TabStop = true;
            this.radbutStunum.Text = "按学生人数排序";
            this.radbutStunum.UseVisualStyleBackColor = true;
            // 
            // comboxSort
            // 
            this.comboxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxSort.FormattingEnabled = true;
            this.comboxSort.Location = new System.Drawing.Point(37, 79);
            this.comboxSort.Name = "comboxSort";
            this.comboxSort.Size = new System.Drawing.Size(166, 28);
            this.comboxSort.TabIndex = 4;
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(90, 173);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(113, 30);
            this.butRecovery.TabIndex = 6;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // classno
            // 
            this.classno.DataPropertyName = "classno";
            this.classno.HeaderText = "班级编号";
            this.classno.Name = "classno";
            this.classno.ReadOnly = true;
            // 
            // classname
            // 
            this.classname.DataPropertyName = "classname";
            this.classname.HeaderText = "班级名称";
            this.classname.Name = "classname";
            this.classname.ReadOnly = true;
            this.classname.Width = 150;
            // 
            // stunum
            // 
            this.stunum.DataPropertyName = "stunum";
            this.stunum.HeaderText = "学生人数";
            this.stunum.Name = "stunum";
            this.stunum.ReadOnly = true;
            // 
            // couhour
            // 
            this.couhour.DataPropertyName = "couhour";
            this.couhour.HeaderText = "课时";
            this.couhour.Name = "couhour";
            this.couhour.ReadOnly = true;
            // 
            // coutype
            // 
            this.coutype.DataPropertyName = "coutype";
            this.coutype.HeaderText = "课程类型";
            this.coutype.Name = "coutype";
            this.coutype.ReadOnly = true;
            // 
            // frmTeachCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvcourse);
            this.Controls.Add(this.label1);
            this.Name = "frmTeachCourse";
            this.Size = new System.Drawing.Size(930, 460);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbutCouHour;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.RadioButton radbutStunum;
        private System.Windows.Forms.ComboBox comboxSort;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.DataGridViewTextBoxColumn classno;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunum;
        private System.Windows.Forms.DataGridViewTextBoxColumn couhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutype;
    }
}
