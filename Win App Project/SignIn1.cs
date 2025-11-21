using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Win_App_Project
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities obj_DB = new Model.DB_ClinicEntities();
            Model.Tbl_Users obj_User = new Model.Tbl_Users() {
                Name = txt_Name.Text,
                Family=txt_Family.Text,
                NatinalCode=txt_NatinalCode.Text,
                
            };
            var user = obj_DB.Tbl_Users.FirstOrDefault(x => x.Name == obj_User.Name &&x.Family==obj_User.Family&&x.NatinalCode==obj_User.NatinalCode );


            if (user ==null)
            {
            Transfer.D1 = txt_Name.Text;
            Transfer.D2 = txt_Family.Text;
            Transfer.D3 = txt_NatinalCode.Text;
            Transfer.D4 = txt_Tel.Text;
                Sign_In_2 signin = new Sign_In_2();
                signin.ShowDialog();
                this.Close();

            }
            else
            {
                lbl_Warning.Visible = true;
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 5000;
                timer.Elapsed += delegate {
                    lbl_Warning.Visible = false;
                    timer.Stop();
                };
                timer.Start();
                
            }
        }
    }
}
