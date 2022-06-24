namespace EduAdminSys.frmMang
{
    partial class frmInforQueryCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforQueryCourse));
            this.labCourseName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.radbutCouName = new System.Windows.Forms.RadioButton();
            this.radbutCouNo = new System.Windows.Forms.RadioButton();
            this.sQLDataSet = new EduAdminSys.SQLDataSet();
            this.tbCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCourseTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbCourseTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.tbCourseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbCourseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butRecovery = new System.Windows.Forms.Button();
            this.comboxCouHour = new System.Windows.Forms.ComboBox();
            this.comboxCredit = new System.Windows.Forms.ComboBox();
            this.butScreen = new System.Windows.Forms.Button();
            this.comboxDepartNo = new System.Windows.Forms.ComboBox();
            this.chkboxDepartNo = new System.Windows.Forms.CheckBox();
            this.chkboxCredit = new System.Windows.Forms.CheckBox();
            this.chkboxCouHour = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCourseBindingNavigator)).BeginInit();
            this.tbCourseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCourseName
            // 
            this.labCourseName.AutoSize = true;
            this.labCourseName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCourseName.Location = new System.Drawing.Point(23, 11);
            this.labCourseName.Name = "labCourseName";
            this.labCourseName.Size = new System.Drawing.Size(65, 20);
            this.labCourseName.TabIndex = 0;
            this.labCourseName.Text = "课程信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.txtboxCheck);
            this.groupBox1.Controls.Add(this.radbutCouName);
            this.groupBox1.Controls.Add(this.radbutCouNo);
            this.groupBox1.Location = new System.Drawing.Point(679, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(157, 116);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 25);
            this.butCheck.TabIndex = 3;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Location = new System.Drawing.Point(16, 78);
            this.txtboxCheck.MaxLength = 50;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(216, 23);
            this.txtboxCheck.TabIndex = 2;
            // 
            // radbutCouName
            // 
            this.radbutCouName.AutoSize = true;
            this.radbutCouName.Location = new System.Drawing.Point(16, 50);
            this.radbutCouName.Name = "radbutCouName";
            this.radbutCouName.Size = new System.Drawing.Size(110, 21);
            this.radbutCouName.TabIndex = 1;
            this.radbutCouName.TabStop = true;
            this.radbutCouName.Text = "按课程名称查找";
            this.radbutCouName.UseVisualStyleBackColor = true;
            // 
            // radbutCouNo
            // 
            this.radbutCouNo.AutoSize = true;
            this.radbutCouNo.Location = new System.Drawing.Point(16, 23);
            this.radbutCouNo.Name = "radbutCouNo";
            this.radbutCouNo.Size = new System.Drawing.Size(110, 21);
            this.radbutCouNo.TabIndex = 0;
            this.radbutCouNo.TabStop = true;
            this.radbutCouNo.Text = "按课程编号查找";
            this.radbutCouNo.UseVisualStyleBackColor = true;
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCourseBindingSource
            // 
            this.tbCourseBindingSource.DataMember = "tbCourse";
            this.tbCourseBindingSource.DataSource = this.sQLDataSet;
            // 
            // tbCourseTableAdapter
            // 
            this.tbCourseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = null;
            this.tableAdapterManager.tbCourseTableAdapter = this.tbCourseTableAdapter;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbMarkTableAdapter = null;
            this.tableAdapterManager.tbSelectTableAdapter = null;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbCourseBindingNavigator
            // 
            this.tbCourseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbCourseBindingNavigator.BindingSource = this.tbCourseBindingSource;
            this.tbCourseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbCourseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbCourseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbCourseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbCourseBindingNavigatorSaveItem});
            this.tbCourseBindingNavigator.Location = new System.Drawing.Point(27, 425);
            this.tbCourseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbCourseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbCourseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbCourseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbCourseBindingNavigator.Name = "tbCourseBindingNavigator";
            this.tbCourseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbCourseBindingNavigator.Size = new System.Drawing.Size(275, 25);
            this.tbCourseBindingNavigator.TabIndex = 2;
            this.tbCourseBindingNavigator.Text = "bindingNavigator1";
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
            // tbCourseBindingNavigatorSaveItem
            // 
            this.tbCourseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCourseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbCourseBindingNavigatorSaveItem.Image")));
            this.tbCourseBindingNavigatorSaveItem.Name = "tbCourseBindingNavigatorSaveItem";
            this.tbCourseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbCourseBindingNavigatorSaveItem.Text = "保存数据";
            this.tbCourseBindingNavigatorSaveItem.Click += new System.EventHandler(this.TbCourseBindingNavigatorSaveItem_Click);
            // 
            // dgvcourse
            // 
            this.dgvcourse.AllowUserToAddRows = false;
            this.dgvcourse.AllowUserToDeleteRows = false;
            this.dgvcourse.AutoGenerateColumns = false;
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvcourse.DataSource = this.tbCourseBindingSource;
            this.dgvcourse.Location = new System.Drawing.Point(27, 34);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.ReadOnly = true;
            this.dgvcourse.RowTemplate.Height = 23;
            this.dgvcourse.Size = new System.Drawing.Size(646, 395);
            this.dgvcourse.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "courseno";
            this.dataGridViewTextBoxColumn1.HeaderText = "课程编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn2.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "couhour";
            this.dataGridViewTextBoxColumn3.HeaderText = "课程学时";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "coutype";
            this.dataGridViewTextBoxColumn4.HeaderText = "课程类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "credit";
            this.dataGridViewTextBoxColumn5.HeaderText = "学分";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butRecovery);
            this.groupBox2.Controls.Add(this.comboxCouHour);
            this.groupBox2.Controls.Add(this.comboxCredit);
            this.groupBox2.Controls.Add(this.butScreen);
            this.groupBox2.Controls.Add(this.comboxDepartNo);
            this.groupBox2.Controls.Add(this.chkboxDepartNo);
            this.groupBox2.Controls.Add(this.chkboxCredit);
            this.groupBox2.Controls.Add(this.chkboxCouHour);
            this.groupBox2.Location = new System.Drawing.Point(679, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选";
            // 
            // butRecovery
            // 
            this.butRecovery.Location = new System.Drawing.Point(16, 210);
            this.butRecovery.Name = "butRecovery";
            this.butRecovery.Size = new System.Drawing.Size(110, 25);
            this.butRecovery.TabIndex = 9;
            this.butRecovery.Text = "恢复信息表";
            this.butRecovery.UseVisualStyleBackColor = true;
            this.butRecovery.Click += new System.EventHandler(this.ButRecovery_Click);
            // 
            // comboxCouHour
            // 
            this.comboxCouHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCouHour.FormattingEnabled = true;
            this.comboxCouHour.Location = new System.Drawing.Point(16, 66);
            this.comboxCouHour.Name = "comboxCouHour";
            this.comboxCouHour.Size = new System.Drawing.Size(110, 25);
            this.comboxCouHour.TabIndex = 8;
            // 
            // comboxCredit
            // 
            this.comboxCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCredit.FormattingEnabled = true;
            this.comboxCredit.Location = new System.Drawing.Point(136, 66);
            this.comboxCredit.Name = "comboxCredit";
            this.comboxCredit.Size = new System.Drawing.Size(82, 25);
            this.comboxCredit.TabIndex = 7;
            // 
            // butScreen
            // 
            this.butScreen.Location = new System.Drawing.Point(157, 210);
            this.butScreen.Name = "butScreen";
            this.butScreen.Size = new System.Drawing.Size(75, 25);
            this.butScreen.TabIndex = 4;
            this.butScreen.Text = "筛选";
            this.butScreen.UseVisualStyleBackColor = true;
            this.butScreen.Click += new System.EventHandler(this.ButScreen_Click);
            // 
            // comboxDepartNo
            // 
            this.comboxDepartNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepartNo.FormattingEnabled = true;
            this.comboxDepartNo.Location = new System.Drawing.Point(15, 134);
            this.comboxDepartNo.Name = "comboxDepartNo";
            this.comboxDepartNo.Size = new System.Drawing.Size(203, 25);
            this.comboxDepartNo.TabIndex = 3;
            // 
            // chkboxDepartNo
            // 
            this.chkboxDepartNo.AutoSize = true;
            this.chkboxDepartNo.Location = new System.Drawing.Point(15, 102);
            this.chkboxDepartNo.Name = "chkboxDepartNo";
            this.chkboxDepartNo.Size = new System.Drawing.Size(75, 21);
            this.chkboxDepartNo.TabIndex = 2;
            this.chkboxDepartNo.Text = "院系编号";
            this.chkboxDepartNo.UseVisualStyleBackColor = true;
            // 
            // chkboxCredit
            // 
            this.chkboxCredit.AutoSize = true;
            this.chkboxCredit.Location = new System.Drawing.Point(136, 34);
            this.chkboxCredit.Name = "chkboxCredit";
            this.chkboxCredit.Size = new System.Drawing.Size(75, 21);
            this.chkboxCredit.TabIndex = 1;
            this.chkboxCredit.Text = "课程学分";
            this.chkboxCredit.UseVisualStyleBackColor = true;
            // 
            // chkboxCouHour
            // 
            this.chkboxCouHour.AutoSize = true;
            this.chkboxCouHour.Location = new System.Drawing.Point(16, 34);
            this.chkboxCouHour.Name = "chkboxCouHour";
            this.chkboxCouHour.Size = new System.Drawing.Size(75, 21);
            this.chkboxCouHour.TabIndex = 0;
            this.chkboxCouHour.Text = "课程学时";
            this.chkboxCouHour.UseVisualStyleBackColor = true;
            // 
            // frmInforQueryCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvcourse);
            this.Controls.Add(this.tbCourseBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labCourseName);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInforQueryCourse";
            this.Size = new System.Drawing.Size(938, 460);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCourseBindingNavigator)).EndInit();
            this.tbCourseBindingNavigator.ResumeLayout(false);
            this.tbCourseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCourseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbCourseBindingSource;
        private SQLDataSetTableAdapters.tbCourseTableAdapter tbCourseTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbCourseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbCourseBindingNavigatorSaveItem;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox txtboxCheck;
        private System.Windows.Forms.RadioButton radbutCouName;
        private System.Windows.Forms.RadioButton radbutCouNo;
        private System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butScreen;
        private System.Windows.Forms.ComboBox comboxDepartNo;
        private System.Windows.Forms.CheckBox chkboxDepartNo;
        private System.Windows.Forms.CheckBox chkboxCredit;
        private System.Windows.Forms.CheckBox chkboxCouHour;
        private System.Windows.Forms.ComboBox comboxCouHour;
        private System.Windows.Forms.ComboBox comboxCredit;
        private System.Windows.Forms.Button butRecovery;
    }
}
