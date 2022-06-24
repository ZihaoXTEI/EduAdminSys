namespace EduAdminSys.frmMang
{
    partial class frmMangSelCou
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
            this.tbSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSelectTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbSelectTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvSeleCou = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleCou)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择信息管理";
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
            // dgvSeleCou
            // 
            this.dgvSeleCou.AllowUserToAddRows = false;
            this.dgvSeleCou.AllowUserToDeleteRows = false;
            this.dgvSeleCou.AutoGenerateColumns = false;
            this.dgvSeleCou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleCou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSeleCou.DataSource = this.tbSelectBindingSource;
            this.dgvSeleCou.Location = new System.Drawing.Point(62, 41);
            this.dgvSeleCou.Name = "dgvSeleCou";
            this.dgvSeleCou.ReadOnly = true;
            this.dgvSeleCou.RowTemplate.Height = 23;
            this.dgvSeleCou.Size = new System.Drawing.Size(451, 385);
            this.dgvSeleCou.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "selectno";
            this.dataGridViewTextBoxColumn1.HeaderText = "选课流水号";
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
            this.dataGridViewTextBoxColumn3.HeaderText = "班级编号";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(629, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(574, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "将符合要求的选课信息导入至成绩表中";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(629, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "删除所有信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmMangSelCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSeleCou);
            this.Controls.Add(this.label1);
            this.Name = "frmMangSelCou";
            this.Size = new System.Drawing.Size(930, 460);
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleCou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbSelectBindingSource;
        private SQLDataSetTableAdapters.tbSelectTableAdapter tbSelectTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvSeleCou;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
