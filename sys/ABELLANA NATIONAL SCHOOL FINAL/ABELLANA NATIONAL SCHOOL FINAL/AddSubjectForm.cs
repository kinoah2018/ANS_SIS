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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void TeacherSubjectForm_Load(object sender, EventArgs e)
        {
            loadtable();
        }
        public void loadtable()
        {
            dgvSubject.DataSource =  db.SP_SUBVIEW();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            db.SP_SUBSAVE(txtsubject.Text);
            MessageBox.Show("Saved");
            txtsubject.Clear();
            loadtable();
        }

        private void dgvSubject_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsubid.Text = dgvSubject.CurrentRow.Cells[0].Value.ToString();
            txtsubject.Text = dgvSubject.CurrentRow.Cells[1].Value.ToString();
            btnSAVE.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SP_SUBUPDATE(int.Parse(txtsubid.Text),txtsubject.Text);
            MessageBox.Show("Update");
            txtsubject.Clear();
            btnSAVE.Enabled = true;
            btnUpdate.Enabled = false;
            loadtable();
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
