namespace Win_App_Project
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_pationtList = new MetroFramework.Controls.MetroGrid();
            this.textPationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPBirthDate = new System.Windows.Forms.TextBox();
            this.txtePNatinalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtePFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SavePation = new System.Windows.Forms.Button();
            this.btn_DeletePationt = new System.Windows.Forms.Button();
            this.txt_SearchWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_SearchFild = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pationtList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pationtList
            // 
            this.dgv_pationtList.AllowUserToResizeRows = false;
            this.dgv_pationtList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_pationtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pationtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_pationtList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pationtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pationtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pationtList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pationtList.EnableHeadersVisualStyles = false;
            this.dgv_pationtList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_pationtList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_pationtList.Location = new System.Drawing.Point(31, 12);
            this.dgv_pationtList.Name = "dgv_pationtList";
            this.dgv_pationtList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pationtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pationtList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_pationtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pationtList.Size = new System.Drawing.Size(687, 150);
            this.dgv_pationtList.TabIndex = 0;
            this.dgv_pationtList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_pationtList_RowEnter);
            // 
            // textPationName
            // 
            this.textPationName.Location = new System.Drawing.Point(203, 20);
            this.textPationName.Name = "textPationName";
            this.textPationName.Size = new System.Drawing.Size(100, 20);
            this.textPationName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تلفن";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(17, 20);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "تاریخ تولد";
            // 
            // txtPBirthDate
            // 
            this.txtPBirthDate.Location = new System.Drawing.Point(17, 49);
            this.txtPBirthDate.Name = "txtPBirthDate";
            this.txtPBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtPBirthDate.TabIndex = 9;
            // 
            // txtePNatinalCode
            // 
            this.txtePNatinalCode.Location = new System.Drawing.Point(203, 88);
            this.txtePNatinalCode.Name = "txtePNatinalCode";
            this.txtePNatinalCode.Size = new System.Drawing.Size(100, 20);
            this.txtePNatinalCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "کد ملی";
            // 
            // txtePFamily
            // 
            this.txtePFamily.Location = new System.Drawing.Point(203, 53);
            this.txtePFamily.Name = "txtePFamily";
            this.txtePFamily.Size = new System.Drawing.Size(100, 20);
            this.txtePFamily.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "فامیلی";
            // 
            // btn_SavePation
            // 
            this.btn_SavePation.Location = new System.Drawing.Point(30, 85);
            this.btn_SavePation.Name = "btn_SavePation";
            this.btn_SavePation.Size = new System.Drawing.Size(75, 23);
            this.btn_SavePation.TabIndex = 11;
            this.btn_SavePation.Text = "ثبت";
            this.btn_SavePation.UseVisualStyleBackColor = true;
            this.btn_SavePation.Click += new System.EventHandler(this.btn_SavePation_Click);
            // 
            // btn_DeletePationt
            // 
            this.btn_DeletePationt.Location = new System.Drawing.Point(50, 265);
            this.btn_DeletePationt.Name = "btn_DeletePationt";
            this.btn_DeletePationt.Size = new System.Drawing.Size(56, 23);
            this.btn_DeletePationt.TabIndex = 12;
            this.btn_DeletePationt.Text = "حذف";
            this.btn_DeletePationt.UseVisualStyleBackColor = true;
            this.btn_DeletePationt.Click += new System.EventHandler(this.Btn_DeletePationt_Click);
            // 
            // txt_SearchWord
            // 
            this.txt_SearchWord.Location = new System.Drawing.Point(16, 39);
            this.txt_SearchWord.Name = "txt_SearchWord";
            this.txt_SearchWord.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchWord.TabIndex = 13;
            this.txt_SearchWord.TextChanged += new System.EventHandler(this.Txt_SearchWord_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtePFamily);
            this.groupBox1.Controls.Add(this.textPationName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_SavePation);
            this.groupBox1.Controls.Add(this.txtePNatinalCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPBirthDate);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(352, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 130);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // cmb_SearchFild
            // 
            this.cmb_SearchFild.FormattingEnabled = true;
            this.cmb_SearchFild.Location = new System.Drawing.Point(148, 39);
            this.cmb_SearchFild.Name = "cmb_SearchFild";
            this.cmb_SearchFild.Size = new System.Drawing.Size(121, 21);
            this.cmb_SearchFild.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_SearchFild);
            this.groupBox2.Controls.Add(this.txt_SearchWord);
            this.groupBox2.Location = new System.Drawing.Point(41, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فیلتر کردن";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeletePationt);
            this.Controls.Add(this.dgv_pationtList);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pationtList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgv_pationtList;
        private System.Windows.Forms.TextBox textPationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPBirthDate;
        private System.Windows.Forms.TextBox txtePNatinalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtePFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SavePation;
        private System.Windows.Forms.Button btn_DeletePationt;
        private System.Windows.Forms.TextBox txt_SearchWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_SearchFild;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}