namespace EduAdminSys.frmStudt
{
    partial class frmStudMark
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxBukao = new System.Windows.Forms.CheckBox();
            this.butEnter1 = new System.Windows.Forms.Button();
            this.chkboxPass = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butEnter2 = new System.Windows.Forms.Button();
            this.radbutFail = new System.Windows.Forms.RadioButton();
            this.radbutPass = new System.Windows.Forms.RadioButton();
            this.radbutGood = new System.Windows.Forms.RadioButton();
            this.radbutExcellent = new System.Windows.Forms.RadioButton();
            this.butCancel2 = new System.Windows.Forms.Button();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMarkTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbMarkTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStuMark = new System.Windows.Forms.DataGridView();
            this.courseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuMark)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkboxBukao);
            this.groupBox1.Controls.Add(this.butEnter1);
            this.groupBox1.Controls.Add(this.chkboxPass);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(702, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // chkboxBukao
            // 
            this.chkboxBukao.AutoSize = true;
            this.chkboxBukao.Location = new System.Drawing.Point(35, 50);
            this.chkboxBukao.Name = "chkboxBukao";
            this.chkboxBukao.Size = new System.Drawing.Size(99, 21);
            this.chkboxBukao.TabIndex = 2;
            this.chkboxBukao.Text = "补考课程分数";
            this.chkboxBukao.UseVisualStyleBackColor = true;
            // 
            // butEnter1
            // 
            this.butEnter1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter1.Location = new System.Drawing.Point(130, 71);
            this.butEnter1.Name = "butEnter1";
            this.butEnter1.Size = new System.Drawing.Size(75, 30);
            this.butEnter1.TabIndex = 2;
            this.butEnter1.Text = "确认";
            this.butEnter1.UseVisualStyleBackColor = true;
            this.butEnter1.Click += new System.EventHandler(this.ButEnter1_Click);
            // 
            // chkboxPass
            // 
            this.chkboxPass.AutoSize = true;
            this.chkboxPass.Location = new System.Drawing.Point(35, 23);
            this.chkboxPass.Name = "chkboxPass";
            this.chkboxPass.Size = new System.Drawing.Size(99, 21);
            this.chkboxPass.TabIndex = 0;
            this.chkboxPass.Text = "通过课程分数";
            this.chkboxPass.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butEnter2);
            this.groupBox2.Controls.Add(this.radbutFail);
            this.groupBox2.Controls.Add(this.butCancel2);
            this.groupBox2.Controls.Add(this.radbutPass);
            this.groupBox2.Controls.Add(this.radbutGood);
            this.groupBox2.Controls.Add(this.radbutExcellent);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(702, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分数层级筛选";
            // 
            // butEnter2
            // 
            this.butEnter2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter2.Location = new System.Drawing.Point(130, 118);
            this.butEnter2.Name = "butEnter2";
            this.butEnter2.Size = new System.Drawing.Size(75, 30);
            this.butEnter2.TabIndex = 4;
            this.butEnter2.Text = "确认";
            this.butEnter2.UseVisualStyleBackColor = true;
            this.butEnter2.Click += new System.EventHandler(this.ButEnter2_Click);
            // 
            // radbutFail
            // 
            this.radbutFail.AutoSize = true;
            this.radbutFail.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutFail.Location = new System.Drawing.Point(35, 93);
            this.radbutFail.Name = "radbutFail";
            this.radbutFail.Size = new System.Drawing.Size(69, 24);
            this.radbutFail.TabIndex = 3;
            this.radbutFail.TabStop = true;
            this.radbutFail.Text = "不及格";
            this.radbutFail.UseVisualStyleBackColor = true;
            // 
            // radbutPass
            // 
            this.radbutPass.AutoSize = true;
            this.radbutPass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutPass.Location = new System.Drawing.Point(35, 69);
            this.radbutPass.Name = "radbutPass";
            this.radbutPass.Size = new System.Drawing.Size(107, 24);
            this.radbutPass.TabIndex = 2;
            this.radbutPass.TabStop = true;
            this.radbutPass.Text = "及格(60~79)";
            this.radbutPass.UseVisualStyleBackColor = true;
            // 
            // radbutGood
            // 
            this.radbutGood.AutoSize = true;
            this.radbutGood.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutGood.Location = new System.Drawing.Point(35, 45);
            this.radbutGood.Name = "radbutGood";
            this.radbutGood.Size = new System.Drawing.Size(107, 24);
            this.radbutGood.TabIndex = 1;
            this.radbutGood.TabStop = true;
            this.radbutGood.Text = "良好(80~89)";
            this.radbutGood.UseVisualStyleBackColor = true;
            // 
            // radbutExcellent
            // 
            this.radbutExcellent.AutoSize = true;
            this.radbutExcellent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutExcellent.Location = new System.Drawing.Point(35, 21);
            this.radbutExcellent.Name = "radbutExcellent";
            this.radbutExcellent.Size = new System.Drawing.Size(115, 24);
            this.radbutExcellent.TabIndex = 0;
            this.radbutExcellent.TabStop = true;
            this.radbutExcellent.Text = "优秀(90~100)";
            this.radbutExcellent.UseVisualStyleBackColor = true;
            // 
            // butCancel2
            // 
            this.butCancel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butCancel2.Location = new System.Drawing.Point(6, 118);
            this.butCancel2.Name = "butCancel2";
            this.butCancel2.Size = new System.Drawing.Size(110, 30);
            this.butCancel2.TabIndex = 5;
            this.butCancel2.Text = "恢复成绩表";
            this.butCancel2.UseVisualStyleBackColor = true;
            this.butCancel2.Click += new System.EventHandler(this.ButCancel2_Click);
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMarkBindingSource
            // 
            this.tbMarkBindingSource.DataMember = "tbMark";
            this.tbMarkBindingSource.DataSource = this.sQLDataSet;
            // 
            // tbMarkTableAdapter
            // 
            this.tbMarkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = null;
            this.tableAdapterManager.tbCourseTableAdapter = null;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMarkTableAdapter = this.tbMarkTableAdapter;
            this.tableAdapterManager.tbSelectTableAdapter = null;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "分数信息";
            // 
            // dgvStuMark
            // 
            this.dgvStuMark.AllowUserToAddRows = false;
            this.dgvStuMark.AllowUserToDeleteRows = false;
            this.dgvStuMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseno,
            this.coursename,
            this.mark,
            this.credit,
            this.departname,
            this.teachname,
            this.bukao});
            this.dgvStuMark.Location = new System.Drawing.Point(32, 28);
            this.dgvStuMark.Name = "dgvStuMark";
            this.dgvStuMark.ReadOnly = true;
            this.dgvStuMark.RowTemplate.Height = 23;
            this.dgvStuMark.Size = new System.Drawing.Size(642, 410);
            this.dgvStuMark.TabIndex = 5;
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
            // mark
            // 
            this.mark.DataPropertyName = "mark";
            this.mark.HeaderText = "成绩";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // departname
            // 
            this.departname.DataPropertyName = "departname";
            this.departname.HeaderText = "所属学院";
            this.departname.Name = "departname";
            this.departname.ReadOnly = true;
            // 
            // teachname
            // 
            this.teachname.DataPropertyName = "teachname";
            this.teachname.HeaderText = "任课教师";
            this.teachname.Name = "teachname";
            this.teachname.ReadOnly = true;
            // 
            // bukao
            // 
            this.bukao.DataPropertyName = "bukao";
            this.bukao.HeaderText = "补考成绩";
            this.bukao.Name = "bukao";
            this.bukao.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(702, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "提示：补考成绩显示为-1代表无需补考或尚未补考";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(702, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 83);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "排序";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(21, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "按成绩升序";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(21, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "按成绩降序";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // frmStudMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStuMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudMark";
            this.Size = new System.Drawing.Size(930, 463);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuMark)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxBukao;
        private System.Windows.Forms.CheckBox chkboxPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbutFail;
        private System.Windows.Forms.RadioButton radbutPass;
        private System.Windows.Forms.RadioButton radbutGood;
        private System.Windows.Forms.RadioButton radbutExcellent;
        private System.Windows.Forms.Button butEnter1;
        private System.Windows.Forms.Button butCancel2;
        private System.Windows.Forms.Button butEnter2;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbMarkBindingSource;
        private SQLDataSetTableAdapters.tbMarkTableAdapter tbMarkTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStuMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn departname;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
