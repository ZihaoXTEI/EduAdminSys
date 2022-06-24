namespace EduAdminSys.frmMang
{
    partial class frmInforQueryTeach
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
            this.labTableName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textboxNo = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.radbutName = new System.Windows.Forms.RadioButton();
            this.radbutNo = new System.Windows.Forms.RadioButton();
            this.butCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.radbutSex = new System.Windows.Forms.RadioButton();
            this.comboxScreen = new System.Windows.Forms.ComboBox();
            this.radButDeprat = new System.Windows.Forms.RadioButton();
            this.radButType = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new EduAdminSys.DataSet1();
            this.tbTeachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTeachTableAdapter = new EduAdminSys.DataSet1TableAdapters.tbTeachTableAdapter();
            this.tableAdapterManager = new EduAdminSys.DataSet1TableAdapters.TableAdapterManager();
            this.dgvteach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butRecovery = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteach)).BeginInit();
            this.SuspendLayout();
            // 
            // labTableName
            // 
            this.labTableName.AutoSize = true;
            this.labTableName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTableName.Location = new System.Drawing.Point(11, 7);
            this.labTableName.Name = "labTableName";
            this.labTableName.Size = new System.Drawing.Size(65, 20);
            this.labTableName.TabIndex = 0;
            this.labTableName.Text = "教师信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxNo);
            this.groupBox1.Controls.Add(this.textboxName);
            this.groupBox1.Controls.Add(this.radbutName);
            this.groupBox1.Controls.Add(this.radbutNo);
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(763, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // textboxNo
            // 
            this.textboxNo.Location = new System.Drawing.Point(7, 47);
            this.textboxNo.MaxLength = 12;
            this.textboxNo.Name = "textboxNo";
            this.textboxNo.Size = new System.Drawing.Size(143, 23);
            this.textboxNo.TabIndex = 8;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(7, 100);
            this.textboxName.MaxLength = 25;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(143, 23);
            this.textboxName.TabIndex = 7;
            // 
            // radbutName
            // 
            this.radbutName.AutoSize = true;
            this.radbutName.Location = new System.Drawing.Point(12, 72);
            this.radbutName.Name = "radbutName";
            this.radbutName.Size = new System.Drawing.Size(98, 21);
            this.radbutName.TabIndex = 6;
            this.radbutName.Text = "按姓名查找：";
            this.radbutName.UseVisualStyleBackColor = true;
            // 
            // radbutNo
            // 
            this.radbutNo.AutoSize = true;
            this.radbutNo.Checked = true;
            this.radbutNo.Location = new System.Drawing.Point(12, 19);
            this.radbutNo.Name = "radbutNo";
            this.radbutNo.Size = new System.Drawing.Size(98, 21);
            this.radbutNo.TabIndex = 5;
            this.radbutNo.TabStop = true;
            this.radbutNo.Text = "按工号查找：";
            this.radbutNo.UseVisualStyleBackColor = true;
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(75, 134);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 25);
            this.butCheck.TabIndex = 0;
            this.butCheck.Text = "确认";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.radbutSex);
            this.groupBox2.Controls.Add(this.comboxScreen);
            this.groupBox2.Controls.Add(this.radButDeprat);
            this.groupBox2.Controls.Add(this.radButType);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(763, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(75, 145);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 25);
            this.butScreen.TabIndex = 4;
            this.butScreen.Text = "确认";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // radbutSex
            // 
            this.radbutSex.AutoSize = true;
            this.radbutSex.Location = new System.Drawing.Point(12, 78);
            this.radbutSex.Name = "radbutSex";
            this.radbutSex.Size = new System.Drawing.Size(50, 21);
            this.radbutSex.TabIndex = 3;
            this.radbutSex.Text = "性别";
            this.radbutSex.UseVisualStyleBackColor = true;
            this.radbutSex.CheckedChanged += new System.EventHandler(this.RadbutSex_CheckedChanged);
            // 
            // comboxScreen
            // 
            this.comboxScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxScreen.FormattingEnabled = true;
            this.comboxScreen.Location = new System.Drawing.Point(7, 105);
            this.comboxScreen.Name = "comboxScreen";
            this.comboxScreen.Size = new System.Drawing.Size(144, 25);
            this.comboxScreen.TabIndex = 2;
            // 
            // radButDeprat
            // 
            this.radButDeprat.AutoSize = true;
            this.radButDeprat.Location = new System.Drawing.Point(12, 50);
            this.radButDeprat.Name = "radButDeprat";
            this.radButDeprat.Size = new System.Drawing.Size(50, 21);
            this.radButDeprat.TabIndex = 1;
            this.radButDeprat.Text = "院系";
            this.radButDeprat.UseVisualStyleBackColor = true;
            this.radButDeprat.CheckedChanged += new System.EventHandler(this.RadButDeprat_CheckedChanged);
            // 
            // radButType
            // 
            this.radButType.AutoSize = true;
            this.radButType.Checked = true;
            this.radButType.Location = new System.Drawing.Point(12, 22);
            this.radButType.Name = "radButType";
            this.radButType.Size = new System.Drawing.Size(74, 21);
            this.radButType.TabIndex = 0;
            this.radButType.TabStop = true;
            this.radButType.Text = "教师职称";
            this.radButType.UseVisualStyleBackColor = true;
            this.radButType.CheckedChanged += new System.EventHandler(this.RadButType_CheckedChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTeachBindingSource
            // 
            this.tbTeachBindingSource.DataMember = "tbTeach";
            this.tbTeachBindingSource.DataSource = this.dataSet1;
            // 
            // tbTeachTableAdapter
            // 
            this.tbTeachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = null;
            this.tableAdapterManager.tbCourseTableAdapter = null;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMarkTableAdapter = null;
            this.tableAdapterManager.tbSelectTableAdapter = null;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = this.tbTeachTableAdapter;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvteach
            // 
            this.dgvteach.AllowUserToAddRows = false;
            this.dgvteach.AllowUserToDeleteRows = false;
            this.dgvteach.AutoGenerateColumns = false;
            this.dgvteach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvteach.DataSource = this.tbTeachBindingSource;
            this.dgvteach.Location = new System.Drawing.Point(15, 30);
            this.dgvteach.Name = "dgvteach";
            this.dgvteach.ReadOnly = true;
            this.dgvteach.RowTemplate.Height = 23;
            this.dgvteach.Size = new System.Drawing.Size(734, 402);
            this.dgvteach.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "teachno";
            this.dataGridViewTextBoxColumn1.HeaderText = "教师工号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teachname";
            this.dataGridViewTextBoxColumn2.HeaderText = "教师姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "departno";
            this.dataGridViewTextBoxColumn4.HeaderText = "院系编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn5.HeaderText = "职称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn6.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "birth";
            this.dataGridViewTextBoxColumn7.HeaderText = "出生日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn8.HeaderText = "基本工资";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(779, 404);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(122, 28);
            this.butRecovery.TabIndex = 5;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // frmInforQueryTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butRecovery);
            this.Controls.Add(this.dgvteach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTableName);
            this.Name = "frmInforQueryTeach";
            this.Size = new System.Drawing.Size(939, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTeachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTableName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbutName;
        private System.Windows.Forms.RadioButton radbutNo;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.ComboBox comboxScreen;
        private System.Windows.Forms.RadioButton radButDeprat;
        private System.Windows.Forms.RadioButton radButType;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbTeachBindingSource;
        private DataSet1TableAdapters.tbTeachTableAdapter tbTeachTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvteach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.RadioButton radbutSex;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.TextBox textboxNo;
    }
}
