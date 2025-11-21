namespace Win_App_Project
{
    partial class Entry_Servic
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Major = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteService = new System.Windows.Forms.Button();
            this.btn_SaveService = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dgv_Service = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "توضیح";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(600, 186);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(100, 20);
            this.txt_Comment.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "قیمت";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(600, 157);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "رشته";
            // 
            // txt_Major
            // 
            this.txt_Major.Location = new System.Drawing.Point(600, 131);
            this.txt_Major.Name = "txt_Major";
            this.txt_Major.Size = new System.Drawing.Size(100, 20);
            this.txt_Major.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "نام خدمات";
            // 
            // btn_DeleteService
            // 
            this.btn_DeleteService.Location = new System.Drawing.Point(38, 283);
            this.btn_DeleteService.Name = "btn_DeleteService";
            this.btn_DeleteService.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteService.TabIndex = 40;
            this.btn_DeleteService.Text = "حذف";
            this.btn_DeleteService.UseVisualStyleBackColor = true;
            this.btn_DeleteService.Click += new System.EventHandler(this.Btn_DeleteService_Click);
            // 
            // btn_SaveService
            // 
            this.btn_SaveService.Location = new System.Drawing.Point(613, 283);
            this.btn_SaveService.Name = "btn_SaveService";
            this.btn_SaveService.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveService.TabIndex = 39;
            this.btn_SaveService.Text = "ثبت";
            this.btn_SaveService.UseVisualStyleBackColor = true;
            this.btn_SaveService.Click += new System.EventHandler(this.Btn_SaveService_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(600, 103);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 38;
            // 
            // dgv_Service
            // 
            this.dgv_Service.AllowUserToResizeRows = false;
            this.dgv_Service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Service.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Service.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Service.EnableHeadersVisualStyles = false;
            this.dgv_Service.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Service.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Service.Location = new System.Drawing.Point(38, 71);
            this.dgv_Service.Name = "dgv_Service";
            this.dgv_Service.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Service.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Service.Size = new System.Drawing.Size(518, 174);
            this.dgv_Service.TabIndex = 37;
            // 
            // Entry_Servic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Major);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteService);
            this.Controls.Add(this.btn_SaveService);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dgv_Service);
            this.Name = "Entry_Servic";
            this.Text = "ویرایش سرویسها";
            this.Load += new System.EventHandler(this.Entry_Servic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Major;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteService;
        private System.Windows.Forms.Button btn_SaveService;
        private System.Windows.Forms.TextBox txt_Name;
        private MetroFramework.Controls.MetroGrid dgv_Service;
    }
}