namespace EduAdminSys.frmTeach
{
    partial class frmTeachRegisMark
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
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butScreen = new System.Windows.Forms.Button();
            this.comboxClass = new System.Windows.Forms.ComboBox();
            this.labClass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butRecovery = new System.Windows.Forms.Button();
            this.labTip = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxBukao = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSex = new System.Windows.Forms.TextBox();
            this.txtboxClassName = new System.Windows.Forms.TextBox();
            this.txtboxMark = new System.Windows.Forms.TextBox();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.butRegister = new System.Windows.Forms.Button();
            this.labClassName = new System.Windows.Forms.Label();
            this.labBukao = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labMark = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.dgvRegisMark = new System.Windows.Forms.DataGridView();
            this.stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisMark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butScreen);
            this.groupBox1.Controls.Add(this.comboxClass);
            this.groupBox1.Controls.Add(this.labClass);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(656, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选查找";
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCheck.Location = new System.Drawing.Point(128, 216);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 34);
            this.butCheck.TabIndex = 5;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxCheck.Location = new System.Drawing.Point(25, 175);
            this.txtboxCheck.MaxLength = 25;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(178, 26);
            this.txtboxCheck.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "按学号查找";
            // 
            // butScreen
            // 
            this.butScreen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butScreen.Location = new System.Drawing.Point(128, 94);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 34);
            this.butScreen.TabIndex = 2;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // comboxClass
            // 
            this.comboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClass.FormattingEnabled = true;
            this.comboxClass.Location = new System.Drawing.Point(21, 54);
            this.comboxClass.Name = "comboxClass";
            this.comboxClass.Size = new System.Drawing.Size(182, 25);
            this.comboxClass.TabIndex = 1;
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClass.Location = new System.Drawing.Point(17, 19);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(79, 20);
            this.labClass.TabIndex = 0;
            this.labClass.Text = "按班级筛选";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Controls.Add(this.labTip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtboxBukao);
            this.groupBox2.Controls.Add(this.txtboxName);
            this.groupBox2.Controls.Add(this.txtboxSex);
            this.groupBox2.Controls.Add(this.txtboxClassName);
            this.groupBox2.Controls.Add(this.txtboxMark);
            this.groupBox2.Controls.Add(this.txtboxId);
            this.groupBox2.Controls.Add(this.butRegister);
            this.groupBox2.Controls.Add(this.labClassName);
            this.groupBox2.Controls.Add(this.labBukao);
            this.groupBox2.Controls.Add(this.labSex);
            this.groupBox2.Controls.Add(this.labMark);
            this.groupBox2.Controls.Add(this.labName);
            this.groupBox2.Controls.Add(this.labId);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(60, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "录入成绩";
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(674, 82);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(125, 32);
            this.butRecovery.TabIndex = 15;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // labTip
            // 
            this.labTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(644, 33);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(155, 31);
            this.labTip.TabIndex = 14;
            this.labTip.Text = "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(548, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "信息提示：";
            // 
            // txtboxBukao
            // 
            this.txtboxBukao.Location = new System.Drawing.Point(365, 89);
            this.txtboxBukao.Name = "txtboxBukao";
            this.txtboxBukao.Size = new System.Drawing.Size(149, 23);
            this.txtboxBukao.TabIndex = 12;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(97, 56);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.ReadOnly = true;
            this.txtboxName.Size = new System.Drawing.Size(149, 23);
            this.txtboxName.TabIndex = 11;
            // 
            // txtboxSex
            // 
            this.txtboxSex.Location = new System.Drawing.Point(97, 89);
            this.txtboxSex.Name = "txtboxSex";
            this.txtboxSex.ReadOnly = true;
            this.txtboxSex.Size = new System.Drawing.Size(76, 23);
            this.txtboxSex.TabIndex = 10;
            // 
            // txtboxClassName
            // 
            this.txtboxClassName.Location = new System.Drawing.Point(365, 23);
            this.txtboxClassName.Name = "txtboxClassName";
            this.txtboxClassName.ReadOnly = true;
            this.txtboxClassName.Size = new System.Drawing.Size(149, 23);
            this.txtboxClassName.TabIndex = 9;
            // 
            // txtboxMark
            // 
            this.txtboxMark.Location = new System.Drawing.Point(365, 56);
            this.txtboxMark.Name = "txtboxMark";
            this.txtboxMark.Size = new System.Drawing.Size(149, 23);
            this.txtboxMark.TabIndex = 8;
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(97, 23);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.ReadOnly = true;
            this.txtboxId.Size = new System.Drawing.Size(149, 23);
            this.txtboxId.TabIndex = 7;
            // 
            // butRegister
            // 
            this.butRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRegister.Location = new System.Drawing.Point(548, 82);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(75, 32);
            this.butRegister.TabIndex = 6;
            this.butRegister.Text = "录入";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.ButRegister_Click);
            // 
            // labClassName
            // 
            this.labClassName.AutoSize = true;
            this.labClassName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClassName.Location = new System.Drawing.Point(269, 23);
            this.labClassName.Name = "labClassName";
            this.labClassName.Size = new System.Drawing.Size(79, 20);
            this.labClassName.TabIndex = 5;
            this.labClassName.Text = "班级名称：";
            // 
            // labBukao
            // 
            this.labBukao.AutoSize = true;
            this.labBukao.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBukao.Location = new System.Drawing.Point(269, 89);
            this.labBukao.Name = "labBukao";
            this.labBukao.Size = new System.Drawing.Size(79, 20);
            this.labBukao.TabIndex = 4;
            this.labBukao.Text = "补考分数：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSex.Location = new System.Drawing.Point(26, 89);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(51, 20);
            this.labSex.TabIndex = 3;
            this.labSex.Text = "性别：";
            // 
            // labMark
            // 
            this.labMark.AutoSize = true;
            this.labMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMark.Location = new System.Drawing.Point(269, 56);
            this.labMark.Name = "labMark";
            this.labMark.Size = new System.Drawing.Size(51, 20);
            this.labMark.TabIndex = 2;
            this.labMark.Text = "分数：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(26, 56);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(51, 20);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名：";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labId.Location = new System.Drawing.Point(26, 23);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(51, 20);
            this.labId.TabIndex = 0;
            this.labId.Text = "学号：";
            // 
            // dgvRegisMark
            // 
            this.dgvRegisMark.AllowUserToAddRows = false;
            this.dgvRegisMark.AllowUserToDeleteRows = false;
            this.dgvRegisMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuno,
            this.stuname,
            this.classname,
            this.mark,
            this.bukao});
            this.dgvRegisMark.Location = new System.Drawing.Point(60, 43);
            this.dgvRegisMark.Name = "dgvRegisMark";
            this.dgvRegisMark.ReadOnly = true;
            this.dgvRegisMark.RowTemplate.Height = 23;
            this.dgvRegisMark.Size = new System.Drawing.Size(550, 261);
            this.dgvRegisMark.TabIndex = 2;
            this.dgvRegisMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRegisMark_CellClick);
            // 
            // stuno
            // 
            this.stuno.DataPropertyName = "stuno";
            this.stuno.HeaderText = "学生学号";
            this.stuno.Name = "stuno";
            this.stuno.ReadOnly = true;
            // 
            // stuname
            // 
            this.stuname.DataPropertyName = "stuname";
            this.stuname.HeaderText = "学生姓名";
            this.stuname.Name = "stuname";
            this.stuname.ReadOnly = true;
            // 
            // classname
            // 
            this.classname.DataPropertyName = "classname";
            this.classname.HeaderText = "班级名称";
            this.classname.Name = "classname";
            this.classname.ReadOnly = true;
            // 
            // mark
            // 
            this.mark.DataPropertyName = "mark";
            this.mark.HeaderText = "成绩";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            // 
            // bukao
            // 
            this.bukao.DataPropertyName = "bukao";
            this.bukao.HeaderText = "补考成绩";
            this.bukao.Name = "bukao";
            this.bukao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "录入学生成绩";
            // 
            // frmTeachRegisMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegisMark);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeachRegisMark";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.ComboBox comboxClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labMark;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.TextBox txtboxBukao;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSex;
        private System.Windows.Forms.TextBox txtboxClassName;
        private System.Windows.Forms.TextBox txtboxMark;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Label labClassName;
        private System.Windows.Forms.Label labBukao;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegisMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Label label3;
    }
}
