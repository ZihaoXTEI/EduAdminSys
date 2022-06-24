namespace EduAdminSys.frmMang
{
    partial class frmInforQueryStud
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
            this.labTabeName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.radbutName = new System.Windows.Forms.RadioButton();
            this.radbutNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboxSex = new System.Windows.Forms.ComboBox();
            this.chkboxSex = new System.Windows.Forms.CheckBox();
            this.comboxDepart = new System.Windows.Forms.ComboBox();
            this.chkboxDepart = new System.Windows.Forms.CheckBox();
            this.chkboxAge = new System.Windows.Forms.CheckBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.butRecovery = new System.Windows.Forms.Button();
            this.comboxAge = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new EduAdminSys.DataSet1();
            this.tbStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStudentTableAdapter = new EduAdminSys.DataSet1TableAdapters.tbStudentTableAdapter();
            this.tableAdapterManager = new EduAdminSys.DataSet1TableAdapters.TableAdapterManager();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstud = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstud)).BeginInit();
            this.SuspendLayout();
            // 
            // labTabeName
            // 
            this.labTabeName.AutoSize = true;
            this.labTabeName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTabeName.Location = new System.Drawing.Point(34, 5);
            this.labTabeName.Name = "labTabeName";
            this.labTabeName.Size = new System.Drawing.Size(65, 20);
            this.labTabeName.TabIndex = 0;
            this.labTabeName.Text = "学生信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.radbutName);
            this.groupBox1.Controls.Add(this.radbutNo);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(717, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(109, 97);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 23);
            this.butCheck.TabIndex = 4;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(12, 51);
            this.txtboxCheck.MaxLength = 25;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(172, 23);
            this.txtboxCheck.TabIndex = 2;
            // 
            // radbutName
            // 
            this.radbutName.AutoSize = true;
            this.radbutName.Location = new System.Drawing.Point(98, 24);
            this.radbutName.Name = "radbutName";
            this.radbutName.Size = new System.Drawing.Size(86, 21);
            this.radbutName.TabIndex = 1;
            this.radbutName.Text = "按姓名查找";
            this.radbutName.UseVisualStyleBackColor = true;
            // 
            // radbutNo
            // 
            this.radbutNo.AutoSize = true;
            this.radbutNo.Checked = true;
            this.radbutNo.Location = new System.Drawing.Point(7, 24);
            this.radbutNo.Name = "radbutNo";
            this.radbutNo.Size = new System.Drawing.Size(86, 21);
            this.radbutNo.TabIndex = 0;
            this.radbutNo.TabStop = true;
            this.radbutNo.Text = "按学号查找";
            this.radbutNo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboxSex);
            this.groupBox2.Controls.Add(this.chkboxSex);
            this.groupBox2.Controls.Add(this.comboxDepart);
            this.groupBox2.Controls.Add(this.chkboxDepart);
            this.groupBox2.Controls.Add(this.chkboxAge);
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Controls.Add(this.comboxAge);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(717, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // comboxSex
            // 
            this.comboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSex.FormattingEnabled = true;
            this.comboxSex.Location = new System.Drawing.Point(12, 166);
            this.comboxSex.Name = "comboxSex";
            this.comboxSex.Size = new System.Drawing.Size(172, 25);
            this.comboxSex.TabIndex = 11;
            // 
            // chkboxSex
            // 
            this.chkboxSex.AutoSize = true;
            this.chkboxSex.Location = new System.Drawing.Point(12, 139);
            this.chkboxSex.Name = "chkboxSex";
            this.chkboxSex.Size = new System.Drawing.Size(51, 21);
            this.chkboxSex.TabIndex = 10;
            this.chkboxSex.Text = "性别";
            this.chkboxSex.UseVisualStyleBackColor = true;
            // 
            // comboxDepart
            // 
            this.comboxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepart.FormattingEnabled = true;
            this.comboxDepart.Location = new System.Drawing.Point(12, 108);
            this.comboxDepart.Name = "comboxDepart";
            this.comboxDepart.Size = new System.Drawing.Size(172, 25);
            this.comboxDepart.TabIndex = 9;
            // 
            // chkboxDepart
            // 
            this.chkboxDepart.AutoSize = true;
            this.chkboxDepart.Location = new System.Drawing.Point(12, 81);
            this.chkboxDepart.Name = "chkboxDepart";
            this.chkboxDepart.Size = new System.Drawing.Size(75, 21);
            this.chkboxDepart.TabIndex = 8;
            this.chkboxDepart.Text = "院系名称";
            this.chkboxDepart.UseVisualStyleBackColor = true;
            // 
            // chkboxAge
            // 
            this.chkboxAge.AutoSize = true;
            this.chkboxAge.Location = new System.Drawing.Point(12, 23);
            this.chkboxAge.Name = "chkboxAge";
            this.chkboxAge.Size = new System.Drawing.Size(75, 21);
            this.chkboxAge.TabIndex = 7;
            this.chkboxAge.Text = "学生年龄";
            this.chkboxAge.UseVisualStyleBackColor = true;
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(89, 197);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(95, 28);
            this.butScreen.TabIndex = 4;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(89, 231);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(95, 28);
            this.butRecovery.TabIndex = 6;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // comboxAge
            // 
            this.comboxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAge.FormattingEnabled = true;
            this.comboxAge.Location = new System.Drawing.Point(12, 50);
            this.comboxAge.Name = "comboxAge";
            this.comboxAge.Size = new System.Drawing.Size(172, 25);
            this.comboxAge.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStudentBindingSource
            // 
            this.tbStudentBindingSource.DataMember = "tbStudent";
            this.tbStudentBindingSource.DataSource = this.dataSet1;
            // 
            // tbStudentTableAdapter
            // 
            this.tbStudentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbStudentTableAdapter = this.tbStudentTableAdapter;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "departno";
            this.dataGridViewTextBoxColumn4.HeaderText = "院系编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvstud
            // 
            this.dgvstud.AllowUserToAddRows = false;
            this.dgvstud.AllowUserToDeleteRows = false;
            this.dgvstud.AutoGenerateColumns = false;
            this.dgvstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvstud.DataSource = this.tbStudentBindingSource;
            this.dgvstud.Location = new System.Drawing.Point(38, 28);
            this.dgvstud.Name = "dgvstud";
            this.dgvstud.ReadOnly = true;
            this.dgvstud.RowTemplate.Height = 23;
            this.dgvstud.Size = new System.Drawing.Size(655, 394);
            this.dgvstud.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stuno";
            this.dataGridViewTextBoxColumn1.HeaderText = "学生学号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stuname";
            this.dataGridViewTextBoxColumn2.HeaderText = "学生姓名";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn5.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "birth";
            this.dataGridViewTextBoxColumn6.HeaderText = "出生日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frmInforQueryStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvstud);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTabeName);
            this.Name = "frmInforQueryStud";
            this.Size = new System.Drawing.Size(940, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTabeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbutName;
        private System.Windows.Forms.RadioButton radbutNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.ComboBox comboxAge;
        private System.Windows.Forms.Button butRecovery;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbStudentBindingSource;
        private DataSet1TableAdapters.tbStudentTableAdapter tbStudentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.ComboBox comboxSex;
        private System.Windows.Forms.CheckBox chkboxSex;
        private System.Windows.Forms.ComboBox comboxDepart;
        private System.Windows.Forms.CheckBox chkboxDepart;
        private System.Windows.Forms.CheckBox chkboxAge;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvstud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
