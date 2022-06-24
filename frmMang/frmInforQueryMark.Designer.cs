namespace EduAdminSys.frmMang
{
    partial class frmInforQueryMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforQueryMark));
            this.labTableName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.radbutClass = new System.Windows.Forms.RadioButton();
            this.radbutNo = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new EduAdminSys.DataSet1();
            this.tbMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMarkTableAdapter = new EduAdminSys.DataSet1TableAdapters.tbMarkTableAdapter();
            this.tableAdapterManager = new EduAdminSys.DataSet1TableAdapters.TableAdapterManager();
            this.tbMarkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMarkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comboxLevel = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.chkboxLevel = new System.Windows.Forms.CheckBox();
            this.chkboxBukao = new System.Windows.Forms.CheckBox();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbMarkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbMarkTableAdapter1 = new EduAdminSys.SQLDataSetTableAdapters.tbMarkTableAdapter();
            this.tableAdapterManager1 = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvmark = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingNavigator)).BeginInit();
            this.tbMarkBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmark)).BeginInit();
            this.SuspendLayout();
            // 
            // labTableName
            // 
            this.labTableName.AutoSize = true;
            this.labTableName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTableName.Location = new System.Drawing.Point(32, 13);
            this.labTableName.Name = "labTableName";
            this.labTableName.Size = new System.Drawing.Size(65, 20);
            this.labTableName.TabIndex = 0;
            this.labTableName.Text = "成绩信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.radbutClass);
            this.groupBox1.Controls.Add(this.radbutNo);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(616, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(184, 92);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 30);
            this.butCheck.TabIndex = 3;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxCheck.Location = new System.Drawing.Point(29, 54);
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(230, 26);
            this.txtboxCheck.TabIndex = 2;
            // 
            // radbutClass
            // 
            this.radbutClass.AutoSize = true;
            this.radbutClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutClass.Location = new System.Drawing.Point(162, 27);
            this.radbutClass.Name = "radbutClass";
            this.radbutClass.Size = new System.Drawing.Size(97, 24);
            this.radbutClass.TabIndex = 1;
            this.radbutClass.TabStop = true;
            this.radbutClass.Text = "按班级查找";
            this.radbutClass.UseVisualStyleBackColor = true;
            // 
            // radbutNo
            // 
            this.radbutNo.AutoSize = true;
            this.radbutNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radbutNo.Location = new System.Drawing.Point(29, 27);
            this.radbutNo.Name = "radbutNo";
            this.radbutNo.Size = new System.Drawing.Size(97, 24);
            this.radbutNo.TabIndex = 0;
            this.radbutNo.TabStop = true;
            this.radbutNo.Text = "按学号查找";
            this.radbutNo.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMarkBindingSource
            // 
            this.tbMarkBindingSource.DataMember = "tbMark";
            this.tbMarkBindingSource.DataSource = this.dataSet1;
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
            this.tableAdapterManager.UpdateOrder = EduAdminSys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbMarkBindingNavigator
            // 
            this.tbMarkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbMarkBindingNavigator.BindingSource = this.tbMarkBindingSource;
            this.tbMarkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbMarkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbMarkBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbMarkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbMarkBindingNavigatorSaveItem});
            this.tbMarkBindingNavigator.Location = new System.Drawing.Point(36, 429);
            this.tbMarkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbMarkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbMarkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbMarkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbMarkBindingNavigator.Name = "tbMarkBindingNavigator";
            this.tbMarkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbMarkBindingNavigator.Size = new System.Drawing.Size(275, 25);
            this.tbMarkBindingNavigator.TabIndex = 2;
            this.tbMarkBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbMarkBindingNavigatorSaveItem
            // 
            this.tbMarkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMarkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbMarkBindingNavigatorSaveItem.Image")));
            this.tbMarkBindingNavigatorSaveItem.Name = "tbMarkBindingNavigatorSaveItem";
            this.tbMarkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbMarkBindingNavigatorSaveItem.Text = "保存数据";
            this.tbMarkBindingNavigatorSaveItem.Click += new System.EventHandler(this.TbMarkBindingNavigatorSaveItem_Click);
            // 
            // comboxLevel
            // 
            this.comboxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxLevel.FormattingEnabled = true;
            this.comboxLevel.Location = new System.Drawing.Point(29, 90);
            this.comboxLevel.Name = "comboxLevel";
            this.comboxLevel.Size = new System.Drawing.Size(230, 28);
            this.comboxLevel.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.chkboxLevel);
            this.groupBox2.Controls.Add(this.chkboxBukao);
            this.groupBox2.Controls.Add(this.comboxLevel);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(616, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(184, 152);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 30);
            this.butScreen.TabIndex = 8;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // chkboxLevel
            // 
            this.chkboxLevel.AutoSize = true;
            this.chkboxLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkboxLevel.Location = new System.Drawing.Point(29, 63);
            this.chkboxLevel.Name = "chkboxLevel";
            this.chkboxLevel.Size = new System.Drawing.Size(84, 24);
            this.chkboxLevel.TabIndex = 6;
            this.chkboxLevel.Text = "成绩等级";
            this.chkboxLevel.UseVisualStyleBackColor = true;
            // 
            // chkboxBukao
            // 
            this.chkboxBukao.AutoSize = true;
            this.chkboxBukao.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkboxBukao.Location = new System.Drawing.Point(29, 24);
            this.chkboxBukao.Name = "chkboxBukao";
            this.chkboxBukao.Size = new System.Drawing.Size(112, 24);
            this.chkboxBukao.TabIndex = 5;
            this.chkboxBukao.Text = "只看补考成绩";
            this.chkboxBukao.UseVisualStyleBackColor = true;
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMarkBindingSource1
            // 
            this.tbMarkBindingSource1.DataMember = "tbMark";
            this.tbMarkBindingSource1.DataSource = this.sQLDataSet;
            // 
            // tbMarkTableAdapter1
            // 
            this.tbMarkTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbClassTableAdapter = null;
            this.tableAdapterManager1.tbCourseTableAdapter = null;
            this.tableAdapterManager1.tbDepartTableAdapter = null;
            this.tableAdapterManager1.tbLoginTableAdapter = null;
            this.tableAdapterManager1.tbMarkTableAdapter = this.tbMarkTableAdapter1;
            this.tableAdapterManager1.tbSelectTableAdapter = null;
            this.tableAdapterManager1.tbStudentTableAdapter = null;
            this.tableAdapterManager1.tbTeachTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvmark
            // 
            this.dgvmark.AllowUserToAddRows = false;
            this.dgvmark.AllowUserToDeleteRows = false;
            this.dgvmark.AutoGenerateColumns = false;
            this.dgvmark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvmark.DataSource = this.tbMarkBindingSource1;
            this.dgvmark.Location = new System.Drawing.Point(36, 36);
            this.dgvmark.Name = "dgvmark";
            this.dgvmark.ReadOnly = true;
            this.dgvmark.RowTemplate.Height = 23;
            this.dgvmark.Size = new System.Drawing.Size(565, 390);
            this.dgvmark.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "markno";
            this.dataGridViewTextBoxColumn1.HeaderText = "成绩表流水号";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mark";
            this.dataGridViewTextBoxColumn4.HeaderText = "成绩";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bukao";
            this.dataGridViewTextBoxColumn5.HeaderText = "补考成绩";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmInforQueryMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvmark);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbMarkBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTableName);
            this.Name = "frmInforQueryMark";
            this.Size = new System.Drawing.Size(930, 474);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingNavigator)).EndInit();
            this.tbMarkBindingNavigator.ResumeLayout(false);
            this.tbMarkBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMarkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTableName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbMarkBindingSource;
        private DataSet1TableAdapters.tbMarkTableAdapter tbMarkTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbMarkBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbMarkBindingNavigatorSaveItem;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.RadioButton radbutClass;
        private System.Windows.Forms.RadioButton radbutNo;
        private System.Windows.Forms.ComboBox comboxLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.CheckBox chkboxLevel;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbMarkBindingSource1;
        private SQLDataSetTableAdapters.tbMarkTableAdapter tbMarkTableAdapter1;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgvmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.CheckBox chkboxBukao;
    }
}
