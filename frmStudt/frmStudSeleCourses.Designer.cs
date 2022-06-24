using System;
using System.Windows.Forms;

namespace EduAdminSys.frmStudt
{
    partial class frmStudSeleCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labClass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxCredit = new System.Windows.Forms.TextBox();
            this.comboxClass = new System.Windows.Forms.ComboBox();
            this.buttEnter = new System.Windows.Forms.Button();
            this.labNumber = new System.Windows.Forms.Label();
            this.dgvSeleCourse = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Join = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butRecovery = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleCourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "可选课程信息：";
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClass.Location = new System.Drawing.Point(19, 32);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(51, 20);
            this.labClass.TabIndex = 4;
            this.labClass.Text = "班级：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxCredit);
            this.groupBox2.Controls.Add(this.comboxClass);
            this.groupBox2.Controls.Add(this.buttEnter);
            this.groupBox2.Controls.Add(this.labNumber);
            this.groupBox2.Controls.Add(this.labClass);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(288, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择班级";
            // 
            // txtboxCredit
            // 
            this.txtboxCredit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxCredit.Location = new System.Drawing.Point(118, 81);
            this.txtboxCredit.Name = "txtboxCredit";
            this.txtboxCredit.ReadOnly = true;
            this.txtboxCredit.Size = new System.Drawing.Size(61, 26);
            this.txtboxCredit.TabIndex = 11;
            // 
            // comboxClass
            // 
            this.comboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClass.FormattingEnabled = true;
            this.comboxClass.Location = new System.Drawing.Point(76, 28);
            this.comboxClass.Name = "comboxClass";
            this.comboxClass.Size = new System.Drawing.Size(182, 25);
            this.comboxClass.TabIndex = 8;
            // 
            // buttEnter
            // 
            this.buttEnter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttEnter.Location = new System.Drawing.Point(206, 79);
            this.buttEnter.Name = "buttEnter";
            this.buttEnter.Size = new System.Drawing.Size(75, 32);
            this.buttEnter.TabIndex = 7;
            this.buttEnter.Text = "加入";
            this.buttEnter.UseVisualStyleBackColor = true;
            this.buttEnter.Click += new System.EventHandler(this.ButtEnter_Click);
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNumber.Location = new System.Drawing.Point(19, 85);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(93, 20);
            this.labNumber.TabIndex = 6;
            this.labNumber.Text = "已选修学分：";
            // 
            // dgvSeleCourse
            // 
            this.dgvSeleCourse.AllowUserToAddRows = false;
            this.dgvSeleCourse.AllowUserToDeleteRows = false;
            this.dgvSeleCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Join,
            this.classno,
            this.classname,
            this.credit,
            this.couhour,
            this.coutype,
            this.teachname,
            this.stunum,
            this.departname});
            this.dgvSeleCourse.Location = new System.Drawing.Point(37, 32);
            this.dgvSeleCourse.Name = "dgvSeleCourse";
            this.dgvSeleCourse.ReadOnly = true;
            this.dgvSeleCourse.RowTemplate.Height = 23;
            this.dgvSeleCourse.Size = new System.Drawing.Size(859, 279);
            this.dgvSeleCourse.TabIndex = 7;
            this.dgvSeleCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeleCourse_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butRecovery);
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(48, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找筛选";
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCheck.Location = new System.Drawing.Point(140, 77);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 30);
            this.butCheck.TabIndex = 2;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxClassName
            // 
            this.txtboxClassName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxClassName.Location = new System.Drawing.Point(24, 44);
            this.txtboxClassName.MaxLength = 50;
            this.txtboxClassName.Name = "txtboxClassName";
            this.txtboxClassName.Size = new System.Drawing.Size(191, 26);
            this.txtboxClassName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "按班级名称查找：";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(585, 342);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(311, 104);
            this.listBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(581, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "已选修课程：";
            // 
            // Join
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Join.DefaultCellStyle = dataGridViewCellStyle1;
            this.Join.HeaderText = "选择课程";
            this.Join.Name = "Join";
            this.Join.ReadOnly = true;
            this.Join.Text = "选择";
            this.Join.UseColumnTextForButtonValue = true;
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
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
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
            // teachname
            // 
            this.teachname.DataPropertyName = "teachname";
            this.teachname.HeaderText = "任课教师";
            this.teachname.Name = "teachname";
            this.teachname.ReadOnly = true;
            // 
            // stunum
            // 
            this.stunum.DataPropertyName = "stunum";
            this.stunum.HeaderText = "已选学生数";
            this.stunum.Name = "stunum";
            this.stunum.ReadOnly = true;
            // 
            // departname
            // 
            this.departname.DataPropertyName = "departname";
            this.departname.HeaderText = "所属学院";
            this.departname.Name = "departname";
            this.departname.ReadOnly = true;
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(24, 77);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(87, 30);
            this.butRecovery.TabIndex = 3;
            this.butRecovery.Text = "复原选课表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // frmStudSeleCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSeleCourse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudSeleCourses";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleCourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboxClass;
        private System.Windows.Forms.Button buttEnter;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtboxCredit;
        private System.Windows.Forms.DataGridView dgvSeleCourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private DataGridViewButtonColumn Join;
        private DataGridViewTextBoxColumn classno;
        private DataGridViewTextBoxColumn classname;
        private DataGridViewTextBoxColumn credit;
        private DataGridViewTextBoxColumn couhour;
        private DataGridViewTextBoxColumn coutype;
        private DataGridViewTextBoxColumn teachname;
        private DataGridViewTextBoxColumn stunum;
        private DataGridViewTextBoxColumn departname;
        private Button butRecovery;
    }
}
