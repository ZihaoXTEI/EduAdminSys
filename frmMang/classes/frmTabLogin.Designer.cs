using System;
using System.Windows.Forms;

namespace EduAdminSys.frmMang.classes
{
    partial class frmTabLogin
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
            this.tbLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbLoginTableAdapter = new EduAdminSys.SQLDataSetTableAdapters.tbLoginTableAdapter();
            this.tableAdapterManager = new EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.comboxRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxPSW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "登陆表数据：";
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLoginBindingSource
            // 
            this.tbLoginBindingSource.DataMember = "tbLogin";
            this.tbLoginBindingSource.DataSource = this.sQLDataSet;
            // 
            // tbLoginTableAdapter
            // 
            this.tbLoginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClassTableAdapter = null;
            this.tableAdapterManager.tbCourseTableAdapter = null;
            this.tableAdapterManager.tbDepartTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = this.tbLoginTableAdapter;
            this.tableAdapterManager.tbMarkTableAdapter = null;
            this.tableAdapterManager.tbSelectTableAdapter = null;
            this.tableAdapterManager.tbStudentTableAdapter = null;
            this.tableAdapterManager.tbTeachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EduAdminSys.SQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvLogin
            // 
            this.dgvLogin.AllowUserToAddRows = false;
            this.dgvLogin.AllowUserToDeleteRows = false;
            this.dgvLogin.AutoGenerateColumns = false;
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgvLogin.DataSource = this.tbLoginBindingSource;
            this.dgvLogin.Location = new System.Drawing.Point(12, 34);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.ReadOnly = true;
            this.dgvLogin.RowTemplate.Height = 23;
            this.dgvLogin.Size = new System.Drawing.Size(301, 408);
            this.dgvLogin.TabIndex = 2;
            this.dgvLogin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLogin_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userid";
            this.dataGridViewTextBoxColumn1.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "psw";
            this.dataGridViewTextBoxColumn2.HeaderText = "密码";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn4.HeaderText = "身份权限";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn3.HeaderText = "状态";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butDelete);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.comboxRole);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtboxPSW);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtboxID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(331, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(20, 156);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 7;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(133, 156);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 6;
            this.butUpdate.Text = "修改";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.ButUpdate_Click);
            // 
            // comboxRole
            // 
            this.comboxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxRole.FormattingEnabled = true;
            this.comboxRole.Location = new System.Drawing.Point(68, 101);
            this.comboxRole.Name = "comboxRole";
            this.comboxRole.Size = new System.Drawing.Size(140, 25);
            this.comboxRole.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "身份：";
            // 
            // txtboxPSW
            // 
            this.txtboxPSW.Location = new System.Drawing.Point(68, 60);
            this.txtboxPSW.Name = "txtboxPSW";
            this.txtboxPSW.Size = new System.Drawing.Size(140, 23);
            this.txtboxPSW.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "密码：";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(68, 19);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.ReadOnly = true;
            this.txtboxID.Size = new System.Drawing.Size(140, 23);
            this.txtboxID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "用户名：";
            // 
            // frmTabLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLogin);
            this.Controls.Add(this.label1);
            this.Name = "frmTabLogin";
            this.Size = new System.Drawing.Size(560, 460);
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource tbLoginBindingSource;
        private SQLDataSetTableAdapters.tbLoginTableAdapter tbLoginTableAdapter;
        private SQLDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.ComboBox comboxRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxPSW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.Label label5;
    }
}
