namespace Win_App_Project
{
    partial class Entry_VisitTime
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
            this.cmb_GetDocSecServ = new System.Windows.Forms.ComboBox();
            this.cmb_Pationt = new System.Windows.Forms.ComboBox();
            this.btn_InsertVisitTime = new System.Windows.Forms.Button();
            this.txt_EnterviweDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_VisitTime = new System.Windows.Forms.TextBox();
            this.dgv_VisitTime = new MetroFramework.Controls.MetroGrid();
            this.btn_DeleteVisitTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisitTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_GetDocSecServ
            // 
            this.cmb_GetDocSecServ.FormattingEnabled = true;
            this.cmb_GetDocSecServ.Location = new System.Drawing.Point(271, 63);
            this.cmb_GetDocSecServ.Name = "cmb_GetDocSecServ";
            this.cmb_GetDocSecServ.Size = new System.Drawing.Size(212, 21);
            this.cmb_GetDocSecServ.TabIndex = 0;
            // 
            // cmb_Pationt
            // 
            this.cmb_Pationt.FormattingEnabled = true;
            this.cmb_Pationt.Location = new System.Drawing.Point(271, 36);
            this.cmb_Pationt.Name = "cmb_Pationt";
            this.cmb_Pationt.Size = new System.Drawing.Size(212, 21);
            this.cmb_Pationt.TabIndex = 1;
            // 
            // btn_InsertVisitTime
            // 
            this.btn_InsertVisitTime.Location = new System.Drawing.Point(1, 50);
            this.btn_InsertVisitTime.Name = "btn_InsertVisitTime";
            this.btn_InsertVisitTime.Size = new System.Drawing.Size(69, 23);
            this.btn_InsertVisitTime.TabIndex = 2;
            this.btn_InsertVisitTime.Text = "ثبت";
            this.btn_InsertVisitTime.UseVisualStyleBackColor = true;
            this.btn_InsertVisitTime.Click += new System.EventHandler(this.Btn_InsertVisitTime_Click);
            // 
            // txt_EnterviweDate
            // 
            this.txt_EnterviweDate.Location = new System.Drawing.Point(102, 35);
            this.txt_EnterviweDate.Name = "txt_EnterviweDate";
            this.txt_EnterviweDate.Size = new System.Drawing.Size(87, 20);
            this.txt_EnterviweDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاریخ مراجعه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تاریخ ویزیت";
            // 
            // txt_VisitTime
            // 
            this.txt_VisitTime.Location = new System.Drawing.Point(102, 64);
            this.txt_VisitTime.Name = "txt_VisitTime";
            this.txt_VisitTime.Size = new System.Drawing.Size(87, 20);
            this.txt_VisitTime.TabIndex = 5;
            // 
            // dgv_VisitTime
            // 
            this.dgv_VisitTime.AllowUserToResizeRows = false;
            this.dgv_VisitTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_VisitTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_VisitTime.CausesValidation = false;
            this.dgv_VisitTime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_VisitTime.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_VisitTime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VisitTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VisitTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VisitTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VisitTime.EnableHeadersVisualStyles = false;
            this.dgv_VisitTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_VisitTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_VisitTime.Location = new System.Drawing.Point(47, 59);
            this.dgv_VisitTime.Name = "dgv_VisitTime";
            this.dgv_VisitTime.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VisitTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VisitTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_VisitTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VisitTime.Size = new System.Drawing.Size(673, 208);
            this.dgv_VisitTime.TabIndex = 7;
            // 
            // btn_DeleteVisitTime
            // 
            this.btn_DeleteVisitTime.Location = new System.Drawing.Point(22, 322);
            this.btn_DeleteVisitTime.Name = "btn_DeleteVisitTime";
            this.btn_DeleteVisitTime.Size = new System.Drawing.Size(56, 23);
            this.btn_DeleteVisitTime.TabIndex = 8;
            this.btn_DeleteVisitTime.Text = "حذف";
            this.btn_DeleteVisitTime.UseVisualStyleBackColor = true;
            this.btn_DeleteVisitTime.Click += new System.EventHandler(this.Btn_DeleteVisitTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EnterviweDate);
            this.groupBox1.Controls.Add(this.cmb_GetDocSecServ);
            this.groupBox1.Controls.Add(this.cmb_Pationt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_InsertVisitTime);
            this.groupBox1.Controls.Add(this.txt_VisitTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(253, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات";
            // 
            // Entry_VisitTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_DeleteVisitTime);
            this.Controls.Add(this.dgv_VisitTime);
            this.Name = "Entry_VisitTime";
            this.Text = "ویرایش اطلاعت ویزیت";
            this.Load += new System.EventHandler(this.Entry_VisitTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisitTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_GetDocSecServ;
        private System.Windows.Forms.ComboBox cmb_Pationt;
        private System.Windows.Forms.Button btn_InsertVisitTime;
        private System.Windows.Forms.TextBox txt_EnterviweDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VisitTime;
        private System.Windows.Forms.Button btn_DeleteVisitTime;
        private MetroFramework.Controls.MetroGrid dgv_VisitTime;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}