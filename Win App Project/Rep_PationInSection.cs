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
    public partial class Rep_PationInSection : Form
    {
        Model.DB_ClinicEntities obj_DbClinic = new Model.DB_ClinicEntities();

        int[] SerSec = new int[2];
        public Rep_PationInSection()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dgv_Pationlist.AutoGenerateColumns = false;
            dgv_Pationlist.ColumnCount = 4;

            dgv_Pationlist.Columns[0].Name = "Name";
            dgv_Pationlist.Columns[0].DataPropertyName = "Name";
            dgv_Pationlist.Columns[0].HeaderText = "نام بیمار";


            dgv_Pationlist.Columns[1].Name = "Family";
            dgv_Pationlist.Columns[1].DataPropertyName = "Family";
            dgv_Pationlist.Columns[1].HeaderText = "نام خانوادگی";


            dgv_Pationlist.Columns[2].Name = "SecName";
            dgv_Pationlist.Columns[2].DataPropertyName = "SecName";
            dgv_Pationlist.Columns[2].HeaderText = "بخش";


            dgv_Pationlist.Columns[3].Name = "ServiceName";
            dgv_Pationlist.Columns[3].DataPropertyName = "ServiceName";
            dgv_Pationlist.Columns[3].HeaderText = "خدمات";


            this.dgv_Pationlist.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_Pationlist.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_Pationlist.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_Pationlist.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_Pationlist.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_Pationlist.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Pationlist.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Pationlist.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);

            cmb_Service.DisplayMember = "ServiceName";
            cmb_Service.ValueMember = "ID";
            cmb_Service.DataSource = obj_DbClinic.Tbl_Service.ToList();
            cmb_Service.Text = "انتخاب خدمات";

            cmb_Section.DisplayMember = "SecName";
            cmb_Section.ValueMember = "ID";
            cmb_Section.DataSource = obj_DbClinic.Tbl_Section.ToList();
            cmb_Section.Text = "انتخاب بخش";



        }

        private void Cmb_Service_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Pationlist.DataSource = obj_DbClinic.Sp_ListOfPationtInService(Convert.ToInt32(cmb_Service.SelectedValue)).ToList();

        }

        private void Cmb_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Pationlist.DataSource = obj_DbClinic.Sp_ListOfPationtInSection(Convert.ToInt32(cmb_Section.SelectedValue)).ToList();

        }

        
    }
}
