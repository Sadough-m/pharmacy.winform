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
    public partial class Sign_In_2 : Form
    {
        public Sign_In_2()
        {
            InitializeComponent();
        }

            Functionss func = new Functionss();
        Model.DB_ClinicEntities obj_Db = new Model.DB_ClinicEntities();

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            txt_PersentOfSecurity.Text = func.SecurityLevel(func.TypeOfText(txt_Pass.Text).Item2).Item2.ToString();
            txt_Detail.Text = func.SecurityLevel(func.TypeOfText(txt_Pass.Text).Item2).Item1;
            if (txt_PersentOfSecurity.Text==null)
            {
                txt_Detail.Visible = false;
                btn_SaveUser.Enabled = false;


            }
            else if (Convert.ToInt32(txt_PersentOfSecurity.Text)<=25)
            {
                txt_PersentOfSecurity.ForeColor = Color.Red;
                txt_Detail.ForeColor = Color.Red;
                txt_Detail.Visible = true;
                btn_SaveUser.Enabled = false;

            }
            else if (Convert.ToInt32(txt_PersentOfSecurity.Text) <= 50)
            {
                txt_PersentOfSecurity.ForeColor = Color.OrangeRed;
                txt_Detail.ForeColor = Color.OrangeRed;
                txt_Detail.Visible = true;
                btn_SaveUser.Enabled = false;

            }
            else if (Convert.ToInt32(txt_PersentOfSecurity.Text) <= 75)
            {
                txt_PersentOfSecurity.ForeColor = Color.LawnGreen;
                txt_Detail.ForeColor = Color.LawnGreen;
                txt_Detail.Visible = false;
                btn_SaveUser.Enabled = true;
            }
            else
            {
                txt_PersentOfSecurity.ForeColor = Color.Green;
                txt_Detail.Visible = false;
                btn_SaveUser.Enabled = true;
            }
        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {
            if (txt_Pass.Text == txt_RepetedPass.Text)
            {
                lbl_Detail.Visible = false;
                txt_Detail.Visible = false;
                Model.Tbl_Users obj_User = new Model.Tbl_Users() {
                    Name = Transfer.D1,
                    Family = Transfer.D2,
                    NatinalCode = Transfer.D3,
                    Tel = Transfer.D4,
                };

                Model.Tbl_Logins obj_login = new Model.Tbl_Logins();
                obj_Db.Tbl_Users.Add(obj_User);
                var i1 = obj_Db.SaveChanges();
                if (i1 != 0)
                {

                
                obj_login.RoleId = 1;
                obj_login.UserId = obj_Db.Tbl_Users.Max(x => x.Id);
                obj_login.UserName = txt_UserName.Text;
                byte[] b = System.Text.Encoding.UTF8.GetBytes(txt_Pass.Text);
                System.Security.Cryptography.SHA1 Hash = System.Security.Cryptography.SHA1.Create();
                byte[] hashed = Hash.ComputeHash(b);
                obj_login.Pass = Convert.ToBase64String(hashed);
                obj_Db.Tbl_Logins.Add(obj_login);
                var i2 = obj_Db.SaveChanges();
                if (i2 != 0)
                {
                    MessageBox.Show("Successfull");
                    Wellcome well = new Wellcome();
                    well.Show();
                    this.Close();
                        Wellcome wellc = new Wellcome();
                        wellc.ShowDialog();
                }
              }

            }
            else
            {

                lbl_Detail.Visible = true;
                txt_Detail.Visible = true;
                lbl_Detail.ForeColor = Color.Red;
                txt_Detail.ForeColor = Color.Red;
                txt_Detail.Text = ". تکرار رمز عبور اشتباه می باشد";
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 4000;
                timer.Elapsed += delegate {

                    lbl_Detail.Visible = false;
                    txt_Detail.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void Txt_UserName_TextChanged(object sender, EventArgs e)
        {
            var dubleUser = obj_Db.Tbl_Logins.Where(x => x.UserName == txt_UserName.Text).ToList();
               if (txt_UserName.Text != "")
               {
                if (dubleUser.Count == 0)
                {

                    txt_Pass.Enabled = true;
                    txt_RepetedPass.Enabled = true;
                    txt_Detail.Visible = false;
                    lbl_Detail.Visible = false;
                    grb_AutoGenerate.Enabled = true;
                }
                else
                {
                    lbl_Detail.Visible = true;
                    txt_Detail.Visible = true;
                    txt_Detail.ForeColor = Color.Red;
                    txt_Detail.Text = ".نام کاربری تکراری است";
                    txt_Pass.Enabled = false;
                    txt_RepetedPass.Enabled = false;
                    grb_AutoGenerate.Enabled = false;
                }
            }
           else
            {
                    txt_Pass.Enabled = false;
                    txt_RepetedPass.Enabled = false;
                    btn_SaveUser.Enabled = false;
                    grb_AutoGenerate.Enabled = false;
             }

         }
            
        

        private void Btn_GeneratePass_Click(object sender, EventArgs e)
        {
            txt_Pass.Text = func.PassGenerator(Convert.ToInt32(txt_NumberChar.Text));
            txt_RepetedPass.Text = txt_Pass.Text;
        }

        private void Sign_In_2_Load(object sender, EventArgs e)
        {
            lbl_UserNameFamily.Text = $"{Transfer.D1} {Transfer.D2}";
            
        }

        private void chb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPass.Checked==true)
            {

                txt_Pass.UseSystemPasswordChar = false;
                txt_RepetedPass.UseSystemPasswordChar = false;
            }
            else 
            {

            txt_Pass.UseSystemPasswordChar = true;
            txt_RepetedPass.UseSystemPasswordChar = true;
            }

        }
    }
    class Functionss
    {
        Random random = new Random();

        public Tuple<string, int[]> TypeOfText(string text)
        {
            int[] Security = new int[6];

            string result = "";

            if (text.Any(c => c >= 0x0600 && c <= 0x06FF))
            {
                result += "Persian - ";
                Security[0] += 1;

            }
            //if (text.Any(c => c >= 0xFB50 && c <= 0xFEFC))
            //{
            //    result += "Arabic - ";
            //    Security[0] += 1;
            //}
            if (text.Any(c => c >= 0x41 && c <= 0x7F))
            {
                result += "English - ";
                Security[0] += 1;

            }
            //else if (text.Any(c => c >= 0x0530 && c <= 0x058F))
            //{
            //    result += "Armenian - ";
            //    Security[0] += 1;

            //}
            //else if (text.Any(c => c >= 0x2000 && c <= 0xFA2D))
            //{
            //    result += "Chinese - ";
            //    Security[0] += 1;

            //}
            if (text.Any(c => c >= 0x20 && c <= 0x2F || c >= 0x3A && c <= 0x40))
            {
                result += "Symbole - ";
                Security[1] = 1;

            }

            if (text.Any(c => c >= 0x30 && c <= 0x39))
            {
                result += "Number - ";
                Security[2] = 1;


            }
            if (text.Length >= 8)
            {
                result += "length enough - ";
                Security[5] = text.Length;
            }

            if (text.Any(char.IsUpper))
            {
                result += "capital Letter - ";
                Security[3] = 1;
            }
            if (text.Any(char.IsLower))
            {
                result += "Small Letter - ";
                Security[4] = 1;
            }

            return new Tuple<string, int[]>(result, Security);
        }
        public Tuple<string,int> SecurityLevel(int[] SecurArray)
        {
            double star = 6;
            var Text = "";

            if (SecurArray[0] < 2)
            {
                Text += "- حداقل از دو زبان استفاده شود .\r\n";
                star -= 1;
            }
            if (SecurArray[1] == 0)
            {
                Text += "-حداقل از یک نماد یا نشانه استفاده شود  .\r\n";
                star -= 1;

            }
            if (SecurArray[2] == 0)
            {
                Text += "- حداقل از یک عدد استفاده شود .\r\n";
                star -= 1;

            }
            if (SecurArray[3] == 0)
            {
                Text += "- حداقل از یک حرف بزرگ انگلیسی استفاده شود .\r\n";
                star -= 1;

            }
            if (SecurArray[4] == 0)
            {
                Text += "- حداقل از یک حرف کوچک انگلیسی استفاده شود .\r\n";
                star -= 1;

            }
            if (SecurArray[5] < 8)
            {
                Text += "- حداقل 8 کارکتر استفاده شود .\r\n";
                star -= 1;

            }

            Text += "\r\nسطح امنیت رمز عبور شما  " + ((star / 6) * 100).ToString("0") + "% می باشد.";
            int persent = Convert.ToInt32(((star / 6) * 100));
            return new Tuple<string, int>(Text, persent);

        }
        public string PertianChar()
        {
            var per = (char)random.Next(1570, 1610);
            return per.ToString();
        }
        public string CaptalEngChar()
        {
            var CapEng = (char)random.Next(65, 90);
            return CapEng.ToString();
        }
        public string SmalEngChar()
        {
            var SmalEng = (char)random.Next(65, 90);
            return SmalEng.ToString().ToLower();

        }
        public string NumberChar()
        {
            return random.Next(0, 9).ToString();
        }
        public string SymboleChar()
        {
            var Partsymbole = random.Next(1, 22);

            if (Partsymbole <= 15)
            {
                var symbole = (char)random.Next(33, 47);
                return symbole.ToString() ;

            }
            else
            {
                var symbole = (char)random.Next(58, 64);
                return symbole.ToString();

            }
        }
        public string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        public string PassGenerator(int NumCharecter)
        {
            if (NumCharecter > 5)
            {
                string Pass = "";
                Pass+=PertianChar();
                Pass += CaptalEngChar();
                Pass += SmalEngChar();
                Pass += NumberChar();
                Pass += SymboleChar();
                for (int i = 0; i < NumCharecter - 5; i++)
                {
                    var Method = random.Next(1, 6);
                    switch (Method)
                    {
                        case 1:
                            Pass += PertianChar();
                            break;
                        case 2:
                            Pass += CaptalEngChar();

                            break;
                        case 3:
                            Pass += SmalEngChar();
                            break;
                        case 4:
                            Pass += NumberChar();

                            break;
                        case 5:
                            Pass += SymboleChar();
                            break;
                        default:
                            break;
                    }
                }
                MessageBox.Show($"{Pass}");
                Pass = Shuffle(Pass);

                return Pass;
            }
            else
            {
                MessageBox.Show("Your pass have to be more than 5 charecter.");
                return null;
            }



        }

    }
}
