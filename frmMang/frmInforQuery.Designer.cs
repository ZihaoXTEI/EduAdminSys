namespace EduAdminSys.frmMang
{
    partial class frmInforQuery
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
            this.label2 = new System.Windows.Forms.Label();
            this.butEnter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butRecovery = new System.Windows.Forms.Button();
            this.comboxChoiceTable = new System.Windows.Forms.ComboBox();
            this.tbDepartBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EduAdminSys.DataSet1();
            this.tbDepartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbDepartTableAdapter1 = new EduAdminSys.DataSet1TableAdapters.tbDepartTableAdapter();
            this.tableAdapterManager1 = new EduAdminSys.DataSet1TableAdapters.TableAdapterManager();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbDepartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labTableName
            // 
            this.labTableName.AutoSize = true;
            this.labTableName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTableName.Location = new System.Drawing.Point(31, 12);
            this.labTableName.Name = "labTableName";
            this.labTableName.Size = new System.Drawing.Size(65, 20);
            this.labTableName.TabIndex = 0;
            this.labTableName.Text = "院系信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "按编号查找：";
            // 
            // butEnter
            // 
            this.butEnter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butEnter.Location = new System.Drawing.Point(73, 109);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(102, 30);
            this.butEnter.TabIndex = 3;
            this.butEnter.Text = "确认";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.ButEnter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butRecovery);
            this.groupBox1.Controls.Add(this.comboxChoiceTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butEnter);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(746, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 403);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butRecovery
            // 
            this.butRecovery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butRecovery.Location = new System.Drawing.Point(73, 145);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(102, 30);
            this.butRecovery.TabIndex = 5;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // comboxChoiceTable
            // 
            this.comboxChoiceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxChoiceTable.FormattingEnabled = true;
            this.comboxChoiceTable.Location = new System.Drawing.Point(20, 51);
            this.comboxChoiceTable.Name = "comboxChoiceTable";
            this.comboxChoiceTable.Size = new System.Drawing.Size(155, 25);
            this.comboxChoiceTable.TabIndex = 4;
            // 
            // tbDepartBindingSource2
            // 
            this.tbDepartBindingSource2.DataMember = "tbDepart";
            this.tbDepartBindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDepartBindingSource1
            // 
            this.tbDepartBindingSource1.DataMember = "tbDepart";
            this.tbDepartBindingSource1.DataSource = this.dataSet1;
            // 
            // tbDepartTableAdapter1
            // 
            this.tbDepartTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbClassTableAdapter = null;
            this.tableAdapterManager1.tbCourseTableAdapter = null;
            this.tableAdapterManager1.tbDepartTableAdapter = this.tbDepartTableAdapter1;
            this.tableAdapterManager1.tbLoginTableAdapter = null;
            this.tableAdapterManager1.tbMarkTableAdapter = null;
            this.tableAdapterManager1.tbSelectTableAdapter = null;
            this.tableAdapterManager1.tbStudentTableAdapter = null;
            this.tableAdapterManager1.tbTeachTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = EduAdminSys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv.DataSource = this.tbDepartBindingSource1;
            this.dgv.Location = new System.Drawing.Point(35, 35);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(705, 393);
            this.dgv.TabIndex = 6;
            // 
            // tbDepartBindingSource
            // 
            this.tbDepartBindingSource.DataMember = "tbDepart";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "负责人";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "departname";
            this.dataGridViewTextBoxColumn2.HeaderText = "院系名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "departno";
            this.dataGridViewTextBoxColumn1.HeaderText = "院系编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmInforQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTableName);
            this.Name = "frmInforQuery";
            this.Size = new System.Drawing.Size(947, 469);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDepartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.BindingSource tbDepartBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbDepartBindingSource1;
        private DataSet1TableAdapters.tbDepartTableAdapter tbDepartTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboxChoiceTable;
        private System.Windows.Forms.BindingSource tbDepartBindingSource2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button butRecovery;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
