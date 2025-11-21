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
    public partial class Entry_Section : Form
    {
        public Entry_Section()
        {
            InitializeComponent();
        }
        Model.DB_ClinicEntities obj_DBClinic = new Model.DB_ClinicEntities();

        private void Entry_Section_Load(object sender, EventArgs e)
        {
            dgv_Section.AutoGenerateColumns = false;
            dgv_Section.ColumnCount = 6;

            dgv_Section.Columns[0].Name = "ID";
            dgv_Section.Columns[0].DataPropertyName = "ID";
            dgv_Section.Columns[0].HeaderText = "کد بخش";
            dgv_Section.Columns[0].Width = 50;

            dgv_Section.Columns[1].Name = "SecName";
            dgv_Section.Columns[1].DataPropertyName = "SecName";
            dgv_Section.Columns[1].HeaderText = "نام بخش";
            dgv_Section.Columns[1].Width = 70;

            dgv_Section.Columns[2].Name = "NumVisitRoom";
            dgv_Section.Columns[2].DataPropertyName = "NumVisitRoom";
            dgv_Section.Columns[2].HeaderText = "تعداد اتاق ویزیت";
            dgv_Section.Columns[2].Width = 50;

            dgv_Section.Columns[3].Name = "NumSurgeryRoom";
            dgv_Section.Columns[3].DataPropertyName = "NumSurgeryRoom";
            dgv_Section.Columns[3].HeaderText = "تعداد اتاق عمل";
            dgv_Section.Columns[3].Width = 50;

            dgv_Section.Columns[4].Name = "NumBed";
            dgv_Section.Columns[4].DataPropertyName = "NumBed";
            dgv_Section.Columns[4].HeaderText = "تعداد تخت";
            dgv_Section.Columns[4].Width = 50;

            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_Section.Columns.Add(CheckBoxColumn);

            dgv_Section.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_Section.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_Section.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_Section.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_Section.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_Section.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_Section.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Section.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Section.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Section.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Section.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_Section.DataSource = obj_DBClinic.Tbl_Section.ToList();
        }

        

        

        private void Btn_SaveSection_Click(object sender, EventArgs e)
        {

            Model.Tbl_Section obj_TblSection = new Model.Tbl_Section();
            obj_TblSection.SecName = txt_Name.Text;
            obj_TblSection.NumSurgeryRoom = Convert.ToInt32(txt_NumSurgeryRoom.Text);
            obj_TblSection.NumVisitRoom = Convert.ToInt32(txt_NumVisitRoom.Text);
            obj_TblSection.NumBed = Convert.ToInt32(txt_NumBed.Text);

            obj_DBClinic.Tbl_Section.Add(obj_TblSection);
            int i = obj_DBClinic.SaveChanges();
            try
            {
                if (i != 0)
                {
                    dgv_Section.DataSource = obj_DBClinic.Tbl_Section.ToList();
                    MessageBox.Show("Successfull.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            txt_Name.Text = "";
            txt_NumBed.Text = "";
            txt_NumSurgeryRoom.Text = "";
            txt_NumVisitRoom.Text = "";

        }

        private void Btn_DeleteSection_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> SelectedRows = (from row in dgv_Section.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();
            var Selected = obj_DBClinic.Tbl_Section.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {Selected.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                obj_DBClinic.Tbl_Section.RemoveRange(Selected);

            }
            obj_DBClinic.SaveChanges();

            dgv_Section.DataSource = obj_DBClinic.Tbl_Section.ToList();
        }

        private void Txt_NumBed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
