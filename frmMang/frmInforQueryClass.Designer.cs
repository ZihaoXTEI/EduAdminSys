namespace EduAdminSys.frmMang
{
    partial class frmInforQueryClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforQueryClass));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.butRecover = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.radbutTeachNo = new System.Windows.Forms.RadioButton();
            this.radbutClass = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new EduAdminSys.DataSet1();
            this.tbClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClassTableAdapter = new EduAdminSys.DataSet1TableAdapters.tbClassTableAdapter();
            this.tableAdapterManager = new EduAdminSys.DataSet1TableAdapters.TableAdapterManager();
            this.tbClassBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbClassBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.comboxScreen = new System.Windows.Forms.ComboBox();
            this.radbutClassStates = new System.Windows.Forms.RadioButton();
            this.radbutDeprat = new System.Windows.Forms.RadioButton();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbClassTableAdapter1 = new EduAdminSys.SQLDataSetTableAdapters.tbClassTableAdapter();
            this.tableAdapterManager1 = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvclass = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radbutSortASC = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radbutSortDESC = new System.Windows.Forms.RadioButton();
            this.butSort = new System.Windows.Forms.Button();
            this.labSortName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingNavigator)).BeginInit();
            this.tbClassBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.butRecover);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.radbutTeachNo);
            this.groupBox1.Controls.Add(this.radbutClass);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(691, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(134, 116);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 23);
            this.butCheck.TabIndex = 4;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // butRecover
            // 
            this.butRecover.Location = new System.Drawing.Point(19, 116);
            this.butRecover.Name = "butRecover";
            this.butRecover.Size = new System.Drawing.Size(109, 23);
            this.butRecover.TabIndex = 5;
            this.butRecover.Text = "恢复信息表";
            this.butRecover.UseVisualStyleBackColor = true;
            this.butRecover.Click += new System.EventHandler(this.ButRecover_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(19, 77);
            this.txtboxCheck.MaxLength = 50;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(190, 23);
            this.txtboxCheck.TabIndex = 3;
            // 
            // radbutTeachNo
            // 
            this.radbutTeachNo.AutoSize = true;
            this.radbutTeachNo.Location = new System.Drawing.Point(18, 50);
            this.radbutTeachNo.Name = "radbutTeachNo";
            this.radbutTeachNo.Size = new System.Drawing.Size(134, 21);
            this.radbutTeachNo.TabIndex = 1;
            this.radbutTeachNo.TabStop = true;
            this.radbutTeachNo.Text = "按任课教师工号查找";
            this.radbutTeachNo.UseVisualStyleBackColor = true;
            // 
            // radbutClass
            // 
            this.radbutClass.AutoSize = true;
            this.radbutClass.Location = new System.Drawing.Point(19, 23);
            this.radbutClass.Name = "radbutClass";
            this.radbutClass.Size = new System.Drawing.Size(110, 21);
            this.radbutClass.TabIndex = 0;
            this.radbutClass.TabStop = true;
            this.radbutClass.Text = "按班级名称查找";
            this.radbutClass.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClassBindingSource
            // 
            this.tbClassBindingSource.DataMember = "tbClass";
            this.tbClassBindingSource.DataSource = this.dataSet1;
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
            this.tableAdapterManager.UpdateOrder = EduAdminSys.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbClassBindingNavigator
            // 
            this.tbClassBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbClassBindingNavigator.BindingSource = this.tbClassBindingSource;
            this.tbClassBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbClassBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbClassBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbClassBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbClassBindingNavigatorSaveItem});
            this.tbClassBindingNavigator.Location = new System.Drawing.Point(20, 423);
            this.tbClassBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbClassBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbClassBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbClassBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbClassBindingNavigator.Name = "tbClassBindingNavigator";
            this.tbClassBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbClassBindingNavigator.Size = new System.Drawing.Size(275, 25);
            this.tbClassBindingNavigator.TabIndex = 2;
            this.tbClassBindingNavigator.Text = "bindingNavigator1";
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
            // tbClassBindingNavigatorSaveItem
            // 
            this.tbClassBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClassBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbClassBindingNavigatorSaveItem.Image")));
            this.tbClassBindingNavigatorSaveItem.Name = "tbClassBindingNavigatorSaveItem";
            this.tbClassBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbClassBindingNavigatorSaveItem.Text = "保存数据";
            this.tbClassBindingNavigatorSaveItem.Click += new System.EventHandler(this.TbClassBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.comboxScreen);
            this.groupBox2.Controls.Add(this.radbutClassStates);
            this.groupBox2.Controls.Add(this.radbutDeprat);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(691, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(134, 110);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 23);
            this.butScreen.TabIndex = 4;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // comboxScreen
            // 
            this.comboxScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxScreen.FormattingEnabled = true;
            this.comboxScreen.Location = new System.Drawing.Point(19, 76);
            this.comboxScreen.Name = "comboxScreen";
            this.comboxScreen.Size = new System.Drawing.Size(190, 25);
            this.comboxScreen.TabIndex = 3;
            // 
            // radbutClassStates
            // 
            this.radbutClassStates.AutoSize = true;
            this.radbutClassStates.Location = new System.Drawing.Point(19, 49);
            this.radbutClassStates.Name = "radbutClassStates";
            this.radbutClassStates.Size = new System.Drawing.Size(110, 21);
            this.radbutClassStates.TabIndex = 2;
            this.radbutClassStates.TabStop = true;
            this.radbutClassStates.Text = "按课程状态筛选";
            this.radbutClassStates.UseVisualStyleBackColor = true;
            this.radbutClassStates.CheckedChanged += new System.EventHandler(this.RadbutClassStates_CheckedChanged);
            // 
            // radbutDeprat
            // 
            this.radbutDeprat.AutoSize = true;
            this.radbutDeprat.Location = new System.Drawing.Point(19, 22);
            this.radbutDeprat.Name = "radbutDeprat";
            this.radbutDeprat.Size = new System.Drawing.Size(86, 21);
            this.radbutDeprat.TabIndex = 1;
            this.radbutDeprat.TabStop = true;
            this.radbutDeprat.Text = "按院系筛选";
            this.radbutDeprat.UseVisualStyleBackColor = true;
            this.radbutDeprat.CheckedChanged += new System.EventHandler(this.RadbutDeprat_CheckedChanged);
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClassBindingSource1
            // 
            this.tbClassBindingSource1.DataMember = "tbClass";
            this.tbClassBindingSource1.DataSource = this.sQLDataSet;
            // 
            // tbClassTableAdapter1
            // 
            this.tbClassTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbClassTableAdapter = this.tbClassTableAdapter1;
            this.tableAdapterManager1.tbCourseTableAdapter = null;
            this.tableAdapterManager1.tbDepartTableAdapter = null;
            this.tableAdapterManager1.tbLoginTableAdapter = null;
            this.tableAdapterManager1.tbMarkTableAdapter = null;
            this.tableAdapterManager1.tbSelectTableAdapter = null;
            this.tableAdapterManager1.tbStudentTableAdapter = null;
            this.tableAdapterManager1.tbTeachTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvclass
            // 
            this.dgvclass.AllowUserToAddRows = false;
            this.dgvclass.AllowUserToDeleteRows = false;
            this.dgvclass.AutoGenerateColumns = false;
            this.dgvclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvclass.DataSource = this.tbClassBindingSource1;
            this.dgvclass.Location = new System.Drawing.Point(20, 33);
            this.dgvclass.Name = "dgvclass";
            this.dgvclass.ReadOnly = true;
            this.dgvclass.RowTemplate.Height = 23;
            this.dgvclass.Size = new System.Drawing.Size(665, 387);
            this.dgvclass.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "classno";
            this.dataGridViewTextBoxColumn1.HeaderText = "班级流水号";
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
            this.dataGridViewTextBoxColumn4.HeaderText = "学生人数";
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
            this.dataGridViewTextBoxColumn6.HeaderText = "院系编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "teachno";
            this.dataGridViewTextBoxColumn7.HeaderText = "教师工号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // radbutSortASC
            // 
            this.radbutSortASC.AutoSize = true;
            this.radbutSortASC.Location = new System.Drawing.Point(28, 45);
            this.radbutSortASC.Name = "radbutSortASC";
            this.radbutSortASC.Size = new System.Drawing.Size(50, 21);
            this.radbutSortASC.TabIndex = 2;
            this.radbutSortASC.TabStop = true;
            this.radbutSortASC.Text = "升序";
            this.radbutSortASC.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radbutSortDESC);
            this.groupBox3.Controls.Add(this.butSort);
            this.groupBox3.Controls.Add(this.labSortName);
            this.groupBox3.Controls.Add(this.radbutSortASC);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(691, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 112);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "排序";
            // 
            // radbutSortDESC
            // 
            this.radbutSortDESC.AutoSize = true;
            this.radbutSortDESC.Location = new System.Drawing.Point(149, 45);
            this.radbutSortDESC.Name = "radbutSortDESC";
            this.radbutSortDESC.Size = new System.Drawing.Size(50, 21);
            this.radbutSortDESC.TabIndex = 5;
            this.radbutSortDESC.TabStop = true;
            this.radbutSortDESC.Text = "降序";
            this.radbutSortDESC.UseVisualStyleBackColor = true;
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(134, 72);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(75, 23);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "排序";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.ButSort_Click);
            // 
            // labSortName
            // 
            this.labSortName.AutoSize = true;
            this.labSortName.Location = new System.Drawing.Point(25, 25);
            this.labSortName.Name = "labSortName";
            this.labSortName.Size = new System.Drawing.Size(104, 17);
            this.labSortName.TabIndex = 3;
            this.labSortName.Text = "按学生数量排序：";
            // 
            // frmInforQueryClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvclass);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbClassBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmInforQueryClass";
            this.Size = new System.Drawing.Size(938, 468);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingNavigator)).EndInit();
            this.tbClassBindingNavigator.ResumeLayout(false);
            this.tbClassBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclass)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbutTeachNo;
        private System.Windows.Forms.RadioButton radbutClass;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tbClassBindingSource;
        private DataSet1TableAdapters.tbClassTableAdapter tbClassTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbClassBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbClassBindingNavigatorSaveItem;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butRecover;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.ComboBox comboxScreen;
        private System.Windows.Forms.RadioButton radbutClassStates;
        private System.Windows.Forms.RadioButton radbutDeprat;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbClassBindingSource1;
        private SQLDataSetTableAdapters.tbClassTableAdapter tbClassTableAdapter1;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgvclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.RadioButton radbutSortASC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbutSortDESC;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Label labSortName;
    }
}
