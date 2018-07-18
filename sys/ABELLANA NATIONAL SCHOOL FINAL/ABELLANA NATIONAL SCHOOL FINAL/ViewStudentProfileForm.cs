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
    public partial class ViewStudentProfileForm : Form
    {
        public ViewStudentProfileForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStudentProfileForm_Load(object sender, EventArgs e)
        {
            dgvstudent_view.DataSource = db.PTANDST_VIEWs;
        }

        private void dgvstudent_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentUpdateForm suf = new StudentUpdateForm();

            suf.txtSTID.Text = dgvstudent_view.CurrentRow.Cells[0].Value.ToString();
            suf.txtfname.Text = dgvstudent_view.CurrentRow.Cells[1].Value.ToString();
            suf.txtmname.Text = dgvstudent_view.CurrentRow.Cells[2].Value.ToString();
            suf.txtlname.Text = dgvstudent_view.CurrentRow.Cells[3].Value.ToString();
            suf.cmbylevel.Text = dgvstudent_view.CurrentRow.Cells[4].Value.ToString();
            suf.cmbsyear.Text = dgvstudent_view.CurrentRow.Cells[5].Value.ToString();
            suf.dtpbdate.Text = dgvstudent_view.CurrentRow.Cells[6].Value.ToString();
            suf.txtage.Text = dgvstudent_view.CurrentRow.Cells[7].Value.ToString();
            suf.txtbplace.Text = dgvstudent_view.CurrentRow.Cells[8].Value.ToString();
            suf.txtadd.Text = dgvstudent_view.CurrentRow.Cells[9].Value.ToString();
            suf.cmbgen.Text = dgvstudent_view.CurrentRow.Cells[10].Value.ToString();
            suf.txtcnumber.Text = dgvstudent_view.CurrentRow.Cells[11].Value.ToString();
            if (dgvstudent_view.CurrentRow.Cells[12].Value.ToString() == "True")
            {
                suf.cmbstatus.SelectedIndex = 0;
            }
            else
            {
                suf.cmbstatus.SelectedIndex = 1;
            }
            suf.txtheight.Text = dgvstudent_view.CurrentRow.Cells[13].Value.ToString();
            suf.txtweight.Text = dgvstudent_view.CurrentRow.Cells[14].Value.ToString();
            suf.txtbp.Text = dgvstudent_view.CurrentRow.Cells[15].Value.ToString();
            suf.txtPID.Text = dgvstudent_view.CurrentRow.Cells[16].Value.ToString();
            suf.txtpname.Text = dgvstudent_view.CurrentRow.Cells[17].Value.ToString();
            suf.txtcnumber.Text = dgvstudent_view.CurrentRow.Cells[18].Value.ToString();
            suf.txtoccu.Text = dgvstudent_view.CurrentRow.Cells[19].Value.ToString();
            suf.txtptype.Text = dgvstudent_view.CurrentRow.Cells[20].Value.ToString();
            suf.ShowDialog();
            this.Close();
            
        }

        private void dgvstudent_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
