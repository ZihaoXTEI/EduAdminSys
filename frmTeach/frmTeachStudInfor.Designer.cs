namespace EduAdminSys.frmTeach
{
    partial class frmTeachStudInfor
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
            this.butEnter = new System.Windows.Forms.Button();
            this.comboxClass = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxAvg = new System.Windows.Forms.TextBox();
            this.txtboxMaxMark = new System.Windows.Forms.TextBox();
            this.txtboxStuNum = new System.Windows.Forms.TextBox();
            this.labMinMark = new System.Windows.Forms.Label();
            this.labMaxMark = new System.Windows.Forms.Label();
            this.labAvg = new System.Windows.Forms.Label();
            this.labStuNum = new System.Windows.Forms.Label();
            this.dgvStuInfo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxClassStati = new System.Windows.Forms.ComboBox();
            this.txtboxMinMark = new System.Windows.Forms.TextBox();
            this.radbutMarkASC = new System.Windows.Forms.RadioButton();
            this.chkboxClass = new System.Windows.Forms.CheckBox();
            this.chkboxMarkLevel = new System.Windows.Forms.CheckBox();
            this.comboxLevel = new System.Windows.Forms.ComboBox();
            this.radbutMarkDESC = new System.Windows.Forms.RadioButton();
            this.butCheck = new System.Windows.Forms.Button();
            this.butRecovery = new System.Windows.Forms.Button();
            this.butStati = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxPassNum = new System.Windows.Forms.TextBox();
            this.txtboxExceNum = new System.Windows.Forms.TextBox();
            this.txtboxFailNum = new System.Windows.Forms.TextBox();
            this.stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboxLevel);
            this.groupBox1.Controls.Add(this.chkboxMarkLevel);
            this.groupBox1.Controls.Add(this.chkboxClass);
            this.groupBox1.Controls.Add(this.butEnter);
            this.groupBox1.Controls.Add(this.comboxClass);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(708, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // butEnter
            // 
            this.butEnter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter.Location = new System.Drawing.Point(110, 176);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(75, 33);
            this.butEnter.TabIndex = 3;
            this.butEnter.Text = "确认";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.ButEnter_Click);
            // 
            // comboxClass
            // 
            this.comboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxClass.FormattingEnabled = true;
            this.comboxClass.Location = new System.Drawing.Point(20, 67);
            this.comboxClass.Name = "comboxClass";
            this.comboxClass.Size = new System.Drawing.Size(165, 28);
            this.comboxClass.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.txtboxStuNum);
            this.groupBox2.Controls.Add(this.labStuNum);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(708, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查找";
            // 
            // txtboxAvg
            // 
            this.txtboxAvg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxAvg.Location = new System.Drawing.Point(245, 25);
            this.txtboxAvg.MaxLength = 4;
            this.txtboxAvg.Name = "txtboxAvg";
            this.txtboxAvg.ReadOnly = true;
            this.txtboxAvg.Size = new System.Drawing.Size(67, 26);
            this.txtboxAvg.TabIndex = 6;
            // 
            // txtboxMaxMark
            // 
            this.txtboxMaxMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxMaxMark.Location = new System.Drawing.Point(245, 54);
            this.txtboxMaxMark.Name = "txtboxMaxMark";
            this.txtboxMaxMark.ReadOnly = true;
            this.txtboxMaxMark.Size = new System.Drawing.Size(67, 26);
            this.txtboxMaxMark.TabIndex = 5;
            // 
            // txtboxStuNum
            // 
            this.txtboxStuNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxStuNum.Location = new System.Drawing.Point(20, 56);
            this.txtboxStuNum.MaxLength = 100;
            this.txtboxStuNum.Name = "txtboxStuNum";
            this.txtboxStuNum.Size = new System.Drawing.Size(165, 26);
            this.txtboxStuNum.TabIndex = 4;
            // 
            // labMinMark
            // 
            this.labMinMark.AutoSize = true;
            this.labMinMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMinMark.Location = new System.Drawing.Point(183, 87);
            this.labMinMark.Name = "labMinMark";
            this.labMinMark.Size = new System.Drawing.Size(65, 20);
            this.labMinMark.TabIndex = 3;
            this.labMinMark.Text = "最低分：";
            // 
            // labMaxMark
            // 
            this.labMaxMark.AutoSize = true;
            this.labMaxMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMaxMark.Location = new System.Drawing.Point(183, 57);
            this.labMaxMark.Name = "labMaxMark";
            this.labMaxMark.Size = new System.Drawing.Size(65, 20);
            this.labMaxMark.TabIndex = 2;
            this.labMaxMark.Text = "最高分：";
            // 
            // labAvg
            // 
            this.labAvg.AutoSize = true;
            this.labAvg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAvg.Location = new System.Drawing.Point(183, 28);
            this.labAvg.Name = "labAvg";
            this.labAvg.Size = new System.Drawing.Size(65, 20);
            this.labAvg.TabIndex = 1;
            this.labAvg.Text = "平均分：";
            // 
            // labStuNum
            // 
            this.labStuNum.AutoSize = true;
            this.labStuNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStuNum.Location = new System.Drawing.Point(16, 27);
            this.labStuNum.Name = "labStuNum";
            this.labStuNum.Size = new System.Drawing.Size(51, 20);
            this.labStuNum.TabIndex = 0;
            this.labStuNum.Text = "学号：";
            // 
            // dgvStuInfo
            // 
            this.dgvStuInfo.AllowUserToAddRows = false;
            this.dgvStuInfo.AllowUserToDeleteRows = false;
            this.dgvStuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuno,
            this.stuname,
            this.classname,
            this.mark,
            this.bukao,
            this.departname});
            this.dgvStuInfo.Location = new System.Drawing.Point(29, 25);
            this.dgvStuInfo.Name = "dgvStuInfo";
            this.dgvStuInfo.ReadOnly = true;
            this.dgvStuInfo.RowTemplate.Height = 23;
            this.dgvStuInfo.Size = new System.Drawing.Size(656, 284);
            this.dgvStuInfo.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtboxFailNum);
            this.groupBox3.Controls.Add(this.txtboxExceNum);
            this.groupBox3.Controls.Add(this.txtboxPassNum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.butStati);
            this.groupBox3.Controls.Add(this.txtboxMinMark);
            this.groupBox3.Controls.Add(this.comboxClassStati);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtboxMaxMark);
            this.groupBox3.Controls.Add(this.labMinMark);
            this.groupBox3.Controls.Add(this.txtboxAvg);
            this.groupBox3.Controls.Add(this.labMaxMark);
            this.groupBox3.Controls.Add(this.labAvg);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(29, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 131);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分数统计与筛选";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radbutMarkDESC);
            this.groupBox4.Controls.Add(this.radbutMarkASC);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(538, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 131);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "排序";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "学生信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "选择班级";
            // 
            // comboxClassStati
            // 
            this.comboxClassStati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClassStati.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxClassStati.FormattingEnabled = true;
            this.comboxClassStati.Location = new System.Drawing.Point(10, 49);
            this.comboxClassStati.Name = "comboxClassStati";
            this.comboxClassStati.Size = new System.Drawing.Size(155, 25);
            this.comboxClassStati.TabIndex = 8;
            // 
            // txtboxMinMark
            // 
            this.txtboxMinMark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxMinMark.Location = new System.Drawing.Point(245, 84);
            this.txtboxMinMark.Name = "txtboxMinMark";
            this.txtboxMinMark.ReadOnly = true;
            this.txtboxMinMark.Size = new System.Drawing.Size(67, 26);
            this.txtboxMinMark.TabIndex = 9;
            // 
            // radbutMarkASC
            // 
            this.radbutMarkASC.AutoSize = true;
            this.radbutMarkASC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutMarkASC.Location = new System.Drawing.Point(16, 39);
            this.radbutMarkASC.Name = "radbutMarkASC";
            this.radbutMarkASC.Size = new System.Drawing.Size(125, 24);
            this.radbutMarkASC.TabIndex = 0;
            this.radbutMarkASC.TabStop = true;
            this.radbutMarkASC.Text = "按成绩升序排序";
            this.radbutMarkASC.UseVisualStyleBackColor = true;
            this.radbutMarkASC.CheckedChanged += new System.EventHandler(this.RadbutMarkASC_CheckedChanged);
            // 
            // chkboxClass
            // 
            this.chkboxClass.AutoSize = true;
            this.chkboxClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkboxClass.Location = new System.Drawing.Point(20, 35);
            this.chkboxClass.Name = "chkboxClass";
            this.chkboxClass.Size = new System.Drawing.Size(56, 24);
            this.chkboxClass.TabIndex = 4;
            this.chkboxClass.Text = "班级";
            this.chkboxClass.UseVisualStyleBackColor = true;
            // 
            // chkboxMarkLevel
            // 
            this.chkboxMarkLevel.AutoSize = true;
            this.chkboxMarkLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkboxMarkLevel.Location = new System.Drawing.Point(20, 103);
            this.chkboxMarkLevel.Name = "chkboxMarkLevel";
            this.chkboxMarkLevel.Size = new System.Drawing.Size(84, 24);
            this.chkboxMarkLevel.TabIndex = 5;
            this.chkboxMarkLevel.Text = "成绩等级";
            this.chkboxMarkLevel.UseVisualStyleBackColor = true;
            // 
            // comboxLevel
            // 
            this.comboxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxLevel.FormattingEnabled = true;
            this.comboxLevel.Location = new System.Drawing.Point(20, 135);
            this.comboxLevel.Name = "comboxLevel";
            this.comboxLevel.Size = new System.Drawing.Size(165, 28);
            this.comboxLevel.TabIndex = 6;
            // 
            // radbutMarkDESC
            // 
            this.radbutMarkDESC.AutoSize = true;
            this.radbutMarkDESC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutMarkDESC.Location = new System.Drawing.Point(16, 78);
            this.radbutMarkDESC.Name = "radbutMarkDESC";
            this.radbutMarkDESC.Size = new System.Drawing.Size(125, 24);
            this.radbutMarkDESC.TabIndex = 1;
            this.radbutMarkDESC.TabStop = true;
            this.radbutMarkDESC.Text = "按成绩降序排序";
            this.radbutMarkDESC.UseVisualStyleBackColor = true;
            this.radbutMarkDESC.CheckedChanged += new System.EventHandler(this.RadbutMarkDESC_CheckedChanged);
            // 
            // butCheck
            // 
            this.butCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCheck.Location = new System.Drawing.Point(110, 91);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 30);
            this.butCheck.TabIndex = 5;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(81, 130);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(104, 30);
            this.butRecovery.TabIndex = 6;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // butStati
            // 
            this.butStati.Location = new System.Drawing.Point(90, 84);
            this.butStati.Name = "butStati";
            this.butStati.Size = new System.Drawing.Size(75, 30);
            this.butStati.TabIndex = 10;
            this.butStati.Text = "确定";
            this.butStati.UseVisualStyleBackColor = true;
            this.butStati.Click += new System.EventHandler(this.ButStati_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(318, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "不及格人数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(318, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "及格人数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(318, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "成绩优秀人数：";
            // 
            // txtboxPassNum
            // 
            this.txtboxPassNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxPassNum.Location = new System.Drawing.Point(424, 25);
            this.txtboxPassNum.Name = "txtboxPassNum";
            this.txtboxPassNum.ReadOnly = true;
            this.txtboxPassNum.Size = new System.Drawing.Size(67, 26);
            this.txtboxPassNum.TabIndex = 14;
            // 
            // txtboxExceNum
            // 
            this.txtboxExceNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxExceNum.Location = new System.Drawing.Point(424, 54);
            this.txtboxExceNum.Name = "txtboxExceNum";
            this.txtboxExceNum.ReadOnly = true;
            this.txtboxExceNum.Size = new System.Drawing.Size(67, 26);
            this.txtboxExceNum.TabIndex = 15;
            // 
            // txtboxFailNum
            // 
            this.txtboxFailNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxFailNum.Location = new System.Drawing.Point(424, 84);
            this.txtboxFailNum.Name = "txtboxFailNum";
            this.txtboxFailNum.ReadOnly = true;
            this.txtboxFailNum.Size = new System.Drawing.Size(67, 26);
            this.txtboxFailNum.TabIndex = 16;
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
            this.classname.HeaderText = "班级";
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
            // departname
            // 
            this.departname.DataPropertyName = "studepart";
            this.departname.HeaderText = "学生院系";
            this.departname.Name = "departname";
            this.departname.ReadOnly = true;
            // 
            // frmTeachStudInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvStuInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeachStudInfor";
            this.Size = new System.Drawing.Size(930, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxAvg;
        private System.Windows.Forms.TextBox txtboxMaxMark;
        private System.Windows.Forms.TextBox txtboxStuNum;
        private System.Windows.Forms.Label labMinMark;
        private System.Windows.Forms.Label labMaxMark;
        private System.Windows.Forms.Label labAvg;
        private System.Windows.Forms.Label labStuNum;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.DataGridView dgvStuInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboxClassStati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxMinMark;
        private System.Windows.Forms.ComboBox comboxLevel;
        private System.Windows.Forms.CheckBox chkboxMarkLevel;
        private System.Windows.Forms.CheckBox chkboxClass;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.RadioButton radbutMarkDESC;
        private System.Windows.Forms.RadioButton radbutMarkASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukao;
        private System.Windows.Forms.DataGridViewTextBoxColumn departname;
        private System.Windows.Forms.TextBox txtboxFailNum;
        private System.Windows.Forms.TextBox txtboxExceNum;
        private System.Windows.Forms.TextBox txtboxPassNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butStati;
    }
}
