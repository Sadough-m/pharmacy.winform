namespace Win_App_Project
{
    partial class Wellcome
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_WrongPass = new System.Windows.Forms.Label();
            this.Llbl_SignIn = new System.Windows.Forms.LinkLabel();
            this.chb_ShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(298, 115);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ": نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ": رمز ورود";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(298, 141);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(308, 191);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "ورود";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_WrongPass
            // 
            this.lbl_WrongPass.AutoSize = true;
            this.lbl_WrongPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_WrongPass.Location = new System.Drawing.Point(306, 96);
            this.lbl_WrongPass.Name = "lbl_WrongPass";
            this.lbl_WrongPass.Size = new System.Drawing.Size(157, 13);
            this.lbl_WrongPass.TabIndex = 5;
            this.lbl_WrongPass.Text = "نام کاربری یا پسورد اشتباه است";
            this.lbl_WrongPass.Visible = false;
            // 
            // Llbl_SignIn
            // 
            this.Llbl_SignIn.AutoSize = true;
            this.Llbl_SignIn.Location = new System.Drawing.Point(423, 196);
            this.Llbl_SignIn.Name = "Llbl_SignIn";
            this.Llbl_SignIn.Size = new System.Drawing.Size(40, 13);
            this.Llbl_SignIn.TabIndex = 6;
            this.Llbl_SignIn.TabStop = true;
            this.Llbl_SignIn.Text = "Sign In";
            this.Llbl_SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbl_SignIn_LinkClicked);
            // 
            // chb_ShowPass
            // 
            this.chb_ShowPass.AutoSize = true;
            this.chb_ShowPass.Location = new System.Drawing.Point(301, 168);
            this.chb_ShowPass.Name = "chb_ShowPass";
            this.chb_ShowPass.Size = new System.Drawing.Size(96, 17);
            this.chb_ShowPass.TabIndex = 19;
            this.chb_ShowPass.Text = "نمایش روز ورود";
            this.chb_ShowPass.UseVisualStyleBackColor = true;
            this.chb_ShowPass.CheckedChanged += new System.EventHandler(this.chb_ShowPass_CheckedChanged);
            // 
            // Wellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 295);
            this.Controls.Add(this.chb_ShowPass);
            this.Controls.Add(this.Llbl_SignIn);
            this.Controls.Add(this.lbl_WrongPass);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Wellcome";
            this.Text = "Wellcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_WrongPass;
        private System.Windows.Forms.LinkLabel Llbl_SignIn;
        private System.Windows.Forms.CheckBox chb_ShowPass;
    }
}