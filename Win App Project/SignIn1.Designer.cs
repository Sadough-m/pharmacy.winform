namespace Win_App_Project
{
    partial class Sign_In
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NatinalCode = new System.Windows.Forms.TextBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ": نام";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(228, 76);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ": نام خانوادگی";
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(228, 102);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(100, 20);
            this.txt_Family.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ": تلفن";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(228, 158);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ": کد ملی";
            // 
            // txt_NatinalCode
            // 
            this.txt_NatinalCode.Location = new System.Drawing.Point(228, 132);
            this.txt_NatinalCode.Name = "txt_NatinalCode";
            this.txt_NatinalCode.Size = new System.Drawing.Size(100, 20);
            this.txt_NatinalCode.TabIndex = 10;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(242, 180);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(75, 23);
            this.btn_Continue.TabIndex = 19;
            this.btn_Continue.Text = "ادامه";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(225, 51);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(118, 13);
            this.lbl_Warning.TabIndex = 20;
            this.lbl_Warning.Text = "شما قبلا ثبت نام شده اید";
            this.lbl_Warning.Visible = false;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 345);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NatinalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Family);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Name = "Sign_In";
            this.Text = "Sign_In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NatinalCode;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Label lbl_Warning;
    }
}