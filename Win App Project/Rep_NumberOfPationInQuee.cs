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
    public partial class Rep_NumberOfPationInQuee : Form
    {
        Model.DB_ClinicEntities obj_DbClinic = new Model.DB_ClinicEntities();
        public Rep_NumberOfPationInQuee()
        {
            InitializeComponent();
            
        }

        private void Rep_NumberOfPationInQuee_Load(object sender, EventArgs e)
        {
            dgv_CountOfPation.AutoGenerateColumns = false;
            dgv_CountOfPation.ColumnCount = 3;

            dgv_CountOfPation.Columns[0].Name = "VisitDate";
            dgv_CountOfPation.Columns[0].DataPropertyName = "VisitDate";
            dgv_CountOfPation.Columns[0].HeaderText = "تاریخ";


            dgv_CountOfPation.Columns[1].Name = "ServiceName";
            dgv_CountOfPation.Columns[1].DataPropertyName = "ServiceName";
            dgv_CountOfPation.Columns[1].HeaderText = "نام خدمات";


            dgv_CountOfPation.Columns[2].Name = "CountOfPationt";
            dgv_CountOfPation.Columns[2].DataPropertyName = "CountOfPationt";
            dgv_CountOfPation.Columns[2].HeaderText = "تعداد در صف";


            this.dgv_CountOfPation.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgv_CountOfPation.DefaultCellStyle.BackColor = Color.Beige;



            this.dgv_CountOfPation.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dgv_CountOfPation.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;


            dgv_CountOfPation.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv_CountOfPation.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);
            dgv_CountOfPation.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Regular);


            dgv_CountOfPation.DataSource = obj_DbClinic.Sp_CountOfPationtGroupServiceGroupDate().ToList();
        }

        private void Btn_FilterDate_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities obj_DbClinic = new Model.DB_ClinicEntities();
            dgv_CountOfPation.DataSource = obj_DbClinic.Sp_CountOfPationtGroupServiceGroupDatebyDate(Convert.ToDateTime(maskedTxt_Date.Text)).ToList();
        }
        //right to left one column
        //private void dgv_CountOfPation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex == 0 && e.RowIndex >= 0)
        //    {
        //        e.PaintBackground(e.CellBounds, true);
        //        TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(),
        //        e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
        //         TextFormatFlags.RightToLeft | TextFormatFlags.Right);
        //        e.Handled = true;
        //    }
        //}
    }
}
