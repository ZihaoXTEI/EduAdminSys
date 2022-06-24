namespace EduAdminSys.frmStudt
{
    partial class frmStudCancelCou
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCanCou = new System.Windows.Forms.DataGridView();
            this.classno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceedit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coutype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanCou)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "落选课程信息";
            // 
            // dgvCanCou
            // 
            this.dgvCanCou.AllowUserToAddRows = false;
            this.dgvCanCou.AllowUserToDeleteRows = false;
            this.dgvCanCou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanCou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classno,
            this.classname,
            this.ceedit,
            this.couhour,
            this.coutype,
            this.depart});
            this.dgvCanCou.Location = new System.Drawing.Point(90, 55);
            this.dgvCanCou.Name = "dgvCanCou";
            this.dgvCanCou.ReadOnly = true;
            this.dgvCanCou.RowTemplate.Height = 23;
            this.dgvCanCou.Size = new System.Drawing.Size(755, 367);
            this.dgvCanCou.TabIndex = 1;
            // 
            // classno
            // 
            this.classno.DataPropertyName = "classno";
            this.classno.HeaderText = "班级编号";
            this.classno.Name = "classno";
            this.classno.ReadOnly = true;
            // 
            // classname
            // 
            this.classname.DataPropertyName = "classname";
            this.classname.HeaderText = "班级名称";
            this.classname.Name = "classname";
            this.classname.ReadOnly = true;
            this.classname.Width = 200;
            // 
            // ceedit
            // 
            this.ceedit.DataPropertyName = "credit";
            this.ceedit.HeaderText = "学分";
            this.ceedit.Name = "ceedit";
            this.ceedit.ReadOnly = true;
            // 
            // couhour
            // 
            this.couhour.DataPropertyName = "couhour";
            this.couhour.HeaderText = "课程学时";
            this.couhour.Name = "couhour";
            this.couhour.ReadOnly = true;
            // 
            // coutype
            // 
            this.coutype.DataPropertyName = "coutype";
            this.coutype.HeaderText = "课程类型";
            this.coutype.Name = "coutype";
            this.coutype.ReadOnly = true;
            // 
            // depart
            // 
            this.depart.DataPropertyName = "departname";
            this.depart.HeaderText = "院系";
            this.depart.Name = "depart";
            this.depart.ReadOnly = true;
            // 
            // frmStudCancelCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCanCou);
            this.Controls.Add(this.label1);
            this.Name = "frmStudCancelCou";
            this.Size = new System.Drawing.Size(930, 460);
            this.Load += new System.EventHandler(this.FrmStudCancelCou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanCou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCanCou;
        private System.Windows.Forms.DataGridViewTextBoxColumn classno;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn couhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutype;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart;
    }
}
