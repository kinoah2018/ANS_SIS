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
    public partial class StudentSchoolYearForm : Form
    {
        public StudentSchoolYearForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentProfileForm spf = new StudentProfileForm();
            spf.ShowDialog();
        }

        private void StudentSchoolYearForm_Load(object sender, EventArgs e)
        {
            dgvSYVIEW.DataSource = db.SP_SYVIEW();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SP_SYSAVE(txtSYName.Text);
            MessageBox.Show("Successfully Saved");
            txtSYName.Text = "";
            dgvSYVIEW.DataSource = db.SP_SYVIEW();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SP_SYUPDATE(int.Parse(txtSYID.Text),txtSYName.Text);
            MessageBox.Show("Successfully Update");
            txtSYID.Text = "";
            txtSYName.Text = "";
            dgvSYVIEW.DataSource = db.SP_SYVIEW();
            btnUpdate.Enabled = false;
        }

        private void dgvSYVIEW_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSYID.Text = dgvSYVIEW.CurrentRow.Cells[0].Value.ToString();
            txtSYName.Text = dgvSYVIEW.CurrentRow.Cells[1].Value.ToString();
            btnUpdate.Enabled = true;
        }
    }
}
