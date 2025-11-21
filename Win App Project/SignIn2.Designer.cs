namespace Win_App_Project
{
    partial class Sign_In_2
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
            this.btn_GeneratePass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NumberChar = new System.Windows.Forms.TextBox();
            this.chb_ShowPass = new System.Windows.Forms.CheckBox();
            this.lbl_Detail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Detail = new System.Windows.Forms.TextBox();
            this.btn_SaveUser = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_RepetedPass = new System.Windows.Forms.TextBox();
            this.grb_AutoGenerate = new System.Windows.Forms.GroupBox();
            this.txt_PersentOfSecurity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserNameFamily = new System.Windows.Forms.Label();
            this.grb_AutoGenerate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GeneratePass
            // 
            this.btn_GeneratePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_GeneratePass.Location = new System.Drawing.Point(62, 27);
            this.btn_GeneratePass.Name = "btn_GeneratePass";
            this.btn_GeneratePass.Size = new System.Drawing.Size(86, 24);
            this.btn_GeneratePass.TabIndex = 21;
            this.btn_GeneratePass.Text = "تولید رمز";
            this.btn_GeneratePass.UseVisualStyleBackColor = true;
            this.btn_GeneratePass.Click += new System.EventHandler(this.Btn_GeneratePass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(199, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = ": تعداد کارکتر";
            // 
            // txt_NumberChar
            // 
            this.txt_NumberChar.Location = new System.Drawing.Point(154, 28);
            this.txt_NumberChar.Name = "txt_NumberChar";
            this.txt_NumberChar.Size = new System.Drawing.Size(39, 20);
            this.txt_NumberChar.TabIndex = 19;
            // 
            // chb_ShowPass
            // 
            this.chb_ShowPass.AutoSize = true;
            this.chb_ShowPass.Location = new System.Drawing.Point(70, 117);
            this.chb_ShowPass.Name = "chb_ShowPass";
            this.chb_ShowPass.Size = new System.Drawing.Size(96, 17);
            this.chb_ShowPass.TabIndex = 18;
            this.chb_ShowPass.Text = "نمایش روز ورود";
            this.chb_ShowPass.UseVisualStyleBackColor = true;
            this.chb_ShowPass.CheckedChanged += new System.EventHandler(this.chb_ShowPass_CheckedChanged);
            // 
            // lbl_Detail
            // 
            this.lbl_Detail.AutoSize = true;
            this.lbl_Detail.Location = new System.Drawing.Point(180, 53);
            this.lbl_Detail.Name = "lbl_Detail";
            this.lbl_Detail.Size = new System.Drawing.Size(39, 13);
            this.lbl_Detail.TabIndex = 17;
            this.lbl_Detail.Text = "جزئیات";
            this.lbl_Detail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = ": رمز ورود";
            // 
            // txt_Detail
            // 
            this.txt_Detail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Detail.Location = new System.Drawing.Point(31, 69);
            this.txt_Detail.Multiline = true;
            this.txt_Detail.Name = "txt_Detail";
            this.txt_Detail.Size = new System.Drawing.Size(373, 155);
            this.txt_Detail.TabIndex = 14;
            this.txt_Detail.Visible = false;
            // 
            // btn_SaveUser
            // 
            this.btn_SaveUser.Enabled = false;
            this.btn_SaveUser.Location = new System.Drawing.Point(70, 140);
            this.btn_SaveUser.Name = "btn_SaveUser";
            this.btn_SaveUser.Size = new System.Drawing.Size(86, 22);
            this.btn_SaveUser.TabIndex = 13;
            this.btn_SaveUser.Text = "ثبت";
            this.btn_SaveUser.UseVisualStyleBackColor = true;
            this.btn_SaveUser.Click += new System.EventHandler(this.btn_SaveUser_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Enabled = false;
            this.txt_Pass.Location = new System.Drawing.Point(62, 65);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(106, 20);
            this.txt_Pass.TabIndex = 11;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = ": تکرار رمز ورود";
            // 
            // txt_RepetedPass
            // 
            this.txt_RepetedPass.Enabled = false;
            this.txt_RepetedPass.Location = new System.Drawing.Point(62, 91);
            this.txt_RepetedPass.Name = "txt_RepetedPass";
            this.txt_RepetedPass.Size = new System.Drawing.Size(106, 20);
            this.txt_RepetedPass.TabIndex = 22;
            this.txt_RepetedPass.UseSystemPasswordChar = true;
            // 
            // grb_AutoGenerate
            // 
            this.grb_AutoGenerate.Controls.Add(this.btn_GeneratePass);
            this.grb_AutoGenerate.Controls.Add(this.txt_NumberChar);
            this.grb_AutoGenerate.Controls.Add(this.label4);
            this.grb_AutoGenerate.Enabled = false;
            this.grb_AutoGenerate.Location = new System.Drawing.Point(436, 254);
            this.grb_AutoGenerate.Name = "grb_AutoGenerate";
            this.grb_AutoGenerate.Size = new System.Drawing.Size(257, 66);
            this.grb_AutoGenerate.TabIndex = 24;
            this.grb_AutoGenerate.TabStop = false;
            this.grb_AutoGenerate.Text = "تولید خودکار رمز";
            // 
            // txt_PersentOfSecurity
            // 
            this.txt_PersentOfSecurity.Location = new System.Drawing.Point(26, 65);
            this.txt_PersentOfSecurity.Name = "txt_PersentOfSecurity";
            this.txt_PersentOfSecurity.ReadOnly = true;
            this.txt_PersentOfSecurity.Size = new System.Drawing.Size(30, 20);
            this.txt_PersentOfSecurity.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.txt_PersentOfSecurity);
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.btn_SaveUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_RepetedPass);
            this.groupBox1.Controls.Add(this.chb_ShowPass);
            this.groupBox1.Location = new System.Drawing.Point(436, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 177);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = ": نام کاربری";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(62, 39);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(106, 20);
            this.txt_UserName.TabIndex = 26;
            this.txt_UserName.TextChanged += new System.EventHandler(this.Txt_UserName_TextChanged);
            // 
            // lbl_UserNameFamily
            // 
            this.lbl_UserNameFamily.AutoSize = true;
            this.lbl_UserNameFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_UserNameFamily.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_UserNameFamily.Location = new System.Drawing.Point(550, 25);
            this.lbl_UserNameFamily.Name = "lbl_UserNameFamily";
            this.lbl_UserNameFamily.Size = new System.Drawing.Size(57, 20);
            this.lbl_UserNameFamily.TabIndex = 26;
            this.lbl_UserNameFamily.Text = "label3";
            // 
            // Sign_In_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 332);
            this.Controls.Add(this.lbl_UserNameFamily);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_AutoGenerate);
            this.Controls.Add(this.lbl_Detail);
            this.Controls.Add(this.txt_Detail);
            this.Name = "Sign_In_2";
            this.Text = "Sign_In_2";
            this.Load += new System.EventHandler(this.Sign_In_2_Load);
            this.grb_AutoGenerate.ResumeLayout(false);
            this.grb_AutoGenerate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GeneratePass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NumberChar;
        private System.Windows.Forms.CheckBox chb_ShowPass;
        private System.Windows.Forms.Label lbl_Detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Detail;
        private System.Windows.Forms.Button btn_SaveUser;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_RepetedPass;
        private System.Windows.Forms.GroupBox grb_AutoGenerate;
        private System.Windows.Forms.TextBox txt_PersentOfSecurity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserNameFamily;
        private System.Windows.Forms.Label label3;
    }
}