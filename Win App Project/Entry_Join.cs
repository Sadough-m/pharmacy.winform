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
    public partial class Entry_Join : Form
    {
        public Entry_Join()
        {
            InitializeComponent();
        }
        Model.DB_ClinicEntities obj_DBClinic = new Model.DB_ClinicEntities();

        private void Form4_Load(object sender, EventArgs e)
        {


            dgv_JoinViwe.AutoGenerateColumns = false;
            dgv_JoinViwe.ColumnCount = 5;

            dgv_JoinViwe.Columns[0].Name = "ID";
            dgv_JoinViwe.Columns[0].DataPropertyName = "ID";
            dgv_JoinViwe.Columns[0].HeaderText = "کد ترکیب";
            dgv_JoinViwe.Columns[0].Width = 50;

            dgv_JoinViwe.Columns[1].Name = "Name";
            dgv_JoinViwe.Columns[1].DataPropertyName = "Name";
            dgv_JoinViwe.Columns[1].HeaderText = "نام دکتر";
            dgv_JoinViwe.Columns[1].Width = 70;

            dgv_JoinViwe.Columns[2].Name = "Family";
            dgv_JoinViwe.Columns[2].DataPropertyName = "Family";
            dgv_JoinViwe.Columns[2].HeaderText = "نام خانوادگی دکتر";
            dgv_JoinViwe.Columns[2].Width = 120;

            dgv_JoinViwe.Columns[3].Name = "SecName";
            dgv_JoinViwe.Columns[3].DataPropertyName = "SecName";
            dgv_JoinViwe.Columns[3].HeaderText = "نام بخش";
            dgv_JoinViwe.Columns[3].Width = 70;

            dgv_JoinViwe.Columns[4].Name = "ServiceName";
            dgv_JoinViwe.Columns[4].DataPropertyName = "ServiceName";
            dgv_JoinViwe.Columns[4].HeaderText = "نام سرویس";
            dgv_JoinViwe.Columns[4].Width = 70;



            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_JoinViwe.Columns.Add(CheckBoxColumn);

            dgv_JoinViwe.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_JoinViwe.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_JoinViwe.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_JoinViwe.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_JoinViwe.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_JoinViwe.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_JoinViwe.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_JoinViwe.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_JoinViwe.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_JoinViwe.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_JoinViwe.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_JoinViwe.DataSource = obj_DBClinic.Viw_Join.ToList();
            var DoctorNameFamily = obj_DBClinic.Tbl_Doctors.Select(x => new { ID = x.ID, NameFamily = x.Name + " " + x.Family }).ToList();
            cmb_Doctor.DisplayMember = "NameFamily";
            cmb_Doctor.ValueMember = "ID";
            cmb_Doctor.DataSource = DoctorNameFamily;
            cmb_Doctor.Text = "انتخاب دکتر";

            cmb_Section.DisplayMember = "SecName";
            cmb_Section.ValueMember = "ID";
            cmb_Section.DataSource = obj_DBClinic.Tbl_Section.ToList();
            cmb_Section.Text = "انتخاب بخش";

            cmb_Service.DisplayMember = "ServiceName";
            cmb_Service.ValueMember = "ID";
            cmb_Service.DataSource = obj_DBClinic.Tbl_Service.ToList();
            cmb_Service.Text = "انتخاب خدمات";


        }

        private void Btn_SaveDoctor_Click(object sender, EventArgs e)
        {

            Model.Tbl_JoinDoctorAndSectionAndService Tbl_join = new Model.Tbl_JoinDoctorAndSectionAndService();
            Tbl_join.IdDoctors = Convert.ToInt32(cmb_Doctor.ValueMember.ToString());
            Tbl_join.IdSection = Convert.ToInt32(cmb_Section.ValueMember.ToString());
            Tbl_join.IdService = Convert.ToInt32(cmb_Service.ValueMember.ToString());


            obj_DBClinic.Tbl_JoinDoctorAndSectionAndService.Add(Tbl_join);
            int i = obj_DBClinic.SaveChanges();
            try
            {
                if (i != 0)
                {
                    dgv_JoinViwe.DataSource = obj_DBClinic.Viw_Join.ToList();
                    MessageBox.Show("Successfull.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }



        private void cmb_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_Service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_InsertJoin_Click(object sender, EventArgs e)
        {
            Model.Tbl_JoinDoctorAndSectionAndService obj_join = new Model.Tbl_JoinDoctorAndSectionAndService();
            obj_join.IdDoctors = Convert.ToInt32(cmb_Doctor.SelectedValue.ToString());
            obj_join.IdSection = Convert.ToInt32(cmb_Section.SelectedValue.ToString());
            obj_join.IdService = Convert.ToInt32(cmb_Service.SelectedValue.ToString());
            obj_DBClinic.Tbl_JoinDoctorAndSectionAndService.Add(obj_join);
            int i= obj_DBClinic.SaveChanges();
            
            if (i!=0)
            {
                MessageBox.Show("Successfull...");
            }
            else
            {
                MessageBox.Show("Wrong!");

            }
            dgv_JoinViwe.DataSource = obj_DBClinic.Viw_Join.ToList();
            

        }

        private void Btn_DeleteJoin_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> SelectedRows = (from row in dgv_JoinViwe.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();
            var Selected = obj_DBClinic.Tbl_JoinDoctorAndSectionAndService.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {Selected.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                obj_DBClinic.Tbl_JoinDoctorAndSectionAndService.RemoveRange(Selected);

            }
            obj_DBClinic.SaveChanges();

            dgv_JoinViwe.DataSource = obj_DBClinic.Tbl_Doctors.ToList();
        }
    }
}
