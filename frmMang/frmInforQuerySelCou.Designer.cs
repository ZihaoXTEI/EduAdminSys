namespace EduAdminSys.frmMang
{
    partial class frmInforQuerySelCou
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.radbutTeachNo = new System.Windows.Forms.RadioButton();
            this.radbutStuNo = new System.Windows.Forms.RadioButton();
            this.radbutClass = new System.Windows.Forms.RadioButton();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSelectTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbSelectTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvselect = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.comboxDepart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butRecovery = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselect)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选课信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.radbutTeachNo);
            this.groupBox1.Controls.Add(this.radbutStuNo);
            this.groupBox1.Controls.Add(this.radbutClass);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(550, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(245, 113);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 25);
            this.butCheck.TabIndex = 4;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(32, 114);
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(171, 23);
            this.txtboxCheck.TabIndex = 3;
            // 
            // radbutTeachNo
            // 
            this.radbutTeachNo.AutoSize = true;
            this.radbutTeachNo.Location = new System.Drawing.Point(32, 77);
            this.radbutTeachNo.Name = "radbutTeachNo";
            this.radbutTeachNo.Size = new System.Drawing.Size(110, 21);
            this.radbutTeachNo.TabIndex = 2;
            this.radbutTeachNo.TabStop = true;
            this.radbutTeachNo.Text = "按教师工号查找";
            this.radbutTeachNo.UseVisualStyleBackColor = true;
            // 
            // radbutStuNo
            // 
            this.radbutStuNo.AutoSize = true;
            this.radbutStuNo.Location = new System.Drawing.Point(32, 50);
            this.radbutStuNo.Name = "radbutStuNo";
            this.radbutStuNo.Size = new System.Drawing.Size(110, 21);
            this.radbutStuNo.TabIndex = 1;
            this.radbutStuNo.TabStop = true;
            this.radbutStuNo.Text = "按学生学号查找";
            this.radbutStuNo.UseVisualStyleBackColor = true;
            // 
            // radbutClass
            // 
            this.radbutClass.AutoSize = true;
            this.radbutClass.Location = new System.Drawing.Point(32, 23);
            this.radbutClass.Name = "radbutClass";
            this.radbutClass.Size = new System.Drawing.Size(110, 21);
            this.radbutClass.TabIndex = 0;
            this.radbutClass.TabStop = true;
            this.radbutClass.Text = "按班级名称查找";
            this.radbutClass.UseVisualStyleBackColor = true;
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSelectBindingSource
            // 
            this.tbSelectBindingSource.DataMember = "tbSelect";
            this.tbSelectBindingSource.DataSource = this.sQLDataSet;
            // 
            // tbSelectTableAdapter
            // 
            this.tbSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = null;
            this.tableAdapterManager.tbCourseTableAdapter = null;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMarkTableAdapter = null;
            this.tableAdapterManager.tbSelectTableAdapter = this.tbSelectTableAdapter;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvselect
            // 
            this.dgvselect.AllowUserToAddRows = false;
            this.dgvselect.AllowUserToDeleteRows = false;
            this.dgvselect.AutoGenerateColumns = false;
            this.dgvselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvselect.DataSource = this.tbSelectBindingSource;
            this.dgvselect.Location = new System.Drawing.Point(40, 36);
            this.dgvselect.Name = "dgvselect";
            this.dgvselect.ReadOnly = true;
            this.dgvselect.RowTemplate.Height = 23;
            this.dgvselect.Size = new System.Drawing.Size(486, 374);
            this.dgvselect.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "selectno";
            this.dataGridViewTextBoxColumn1.HeaderText = "选课表流水号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stuno";
            this.dataGridViewTextBoxColumn2.HeaderText = "学生学号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "classno";
            this.dataGridViewTextBoxColumn3.HeaderText = "班级流水号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "states";
            this.dataGridViewTextBoxColumn4.HeaderText = "状态";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.comboxDepart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(550, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(245, 69);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 25);
            this.butScreen.TabIndex = 3;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // comboxDepart
            // 
            this.comboxDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepart.FormattingEnabled = true;
            this.comboxDepart.Location = new System.Drawing.Point(32, 70);
            this.comboxDepart.Name = "comboxDepart";
            this.comboxDepart.Size = new System.Drawing.Size(171, 25);
            this.comboxDepart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "按课程所属院系筛选";
            // 
            // butRecovery
            // 
            this.butRecovery.Location = new System.Drawing.Point(214, 132);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(106, 25);
            this.butRecovery.TabIndex = 0;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // frmInforQuerySelCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvselect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmInforQuerySelCou";
            this.Size = new System.Drawing.Size(931, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbSelectBindingSource;
        private SQLDataSetTableAdapters.tbSelectTableAdapter tbSelectTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvselect;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.RadioButton radbutTeachNo;
        private System.Windows.Forms.RadioButton radbutStuNo;
        private System.Windows.Forms.RadioButton radbutClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.ComboBox comboxDepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRecovery;
    }
}
