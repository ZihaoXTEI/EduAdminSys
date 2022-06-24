namespace EduAdminSys.frmTeach
{
    partial class frmTeachSelCourses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butRecovery = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butCheck = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxCoutClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butJoin = new System.Windows.Forms.Button();
            this.comboxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSeleClass = new System.Windows.Forms.DataGridView();
            this.join = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butRecovery);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(603, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(23, 78);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(112, 34);
            this.butRecovery.TabIndex = 6;
            this.butRecovery.Text = "恢复选课表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(23, 46);
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(243, 23);
            this.txtboxCheck.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入课程或班级名称：";
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCheck.Location = new System.Drawing.Point(191, 78);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 34);
            this.butCheck.TabIndex = 3;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtboxCoutClass);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.butJoin);
            this.groupBox3.Controls.Add(this.comboxClass);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(603, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择任课班级";
            // 
            // txtboxCoutClass
            // 
            this.txtboxCoutClass.Location = new System.Drawing.Point(27, 125);
            this.txtboxCoutClass.Name = "txtboxCoutClass";
            this.txtboxCoutClass.ReadOnly = true;
            this.txtboxCoutClass.Size = new System.Drawing.Size(89, 23);
            this.txtboxCoutClass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "已选班级数：";
            // 
            // butJoin
            // 
            this.butJoin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butJoin.Location = new System.Drawing.Point(191, 115);
            this.butJoin.Name = "butJoin";
            this.butJoin.Size = new System.Drawing.Size(75, 33);
            this.butJoin.TabIndex = 2;
            this.butJoin.Text = "确认";
            this.butJoin.UseVisualStyleBackColor = true;
            this.butJoin.Click += new System.EventHandler(this.ButJoin_Click);
            // 
            // comboxClass
            // 
            this.comboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxClass.FormattingEnabled = true;
            this.comboxClass.Location = new System.Drawing.Point(43, 56);
            this.comboxClass.Name = "comboxClass";
            this.comboxClass.Size = new System.Drawing.Size(223, 28);
            this.comboxClass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择班级：";
            // 
            // dgvSeleClass
            // 
            this.dgvSeleClass.AllowUserToAddRows = false;
            this.dgvSeleClass.AllowUserToDeleteRows = false;
            this.dgvSeleClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.join,
            this.classno,
            this.classname,
            this.couhour,
            this.coutype});
            this.dgvSeleClass.Location = new System.Drawing.Point(28, 38);
            this.dgvSeleClass.Name = "dgvSeleClass";
            this.dgvSeleClass.ReadOnly = true;
            this.dgvSeleClass.RowTemplate.Height = 23;
            this.dgvSeleClass.Size = new System.Drawing.Size(557, 415);
            this.dgvSeleClass.TabIndex = 3;
            this.dgvSeleClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeleCourse_CellContentClick);
            // 
            // join
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.join.DefaultCellStyle = dataGridViewCellStyle1;
            this.join.HeaderText = "选择任课班级";
            this.join.Name = "join";
            this.join.ReadOnly = true;
            this.join.Text = "选择";
            this.join.UseColumnTextForButtonValue = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "选择任课班级";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(603, 369);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(308, 84);
            this.listBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(599, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "已选择班级：";
            // 
            // frmTeachSelCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSeleClass);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeachSelCourses";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butJoin;
        private System.Windows.Forms.ComboBox comboxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.DataGridView dgvSeleClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxCoutClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn join;
        private System.Windows.Forms.DataGridViewTextBoxColumn classno;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn couhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutype;
    }
}
