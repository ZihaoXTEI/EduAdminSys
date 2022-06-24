namespace EduAdminSys.frmMang.classes
{
    partial class frmTabCourse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtboxCouHour1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butCheck = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.txtboxCouName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtboxCouHour2 = new System.Windows.Forms.TextBox();
            this.comboxCredit2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboxCouType2 = new System.Windows.Forms.ComboBox();
            this.comboxClass2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxCouName2 = new System.Windows.Forms.TextBox();
            this.comboxDepart2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtboxDepart = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtboxCourseNo = new System.Windows.Forms.TextBox();
            this.txtboxCouType = new System.Windows.Forms.TextBox();
            this.txtboxCredit = new System.Windows.Forms.TextBox();
            this.txtboxClassNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程信息管理";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxClassNum);
            this.groupBox1.Controls.Add(this.txtboxCredit);
            this.groupBox1.Controls.Add(this.txtboxCouType);
            this.groupBox1.Controls.Add(this.txtboxDepart);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtboxCouHour1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.butCheck);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.txtboxCouName1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "节";
            // 
            // txtboxCouHour1
            // 
            this.txtboxCouHour1.Location = new System.Drawing.Point(275, 62);
            this.txtboxCouHour1.Name = "txtboxCouHour1";
            this.txtboxCouHour1.Size = new System.Drawing.Size(71, 23);
            this.txtboxCouHour1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "开班数：";
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(401, 27);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(75, 23);
            this.butCheck.TabIndex = 11;
            this.butCheck.Text = "查找";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.ButCheck_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(401, 81);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 10;
            this.butUpdate.Text = "修改";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.ButUpdate_Click);
            // 
            // txtboxCouName1
            // 
            this.txtboxCouName1.Location = new System.Drawing.Point(275, 27);
            this.txtboxCouName1.Name = "txtboxCouName1";
            this.txtboxCouName1.Size = new System.Drawing.Size(110, 23);
            this.txtboxCouName1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "课程类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "课时：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "学分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "课程名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "院系";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxCourseNo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtboxCouHour2);
            this.groupBox2.Controls.Add(this.comboxCredit2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboxCouType2);
            this.groupBox2.Controls.Add(this.comboxClass2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtboxCouName2);
            this.groupBox2.Controls.Add(this.comboxDepart2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(36, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "增加课程";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "节";
            // 
            // txtboxCouHour2
            // 
            this.txtboxCouHour2.Location = new System.Drawing.Point(275, 103);
            this.txtboxCouHour2.Name = "txtboxCouHour2";
            this.txtboxCouHour2.Size = new System.Drawing.Size(71, 23);
            this.txtboxCouHour2.TabIndex = 30;
            // 
            // comboxCredit2
            // 
            this.comboxCredit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCredit2.FormattingEnabled = true;
            this.comboxCredit2.Location = new System.Drawing.Point(79, 64);
            this.comboxCredit2.Name = "comboxCredit2";
            this.comboxCredit2.Size = new System.Drawing.Size(106, 25);
            this.comboxCredit2.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "增加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // comboxCouType2
            // 
            this.comboxCouType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCouType2.FormattingEnabled = true;
            this.comboxCouType2.Location = new System.Drawing.Point(79, 103);
            this.comboxCouType2.Name = "comboxCouType2";
            this.comboxCouType2.Size = new System.Drawing.Size(106, 25);
            this.comboxCouType2.TabIndex = 27;
            // 
            // comboxClass2
            // 
            this.comboxClass2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxClass2.FormattingEnabled = true;
            this.comboxClass2.Location = new System.Drawing.Point(79, 142);
            this.comboxClass2.Name = "comboxClass2";
            this.comboxClass2.Size = new System.Drawing.Size(63, 25);
            this.comboxClass2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "开班数：";
            // 
            // txtboxCouName2
            // 
            this.txtboxCouName2.Location = new System.Drawing.Point(275, 64);
            this.txtboxCouName2.Name = "txtboxCouName2";
            this.txtboxCouName2.Size = new System.Drawing.Size(100, 23);
            this.txtboxCouName2.TabIndex = 24;
            // 
            // comboxDepart2
            // 
            this.comboxDepart2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepart2.FormattingEnabled = true;
            this.comboxDepart2.Location = new System.Drawing.Point(64, 25);
            this.comboxDepart2.Name = "comboxDepart2";
            this.comboxDepart2.Size = new System.Drawing.Size(121, 25);
            this.comboxDepart2.TabIndex = 20;
            this.comboxDepart2.SelectedIndexChanged += new System.EventHandler(this.ComboxDepart2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "课程类型：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "课时：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "学分";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "课程名称：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "院系";
            // 
            // txtboxDepart
            // 
            this.txtboxDepart.Location = new System.Drawing.Point(64, 30);
            this.txtboxDepart.Name = "txtboxDepart";
            this.txtboxDepart.ReadOnly = true;
            this.txtboxDepart.Size = new System.Drawing.Size(129, 23);
            this.txtboxDepart.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(210, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "课程编号：";
            // 
            // txtboxCourseNo
            // 
            this.txtboxCourseNo.Location = new System.Drawing.Point(275, 25);
            this.txtboxCourseNo.Name = "txtboxCourseNo";
            this.txtboxCourseNo.ReadOnly = true;
            this.txtboxCourseNo.Size = new System.Drawing.Size(100, 23);
            this.txtboxCourseNo.TabIndex = 33;
            // 
            // txtboxCouType
            // 
            this.txtboxCouType.Location = new System.Drawing.Point(92, 108);
            this.txtboxCouType.Name = "txtboxCouType";
            this.txtboxCouType.ReadOnly = true;
            this.txtboxCouType.Size = new System.Drawing.Size(100, 23);
            this.txtboxCouType.TabIndex = 20;
            // 
            // txtboxCredit
            // 
            this.txtboxCredit.Location = new System.Drawing.Point(92, 69);
            this.txtboxCredit.Name = "txtboxCredit";
            this.txtboxCredit.ReadOnly = true;
            this.txtboxCredit.Size = new System.Drawing.Size(101, 23);
            this.txtboxCredit.TabIndex = 21;
            // 
            // txtboxClassNum
            // 
            this.txtboxClassNum.Location = new System.Drawing.Point(92, 147);
            this.txtboxClassNum.Name = "txtboxClassNum";
            this.txtboxClassNum.ReadOnly = true;
            this.txtboxClassNum.Size = new System.Drawing.Size(100, 23);
            this.txtboxClassNum.TabIndex = 22;
            // 
            // frmTabCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTabCourse";
            this.Size = new System.Drawing.Size(560, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtboxCouHour1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.TextBox txtboxCouName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtboxCouHour2;
        private System.Windows.Forms.ComboBox comboxCredit2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboxCouType2;
        private System.Windows.Forms.ComboBox comboxClass2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxCouName2;
        private System.Windows.Forms.ComboBox comboxDepart2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtboxDepart;
        private System.Windows.Forms.TextBox txtboxCourseNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtboxCredit;
        private System.Windows.Forms.TextBox txtboxCouType;
        private System.Windows.Forms.TextBox txtboxClassNum;
    }
}
