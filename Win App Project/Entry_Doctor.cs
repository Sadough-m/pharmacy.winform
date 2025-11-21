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
    public partial class Entry_Doctor : Form
    {
        public Entry_Doctor()
        {
            InitializeComponent();
        }
        Model.DB_ClinicEntities Db_Clinic = new Model.DB_ClinicEntities();
        private void Entry_Doctor_Load(object sender, EventArgs e)
        {

            dgv_Doctors.AutoGenerateColumns = false;
            dgv_Doctors.ColumnCount = 8;

            dgv_Doctors.Columns[0].Name = "ID";
            dgv_Doctors.Columns[0].DataPropertyName = "ID";
            dgv_Doctors.Columns[0].HeaderText = "کد دکتر";
            dgv_Doctors.Columns[0].Width = 50;

            dgv_Doctors.Columns[1].Name = "Name";
            dgv_Doctors.Columns[1].DataPropertyName = "Name";
            dgv_Doctors.Columns[1].HeaderText = "نام";
            dgv_Doctors.Columns[1].Width = 70;

            dgv_Doctors.Columns[2].Name = "Family";
            dgv_Doctors.Columns[2].DataPropertyName = "Family";
            dgv_Doctors.Columns[2].HeaderText = "نام خانوادگی";
            dgv_Doctors.Columns[2].Width = 120;

            dgv_Doctors.Columns[3].Name = "NatinalCode";
            dgv_Doctors.Columns[3].DataPropertyName = "NatinalCode";
            dgv_Doctors.Columns[3].HeaderText = "کد ملی";
            dgv_Doctors.Columns[3].Width = 120;

            dgv_Doctors.Columns[4].Name = "Tel";
            dgv_Doctors.Columns[4].DataPropertyName = "Tel";
            dgv_Doctors.Columns[4].HeaderText = "تلفن";
            dgv_Doctors.Columns[4].Width = 120;

            dgv_Doctors.Columns[5].Name = "BirthDate";
            dgv_Doctors.Columns[5].DataPropertyName = "BirthDate";
            dgv_Doctors.Columns[5].HeaderText = "تاریخ تولد";
            dgv_Doctors.Columns[5].Width = 70;

            dgv_Doctors.Columns[6].Name = "Major";
            dgv_Doctors.Columns[6].DataPropertyName = "Major";
            dgv_Doctors.Columns[6].HeaderText = "رشته";
            dgv_Doctors.Columns[6].Width = 70;

            dgv_Doctors.Columns[7].Name = "Degree";
            dgv_Doctors.Columns[7].DataPropertyName = "Degree";
            dgv_Doctors.Columns[7].HeaderText = "مدرک";
            dgv_Doctors.Columns[7].Width = 70;


            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_Doctors.Columns.Add(CheckBoxColumn);

            dgv_Doctors.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_Doctors.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_Doctors.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_Doctors.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_Doctors.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_Doctors.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_Doctors.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Doctors.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_Doctors.DataSource = Db_Clinic.Tbl_Doctors.ToList();
        }

        private void Btn_SaveDoctor_Click(object sender, EventArgs e)
        {

            Model.Tbl_Doctors Tbl_Doctors = new Model.Tbl_Doctors();
            Tbl_Doctors.Name = txt_Name.Text;
            Tbl_Doctors.Family = txt_Family.Text;
            Tbl_Doctors.NatinalCode = txt_NatinalCode.Text;
            Tbl_Doctors.Tel = txt_Telephone.Text;
            Tbl_Doctors.BirthDate = txt_BirthDate.Text;
            Tbl_Doctors.Major = txt_Major.Text;
            Tbl_Doctors.Degree = txt_Degre.Text;

            Db_Clinic.Tbl_Doctors.Add(Tbl_Doctors);
            int i = Db_Clinic.SaveChanges();
            try
            {
                if (i != 0)
                {
                    dgv_Doctors.DataSource = Db_Clinic.Tbl_Doctors.ToList();
                    MessageBox.Show("Successfull.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            txt_BirthDate.Text = "";
            txt_Degre.Text = "";
            txt_Family.Text = "";
            txt_Major.Text = "";
            txt_Name.Text = "";
            txt_NatinalCode.Text = "";
            txt_Telephone.Text = "";

        }

        private void Btn_DeleteDoctor_Click(object sender, EventArgs e)
        {
            
            List<DataGridViewRow> SelectedRows = (from row in dgv_Doctors.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();
            var Selected = Db_Clinic.Tbl_Doctors.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {Selected.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Db_Clinic.Tbl_Doctors.RemoveRange(Selected);
                
            }
            Db_Clinic.SaveChanges();

            dgv_Doctors.DataSource = Db_Clinic.Tbl_Doctors.ToList();
        }
    }
}
