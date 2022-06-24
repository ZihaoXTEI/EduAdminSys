using System;
using System.Windows.Forms;

namespace EduAdminSys.frmMang
{
    partial class frmMangClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClassTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbClassTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvMangClass = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbutLess15 = new System.Windows.Forms.RadioButton();
            this.radbutNULL = new System.Windows.Forms.RadioButton();
            this.radbutRecovery = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butAllClassSele = new System.Windows.Forms.Button();
            this.butAllClassOpen = new System.Windows.Forms.Button();
            this.butDeleteStunum = new System.Windows.Forms.Button();
            this.butDeleteTeachNo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.butClassOpen = new System.Windows.Forms.Button();
            this.butClassSele = new System.Windows.Forms.Button();
            this.comboxTeachNo = new System.Windows.Forms.ComboBox();
            this.butUpate = new System.Windows.Forms.Button();
            this.txtboxClassname = new System.Windows.Forms.TextBox();
            this.txtboxClassno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangClass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级信息管理";
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClassBindingSource
            // 
            this.tbClassBindingSource.DataMember = "tbClass";
            this.tbClassBindingSource.DataSource = this.sQLDataSet;
            // 
            // tbClassTableAdapter
            // 
            this.tbClassTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = this.tbClassTableAdapter;
            this.tableAdapterManager.tbCourseTableAdapter = null;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMarkTableAdapter = null;
            this.tableAdapterManager.tbSelectTableAdapter = null;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvMangClass
            // 
            this.dgvMangClass.AllowUserToAddRows = false;
            this.dgvMangClass.AllowUserToDeleteRows = false;
            this.dgvMangClass.AutoGenerateColumns = false;
            this.dgvMangClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvMangClass.DataSource = this.tbClassBindingSource;
            this.dgvMangClass.Location = new System.Drawing.Point(18, 36);
            this.dgvMangClass.Name = "dgvMangClass";
            this.dgvMangClass.ReadOnly = true;
            this.dgvMangClass.RowTemplate.Height = 23;
            this.dgvMangClass.Size = new System.Drawing.Size(521, 395);
            this.dgvMangClass.TabIndex = 2;
            this.dgvMangClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMangClass_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbutLess15);
            this.groupBox1.Controls.Add(this.radbutNULL);
            this.groupBox1.Controls.Add(this.radbutRecovery);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(567, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // radbutLess15
            // 
            this.radbutLess15.AutoSize = true;
            this.radbutLess15.Location = new System.Drawing.Point(29, 59);
            this.radbutLess15.Name = "radbutLess15";
            this.radbutLess15.Size = new System.Drawing.Size(148, 21);
            this.radbutLess15.TabIndex = 2;
            this.radbutLess15.TabStop = true;
            this.radbutLess15.Text = "查看人数低于15的班级";
            this.radbutLess15.UseVisualStyleBackColor = true;
            this.radbutLess15.CheckedChanged += new System.EventHandler(this.RadbutLess15_CheckedChanged);
            // 
            // radbutNULL
            // 
            this.radbutNULL.AutoSize = true;
            this.radbutNULL.Location = new System.Drawing.Point(29, 31);
            this.radbutNULL.Name = "radbutNULL";
            this.radbutNULL.Size = new System.Drawing.Size(158, 21);
            this.radbutNULL.TabIndex = 1;
            this.radbutNULL.TabStop = true;
            this.radbutNULL.Text = "查看未被选择任课的班级";
            this.radbutNULL.UseVisualStyleBackColor = true;
            this.radbutNULL.CheckedChanged += new System.EventHandler(this.RadbutNULL_CheckedChanged);
            // 
            // radbutRecovery
            // 
            this.radbutRecovery.AutoSize = true;
            this.radbutRecovery.Location = new System.Drawing.Point(233, 31);
            this.radbutRecovery.Name = "radbutRecovery";
            this.radbutRecovery.Size = new System.Drawing.Size(86, 21);
            this.radbutRecovery.TabIndex = 0;
            this.radbutRecovery.TabStop = true;
            this.radbutRecovery.Text = "恢复信息表";
            this.radbutRecovery.UseVisualStyleBackColor = true;
            this.radbutRecovery.CheckedChanged += new System.EventHandler(this.RadbutRecovery_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.butClassOpen);
            this.groupBox2.Controls.Add(this.butClassSele);
            this.groupBox2.Controls.Add(this.comboxTeachNo);
            this.groupBox2.Controls.Add(this.butUpate);
            this.groupBox2.Controls.Add(this.txtboxClassname);
            this.groupBox2.Controls.Add(this.txtboxClassno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(567, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 333);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butAllClassSele);
            this.groupBox3.Controls.Add(this.butAllClassOpen);
            this.groupBox3.Controls.Add(this.butDeleteStunum);
            this.groupBox3.Controls.Add(this.butDeleteTeachNo);
            this.groupBox3.Location = new System.Drawing.Point(6, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 123);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "批量操作";
            // 
            // butAllClassSele
            // 
            this.butAllClassSele.Location = new System.Drawing.Point(12, 27);
            this.butAllClassSele.Name = "butAllClassSele";
            this.butAllClassSele.Size = new System.Drawing.Size(153, 23);
            this.butAllClassSele.TabIndex = 14;
            this.butAllClassSele.Text = "设置所有班级为选课状态";
            this.butAllClassSele.UseVisualStyleBackColor = true;
            this.butAllClassSele.Click += new System.EventHandler(this.ButAllClassSele_Click);
            // 
            // butAllClassOpen
            // 
            this.butAllClassOpen.Location = new System.Drawing.Point(12, 59);
            this.butAllClassOpen.Name = "butAllClassOpen";
            this.butAllClassOpen.Size = new System.Drawing.Size(236, 23);
            this.butAllClassOpen.TabIndex = 13;
            this.butAllClassOpen.Text = "将所有符合要求班级设为开课状态";
            this.butAllClassOpen.UseVisualStyleBackColor = true;
            this.butAllClassOpen.Click += new System.EventHandler(this.ButAllClassOpen_Click);
            // 
            // butDeleteStunum
            // 
            this.butDeleteStunum.Location = new System.Drawing.Point(184, 91);
            this.butDeleteStunum.Name = "butDeleteStunum";
            this.butDeleteStunum.Size = new System.Drawing.Size(118, 23);
            this.butDeleteStunum.TabIndex = 8;
            this.butDeleteStunum.Text = "清空所有班级人数信息";
            this.butDeleteStunum.UseVisualStyleBackColor = true;
            this.butDeleteStunum.Click += new System.EventHandler(this.ButDeleteStunum_Click);
            // 
            // butDeleteTeachNo
            // 
            this.butDeleteTeachNo.Location = new System.Drawing.Point(12, 91);
            this.butDeleteTeachNo.Name = "butDeleteTeachNo";
            this.butDeleteTeachNo.Size = new System.Drawing.Size(118, 23);
            this.butDeleteTeachNo.TabIndex = 7;
            this.butDeleteTeachNo.Text = "清空所有教师信息";
            this.butDeleteTeachNo.UseVisualStyleBackColor = true;
            this.butDeleteTeachNo.Click += new System.EventHandler(this.ButDeleteTeachNo_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(201, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "逻辑删除该班级";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // butClassOpen
            // 
            this.butClassOpen.Location = new System.Drawing.Point(29, 136);
            this.butClassOpen.Name = "butClassOpen";
            this.butClassOpen.Size = new System.Drawing.Size(153, 23);
            this.butClassOpen.TabIndex = 11;
            this.butClassOpen.Text = "设置班级为开课状态";
            this.butClassOpen.UseVisualStyleBackColor = true;
            this.butClassOpen.Click += new System.EventHandler(this.ButClassOpen_Click);
            // 
            // butClassSele
            // 
            this.butClassSele.Location = new System.Drawing.Point(29, 166);
            this.butClassSele.Name = "butClassSele";
            this.butClassSele.Size = new System.Drawing.Size(153, 23);
            this.butClassSele.TabIndex = 10;
            this.butClassSele.Text = "设置班级为选课状态";
            this.butClassSele.UseVisualStyleBackColor = true;
            this.butClassSele.Click += new System.EventHandler(this.ButClassSele_Click);
            // 
            // comboxTeachNo
            // 
            this.comboxTeachNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTeachNo.FormattingEnabled = true;
            this.comboxTeachNo.Location = new System.Drawing.Point(124, 96);
            this.comboxTeachNo.Name = "comboxTeachNo";
            this.comboxTeachNo.Size = new System.Drawing.Size(195, 25);
            this.comboxTeachNo.TabIndex = 9;
            // 
            // butUpate
            // 
            this.butUpate.Location = new System.Drawing.Point(244, 136);
            this.butUpate.Name = "butUpate";
            this.butUpate.Size = new System.Drawing.Size(75, 23);
            this.butUpate.TabIndex = 6;
            this.butUpate.Text = "确定更改";
            this.butUpate.UseVisualStyleBackColor = true;
            this.butUpate.Click += new System.EventHandler(this.ButUpate_Click);
            // 
            // txtboxClassname
            // 
            this.txtboxClassname.Location = new System.Drawing.Point(124, 66);
            this.txtboxClassname.Name = "txtboxClassname";
            this.txtboxClassname.ReadOnly = true;
            this.txtboxClassname.Size = new System.Drawing.Size(195, 23);
            this.txtboxClassname.TabIndex = 4;
            // 
            // txtboxClassno
            // 
            this.txtboxClassno.Location = new System.Drawing.Point(124, 28);
            this.txtboxClassno.Name = "txtboxClassno";
            this.txtboxClassno.ReadOnly = true;
            this.txtboxClassno.Size = new System.Drawing.Size(195, 23);
            this.txtboxClassno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "修改或加入老师";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 17);
            this.label.TabIndex = 1;
            this.label.Text = "班级名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "班级编号：";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "classno";
            this.dataGridViewTextBoxColumn1.HeaderText = "班级编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "classname";
            this.dataGridViewTextBoxColumn2.HeaderText = "班级名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "teachno";
            this.dataGridViewTextBoxColumn7.HeaderText = "教师编号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "states";
            this.dataGridViewTextBoxColumn3.HeaderText = "班级状态";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stunum";
            this.dataGridViewTextBoxColumn4.HeaderText = "班级人数";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "courseno";
            this.dataGridViewTextBoxColumn5.HeaderText = "课程编号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "departno";
            this.dataGridViewTextBoxColumn6.HeaderText = "院校编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frmMangClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMangClass);
            this.Controls.Add(this.label1);
            this.Name = "frmMangClass";
            this.Size = new System.Drawing.Size(930, 460);
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangClass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbClassBindingSource;
        private SQLDataSetTableAdapters.tbClassTableAdapter tbClassTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvMangClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbutNULL;
        private System.Windows.Forms.RadioButton radbutRecovery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butAllClassSele;
        private System.Windows.Forms.Button butAllClassOpen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butClassOpen;
        private System.Windows.Forms.Button butClassSele;
        private System.Windows.Forms.ComboBox comboxTeachNo;
        private System.Windows.Forms.Button butDeleteStunum;
        private System.Windows.Forms.Button butDeleteTeachNo;
        private System.Windows.Forms.Button butUpate;
        private System.Windows.Forms.TextBox txtboxClassname;
        private System.Windows.Forms.TextBox txtboxClassno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbutLess15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
