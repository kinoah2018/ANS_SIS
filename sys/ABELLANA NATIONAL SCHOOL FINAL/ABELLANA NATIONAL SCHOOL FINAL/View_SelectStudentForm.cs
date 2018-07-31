using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    public partial class View_SelectStudentForm : Form
    {
        public View_SelectStudentForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void View_SelectStudentForm_Load(object sender, EventArgs e)
        {
            dgvViewStud.DataSource = from student in db.TBL_STUDENTs
                                         select new
                                         {
                                             student.ST_CURRENTID,
                                             student.ST_FIRSTNAME,
                                             student.ST_MIDDLENAME,
                                             student.ST_LASTNAME,
                                             student.ST_HEIGHT,
                                             student.ST_WEIGHT,
                                             student.ST_BPSYSTOLIC,
                                             student.ST_BPDIASTOLIC
                                         };
        }

        private void dgvViewStud_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BMIComputeForm b = new BMIComputeForm();
            b.txtstcid.Text = dgvViewStud.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvViewStud.CurrentRow.Cells[1].Value.ToString();
            string mname = dgvViewStud.CurrentRow.Cells[2].Value.ToString();
            string lname = dgvViewStud.CurrentRow.Cells[3].Value.ToString();
            string fullname = fname.ToString() + " " + mname.ToString() + " " + lname.ToString();
            b.txtfulln.Text = fullname;
            b.txtheight.Text = dgvViewStud.CurrentRow.Cells[4].Value.ToString();
            b.txtweight.Text = dgvViewStud.CurrentRow.Cells[5].Value.ToString();
            b.txtSystolic.Text = dgvViewStud.CurrentRow.Cells[6].Value.ToString();
            b.txtDiastolic.Text = dgvViewStud.CurrentRow.Cells[7].Value.ToString();
            this.Close();
            b.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewStud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
