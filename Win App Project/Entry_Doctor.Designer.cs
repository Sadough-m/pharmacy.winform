namespace Win_App_Project
{
    partial class Entry_Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_DeleteDoctor = new System.Windows.Forms.Button();
            this.btn_SaveDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BirthDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NatinalCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dgv_Doctors = new MetroFramework.Controls.MetroGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Major = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Degre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DeleteDoctor
            // 
            this.btn_DeleteDoctor.Location = new System.Drawing.Point(52, 392);
            this.btn_DeleteDoctor.Name = "btn_DeleteDoctor";
            this.btn_DeleteDoctor.Size = new System.Drawing.Size(56, 23);
            this.btn_DeleteDoctor.TabIndex = 25;
            this.btn_DeleteDoctor.Text = "حذف";
            this.btn_DeleteDoctor.UseVisualStyleBackColor = true;
            this.btn_DeleteDoctor.Click += new System.EventHandler(this.Btn_DeleteDoctor_Click);
            // 
            // btn_SaveDoctor
            // 
            this.btn_SaveDoctor.Location = new System.Drawing.Point(138, 146);
            this.btn_SaveDoctor.Name = "btn_SaveDoctor";
            this.btn_SaveDoctor.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveDoctor.TabIndex = 24;
            this.btn_SaveDoctor.Text = "ثبت";
            this.btn_SaveDoctor.UseVisualStyleBackColor = true;
            this.btn_SaveDoctor.Click += new System.EventHandler(this.Btn_SaveDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "تاریخ تولد";
            // 
            // txt_BirthDate
            // 
            this.txt_BirthDate.Location = new System.Drawing.Point(29, 57);
            this.txt_BirthDate.Name = "txt_BirthDate";
            this.txt_BirthDate.Size = new System.Drawing.Size(100, 20);
            this.txt_BirthDate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "تلفن";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(29, 28);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(100, 20);
            this.txt_Telephone.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "کد ملی";
            // 
            // txt_NatinalCode
            // 
            this.txt_NatinalCode.Location = new System.Drawing.Point(215, 96);
            this.txt_NatinalCode.Name = "txt_NatinalCode";
            this.txt_NatinalCode.Size = new System.Drawing.Size(100, 20);
            this.txt_NatinalCode.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "فامیلی";
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(215, 61);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(100, 20);
            this.txt_Family.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "نام";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(215, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 14;
            // 
            // dgv_Doctors
            // 
            this.dgv_Doctors.AllowUserToResizeRows = false;
            this.dgv_Doctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Doctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Doctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Doctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Doctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Doctors.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Doctors.EnableHeadersVisualStyles = false;
            this.dgv_Doctors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Doctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Doctors.Location = new System.Drawing.Point(29, 52);
            this.dgv_Doctors.Name = "dgv_Doctors";
            this.dgv_Doctors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Doctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Doctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Doctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Doctors.Size = new System.Drawing.Size(736, 174);
            this.dgv_Doctors.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "رشته";
            // 
            // txt_Major
            // 
            this.txt_Major.Location = new System.Drawing.Point(29, 83);
            this.txt_Major.Name = "txt_Major";
            this.txt_Major.Size = new System.Drawing.Size(100, 20);
            this.txt_Major.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "مدرک";
            // 
            // txt_Degre
            // 
            this.txt_Degre.Location = new System.Drawing.Point(29, 109);
            this.txt_Degre.Name = "txt_Degre";
            this.txt_Degre.Size = new System.Drawing.Size(100, 20);
            this.txt_Degre.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Telephone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Degre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Family);
            this.groupBox1.Controls.Add(this.txt_Major);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NatinalCode);
            this.groupBox1.Controls.Add(this.btn_SaveDoctor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_BirthDate);
            this.groupBox1.Location = new System.Drawing.Point(366, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 173);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // Entry_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteDoctor);
            this.Controls.Add(this.dgv_Doctors);
            this.Name = "Entry_Doctor";
            this.Text = " ویرایش اطلاعات دکترها";
            this.Load += new System.EventHandler(this.Entry_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteDoctor;
        private System.Windows.Forms.Button btn_SaveDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NatinalCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private MetroFramework.Controls.MetroGrid dgv_Doctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Major;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Degre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}