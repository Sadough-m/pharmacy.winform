using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_App_Project
{
    public partial class Wellcome : Form
    {
        public Wellcome()
        {
            InitializeComponent();
        }

        private void Llbl_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In signIn = new Sign_In();
            signIn.ShowDialog();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities obj_Db = new Model.DB_ClinicEntities();
            var user = obj_Db.Tbl_Logins.SingleOrDefault(x => x.UserName == txt_UserName.Text);
            if (user!=null)
            {
                byte[] b = System.Text.Encoding.UTF8.GetBytes(txt_Pass.Text);
                System.Security.Cryptography.SHA1 Hash = System.Security.Cryptography.SHA1.Create();
                byte[] hashed = Hash.ComputeHash(b);
                var pass = Convert.ToBase64String(hashed);
                if (pass==user.Pass)
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbl_WrongPass.Visible = true;
                    lbl_WrongPass.Text = "رمز ورود اشتباه است";
                    System.Timers.Timer timer = new System.Timers.Timer();
                    timer.Interval = 5000;
                    timer.Elapsed += delegate {
                        lbl_WrongPass.Visible = false;
                        timer.Stop();
                    };
                    timer.Start();
                }
            }
            else
            {
                lbl_WrongPass.Visible = true;
                lbl_WrongPass.Text = "رمز ورود یا نام کاربری اشتباه است";
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 5000;
                timer.Elapsed += delegate {
                    lbl_WrongPass.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void chb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPass.Checked == true)
            {

                txt_Pass.UseSystemPasswordChar = false;
            }
            else
            {

                txt_Pass.UseSystemPasswordChar = true;
            }
        }
    }
}
