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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdb_Pationt.Checked==true)
            {
                Form3 InsertPationt = new Form3();
                InsertPationt.ShowDialog();
            }
            else if (rdb_join.Checked==true)
            {
                Entry_Join InsertJoin = new Entry_Join();
                InsertJoin.ShowDialog();
            }
            else if (rdb_visitTime.Checked==true)
            {
                Entry_VisitTime visitTime = new Entry_VisitTime();
                visitTime.ShowDialog();
            }
            else if (rdb_Dockters.Checked==true)
            {

                Entry_Doctor Doctor = new Entry_Doctor();
                Doctor.ShowDialog();
            }
            else if (rdb_Sections.Checked==true)
            {
                Entry_Section section = new Entry_Section();
                section.ShowDialog();
            }
            else if (rdb_services.Checked==true)
            {
                Entry_Servic service = new Entry_Servic();
                service.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Rep_PationInSection PationList = new Rep_PationInSection();
            PationList.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Rep_NumberOfPationInQuee quee = new Rep_NumberOfPationInQuee();
            quee.ShowDialog();
        }
    }
}
