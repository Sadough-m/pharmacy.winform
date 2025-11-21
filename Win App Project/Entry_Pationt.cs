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
    
    public partial class Form3 : Form
    {
        Model.DB_ClinicEntities Db_Clinic = new Model.DB_ClinicEntities();
        class CombList
        {
            public string Disply { get; set; }
            public string Value { get; set; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgv_pationtList.AutoGenerateColumns = false;
            dgv_pationtList.ColumnCount = 6;

            dgv_pationtList.Columns[0].Name = "ID";
            dgv_pationtList.Columns[0].DataPropertyName = "ID";
            dgv_pationtList.Columns[0].HeaderText = "کد بیمار";
            dgv_pationtList.Columns[0].Width = 50;

            dgv_pationtList.Columns[1].Name = "Name";
            dgv_pationtList.Columns[1].DataPropertyName = "Name";
            dgv_pationtList.Columns[1].HeaderText = "نام";
            dgv_pationtList.Columns[1].Width = 70;

            dgv_pationtList.Columns[2].Name = "Family";
            dgv_pationtList.Columns[2].DataPropertyName = "Family";
            dgv_pationtList.Columns[2].HeaderText = "نام خانوادگی";
            dgv_pationtList.Columns[2].Width = 120;

            dgv_pationtList.Columns[3].Name = "NatinalCode";
            dgv_pationtList.Columns[3].DataPropertyName = "NatinalCode";
            dgv_pationtList.Columns[3].HeaderText = "کد ملی";
            dgv_pationtList.Columns[3].Width = 120;

            dgv_pationtList.Columns[4].Name = "Tel";
            dgv_pationtList.Columns[4].DataPropertyName = "Tel";
            dgv_pationtList.Columns[4].HeaderText = "تلفن";
            dgv_pationtList.Columns[4].Width = 120;

            dgv_pationtList.Columns[5].Name = "BirthDate";
            dgv_pationtList.Columns[5].DataPropertyName = "BirthDate";
            dgv_pationtList.Columns[5].HeaderText = "تاریخ تولد";
            dgv_pationtList.Columns[5].Width = 70;

            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_pationtList.Columns.Add(CheckBoxColumn);

            dgv_pationtList.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_pationtList.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_pationtList.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_pationtList.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_pationtList.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_pationtList.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_pationtList.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_pationtList.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_pationtList.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_pationtList.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_pationtList.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_pationtList.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_pationtList.DataSource = Db_Clinic.Tbl_Patient.ToList();
            List<CombList> test = new List<CombList>();
            for (int i = 0; i < dgv_pationtList.ColumnCount-1; i++)
            {
                CombList CombLis = new CombList();
                CombLis.Disply = dgv_pationtList.Columns[i].HeaderText;
                CombLis.Value = dgv_pationtList.Columns[i].Name;
                test.Add(CombLis);
            }
            cmb_SearchFild.DisplayMember = "Disply";
            cmb_SearchFild.ValueMember = "Value";
            cmb_SearchFild.DataSource = test;
            cmb_SearchFild.Text = "انتخاب ستون";

        }

        private void btn_SavePation_Click(object sender, EventArgs e)
        {
            Model.Tbl_Patient Tbl_Pation = new Model.Tbl_Patient();
            Tbl_Pation.Name = textPationName.Text;
            Tbl_Pation.Family = txtePFamily.Text;
            Tbl_Pation.NatinalCode = txtePNatinalCode.Text;
            Tbl_Pation.Tel = txtTelephone.Text;
            Tbl_Pation.BirthDate = txtPBirthDate.Text;
            Db_Clinic.Tbl_Patient.Add(Tbl_Pation);
            int i = Db_Clinic.SaveChanges();
            try
            {
                if (i!=0)
                {
                    dgv_pationtList.DataSource = Db_Clinic.Tbl_Patient.ToList();
                    MessageBox.Show("Successfull.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void Btn_DeletePationt_Click(object sender, EventArgs e)
        {
            
            List<DataGridViewRow> SelectedRows = (from row in dgv_pationtList.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            MessageBox.Show($"{SelectedRows.Count}");

            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();
            var SelectedPationt = Db_Clinic.Tbl_Patient.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {SelectedPationt.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Db_Clinic.Tbl_Patient.RemoveRange(SelectedPationt);
                
            }
            Db_Clinic.SaveChanges();

            dgv_pationtList.DataSource = Db_Clinic.Tbl_Patient.ToList();







        }

        private void Btn_Selection_Click(object sender, EventArgs e)
        {

        }
        private void Dgv_pationtList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Txt_SearchWord_TextChanged(object sender, EventArgs e)
        {
            List<Model.Tbl_Patient> Srchquery = new List<Model.Tbl_Patient>();
            switch (cmb_SearchFild.SelectedValue.ToString())
            {
                case "ID":

                    Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.ID.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                case "Name":

                     Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.Name.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                case "Family":

                     Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.Family.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                case "NatinalCode":

                     Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.NatinalCode.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                case "Tel":

                     Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.Tel.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                case "BirthDate":

                     Srchquery = Db_Clinic.Tbl_Patient.Where(x => x.BirthDate.ToString().Contains(txt_SearchWord.Text)).ToList();
                    dgv_pationtList.DataSource = Srchquery;
                    break;
                
                default:
                    break;
            }
        }
    }
}
