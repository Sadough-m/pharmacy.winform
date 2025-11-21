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
    public partial class Entry_Servic : Form
    {
        public Entry_Servic()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
        Model.DB_ClinicEntities obj_DBClinic = new Model.DB_ClinicEntities();

        private void Entry_Servic_Load(object sender, EventArgs e)
        {
            dgv_Service.AutoGenerateColumns = false;
            dgv_Service.ColumnCount = 5;

            dgv_Service.Columns[0].Name = "ID";
            dgv_Service.Columns[0].DataPropertyName = "ID";
            dgv_Service.Columns[0].HeaderText = "کد خدمات";
            dgv_Service.Columns[0].Width = 50;

            dgv_Service.Columns[1].Name = "ServiceName";
            dgv_Service.Columns[1].DataPropertyName = "ServiceName";
            dgv_Service.Columns[1].HeaderText = "نام سرویس";
            dgv_Service.Columns[1].Width = 70;

            dgv_Service.Columns[2].Name = "Major";
            dgv_Service.Columns[2].DataPropertyName = "Major";
            dgv_Service.Columns[2].HeaderText = "رشته";
            dgv_Service.Columns[2].Width = 70;

            dgv_Service.Columns[3].Name = "Price";
            dgv_Service.Columns[3].DataPropertyName = "Price";
            dgv_Service.Columns[3].HeaderText = "قیمت";
            dgv_Service.Columns[3].Width = 70;


            dgv_Service.Columns[4].Name = "Comment";
            dgv_Service.Columns[4].DataPropertyName = "Comment";
            dgv_Service.Columns[4].HeaderText = "توضیح";
            dgv_Service.Columns[4].Width = 120;

            DataGridViewCheckBoxColumn CheckBoxColumn = new DataGridViewCheckBoxColumn();
            CheckBoxColumn.Name = "CheckBoxColumn";
            CheckBoxColumn.HeaderText = "انتخاب";
            CheckBoxColumn.Width = 50;
            dgv_Service.Columns.Add(CheckBoxColumn);

            dgv_Service.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;



            this.dgv_Service.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_Service.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_Service.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_Service.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_Service.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_Service.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Service.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Service.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Service.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_Service.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);

            
            dgv_Service.DataSource = obj_DBClinic.Tbl_Service.ToList();

        }
        


        private void Btn_SaveService_Click(object sender, EventArgs e)
        {

            Model.Tbl_Service obj_TblService = new Model.Tbl_Service();
            obj_TblService.ServiceName = txt_Name.Text;
            obj_TblService.Major = txt_Major.Text;
            obj_TblService.Price = Convert.ToInt32(txt_Price.Text);
            obj_TblService.Comment = txt_Comment.Text;

            obj_DBClinic.Tbl_Service.Add(obj_TblService);
            int i = obj_DBClinic.SaveChanges();
            try
            {
                if (i != 0)
                {
                    dgv_Service.DataSource = obj_DBClinic.Tbl_Service.ToList();
                    MessageBox.Show("Successfull.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            txt_Name.Text = "";
            txt_Comment.Text = "";
            txt_Major.Text = "";
            txt_Price.Text = "";

        }

        private void Btn_DeleteService_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> SelectedRows = (from row in dgv_Service.Rows.Cast<DataGridViewRow>() where Convert.ToBoolean(row.Cells["CheckBoxColumn"].Value) == true select row).ToList();
            var IdDgv = SelectedRows.Select(x => (int)x.Cells["ID"].Value).ToList();
            var Selected = obj_DBClinic.Tbl_Service.Where(x => IdDgv.Contains(x.ID)).ToList();

            DialogResult dr = MessageBox.Show($"you are about to delet {Selected.Count} items", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                obj_DBClinic.Tbl_Service.RemoveRange(Selected);

            }
            obj_DBClinic.SaveChanges();

            dgv_Service.DataSource = obj_DBClinic.Tbl_Service.ToList();
        }

        
    }
}
