namespace Win_App_Project
{
    partial class Entry_Section
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
            this.btn_DeleteSection = new System.Windows.Forms.Button();
            this.btn_SaveSection = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dgv_Section = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumVisitRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumSurgeryRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NumBed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteSection
            // 
            this.btn_DeleteSection.Location = new System.Drawing.Point(71, 236);
            this.btn_DeleteSection.Name = "btn_DeleteSection";
            this.btn_DeleteSection.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteSection.TabIndex = 29;
            this.btn_DeleteSection.TabStop = false;
            this.btn_DeleteSection.Text = "حذف";
            this.btn_DeleteSection.UseVisualStyleBackColor = true;
            this.btn_DeleteSection.Click += new System.EventHandler(this.Btn_DeleteSection_Click);
            // 
            // btn_SaveSection
            // 
            this.btn_SaveSection.Location = new System.Drawing.Point(588, 236);
            this.btn_SaveSection.Name = "btn_SaveSection";
            this.btn_SaveSection.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveSection.TabIndex = 5;
            this.btn_SaveSection.Text = "ثبت";
            this.btn_SaveSection.UseVisualStyleBackColor = true;
            this.btn_SaveSection.Click += new System.EventHandler(this.Btn_SaveSection_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(574, 82);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // dgv_Section
            // 
            this.dgv_Section.AllowUserToResizeRows = false;
            this.dgv_Section.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Section.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Section.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Section.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Section.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Section.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Section.EnableHeadersVisualStyles = false;
            this.dgv_Section.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Section.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Section.Location = new System.Drawing.Point(71, 46);
            this.dgv_Section.Name = "dgv_Section";
            this.dgv_Section.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Section.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Section.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Section.Size = new System.Drawing.Size(436, 174);
            this.dgv_Section.TabIndex = 26;
            this.dgv_Section.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "نام بخش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "تعداد اتاق ویزیت";
            // 
            // txt_NumVisitRoom
            // 
            this.txt_NumVisitRoom.Location = new System.Drawing.Point(574, 110);
            this.txt_NumVisitRoom.Name = "txt_NumVisitRoom";
            this.txt_NumVisitRoom.Size = new System.Drawing.Size(100, 20);
            this.txt_NumVisitRoom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "تعداد اتاق عمل";
            // 
            // txt_NumSurgeryRoom
            // 
            this.txt_NumSurgeryRoom.Location = new System.Drawing.Point(574, 136);
            this.txt_NumSurgeryRoom.Name = "txt_NumSurgeryRoom";
            this.txt_NumSurgeryRoom.Size = new System.Drawing.Size(100, 20);
            this.txt_NumSurgeryRoom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "تعداد تخت";
            // 
            // txt_NumBed
            // 
            this.txt_NumBed.Location = new System.Drawing.Point(574, 165);
            this.txt_NumBed.Name = "txt_NumBed";
            this.txt_NumBed.Size = new System.Drawing.Size(100, 20);
            this.txt_NumBed.TabIndex = 4;
            this.txt_NumBed.TextChanged += new System.EventHandler(this.Txt_NumBed_TextChanged);
            // 
            // Entry_Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NumBed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NumSurgeryRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NumVisitRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteSection);
            this.Controls.Add(this.btn_SaveSection);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dgv_Section);
            this.Name = "Entry_Section";
            this.Text = "ویرایش بخشها";
            this.Load += new System.EventHandler(this.Entry_Section_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteSection;
        private System.Windows.Forms.Button btn_SaveSection;
        private System.Windows.Forms.TextBox txt_Name;
        private MetroFramework.Controls.MetroGrid dgv_Section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NumVisitRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NumSurgeryRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NumBed;
    }
}