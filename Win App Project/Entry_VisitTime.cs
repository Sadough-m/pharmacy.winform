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
    public partial class Entry_VisitTime : Form
    {
        Model.DB_ClinicEntities obj_DbClinic = new Model.DB_ClinicEntities();
        public Entry_VisitTime()
        {
            InitializeComponent();
        }

        private void Entry_VisitTime_Load(object sender, EventArgs e)
        {
            var DocSecSer = obj_DbClinic.Viw_Join.Select(x => new { ID = x.ID, DocSecService = x.Name + " " + x.Family + " / " + x.SecName + " / " + x.ServiceName }).ToList();
            cmb_GetDocSecServ.DisplayMember = "DocSecService";
            cmb_GetDocSecServ.ValueMember = "ID";
            cmb_GetDocSecServ.DataSource = DocSecSer;
            cmb_GetDocSecServ.Text = "انتخاب دکتر / بخش / خدمات";

            var pationNF = obj_DbClinic.Tbl_Patient.Select(x => new { ID = x.ID, NameFamily = x.Name + " " + x.Family }).ToList();
            cmb_Pationt.DisplayMember = "NameFamily";
            cmb_Pationt.ValueMember = "ID";
            cmb_Pationt.DataSource = pationNF;
            cmb_Pationt.Text = "انتخاب مریض";



            dgv_VisitTime.AutoGenerateColumns = false;
            dgv_VisitTime.ColumnCount = 8;

            dgv_VisitTime.Columns[0].Name = "ID";
            dgv_VisitTime.Columns[0].DataPropertyName = "ID";
            dgv_VisitTime.Columns[0].HeaderText = "کد";
            dgv_VisitTime.Columns[0].Width = 50;

            dgv_VisitTime.Columns[1].Name = "Name";
            dgv_VisitTime.Columns[1].DataPropertyName = "Name";
            dgv_VisitTime.Columns[1].HeaderText = "نام";
            dgv_VisitTime.Columns[1].Width = 70;

            dgv_VisitTime.Columns[2].Name = "Family";
            dgv_VisitTime.Columns[2].DataPropertyName = "Family";
            dgv_VisitTime.Columns[2].HeaderText = "نام خانوادگی";
            dgv_VisitTime.Columns[2].Width = 70;

            dgv_VisitTime.Columns[3].Name = "DocterFaamily";
            dgv_VisitTime.Columns[3].DataPropertyName = "DocterFaamily";
            dgv_VisitTime.Columns[3].HeaderText = "نام خانوادگی دکتر";
            dgv_VisitTime.Columns[3].Width = 70;

            dgv_VisitTime.Columns[4].Name = "SecName";
            dgv_VisitTime.Columns[4].DataPropertyName = "SecName";
            dgv_VisitTime.Columns[4].HeaderText = "نام بخش";
            dgv_VisitTime.Columns[4].Width = 70;

            dgv_VisitTime.Columns[5].Name = "ServiceName";
            dgv_VisitTime.Columns[5].DataPropertyName = "ServiceName";
            dgv_VisitTime.Columns[5].HeaderText = "نام سرویس";
            dgv_VisitTime.Columns[5].Width = 70;

            dgv_VisitTime.Columns[6].Name = "EnterviewDate";
            dgv_VisitTime.Columns[6].DataPropertyName = "EnterviewDate";
            dgv_VisitTime.Columns[6].HeaderText = "تاریخ مراجعه";
            dgv_VisitTime.Columns[6].Width = 70;

            dgv_VisitTime.Columns[7].Name = "VisitDate";
            dgv_VisitTime.Columns[7].DataPropertyName = "VisitDate";
            dgv_VisitTime.Columns[7].HeaderText = "تاریخ ویزیت";
            dgv_VisitTime.Columns[7].Width = 70;


            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_VisitTime.Columns.Add(CheckBoxColumn);

            dgv_VisitTime.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_VisitTime.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_VisitTime.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_VisitTime.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_VisitTime.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_VisitTime.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_VisitTime.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_VisitTime.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_VisitTime.DataSource = obj_DbClinic.Viw_VisitTime.ToList();

        }

        private void Btn_InsertVisitTime_Click(object sender, EventArgs e)
        {
            Model.Tbl_VisitTime obj_Tbl_VisitTime = new Model.Tbl_VisitTime();
            obj_Tbl_VisitTime.IdJoinDocAndSecAndServ = Convert.ToInt32(cmb_GetDocSecServ.SelectedValue.ToString());
            obj_Tbl_VisitTime.IdPation = Convert.ToInt32(cmb_Pationt.SelectedValue.ToString());
            if (txt_EnterviweDate.Text==null)
            {
                obj_Tbl_VisitTime.EnterviewDate = DateTime.Now;
            }
            else
            {

            obj_Tbl_VisitTime.EnterviewDate =Convert.ToDateTime( txt_EnterviweDate.Text);
            }
            if (txt_VisitTime.Text == null)
            {
                obj_Tbl_VisitTime.VisitDate = DateTime.Now;
            }
            else
            {

                obj_Tbl_VisitTime.VisitDate = Convert.ToDateTime(txt_EnterviweDate.Text);
            }

            obj_DbClinic.Tbl_VisitTime.Add(obj_Tbl_VisitTime);
            int i=obj_DbClinic.SaveChanges();
            try
            {
                if (i!=0)
                {
                    dgv_VisitTime.DataSource = obj_DbClinic.Viw_VisitTime.ToList();
                    MessageBox.Show("Successfull");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Stoped");
            }


        }
       

        private void Btn_DeleteVisitTime_Click(object sender, EventArgs e)
        {


            List<DataGridViewRow> SelectedRows = (from row in dgv_VisitTime.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            MessageBox.Show($"{SelectedRows.Count}");

            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();

            var Selected = obj_DbClinic.Tbl_VisitTime.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {Selected.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                obj_DbClinic.Tbl_VisitTime.RemoveRange(Selected);

            }
            obj_DbClinic.SaveChanges();

            dgv_VisitTime.DataSource = obj_DbClinic.Viw_VisitTime.ToList();

        }

        
    }
}
