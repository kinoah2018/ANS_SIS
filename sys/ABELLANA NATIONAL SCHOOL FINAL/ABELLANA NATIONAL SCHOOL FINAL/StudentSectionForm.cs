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
    public partial class StudentSectionForm : Form
    {
        public StudentSectionForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentSection_Load(object sender, EventArgs e)
        {

            loadtable();
        }

        public void loadtable()
        {
            dgvSection.DataSource = db.SP_SECVIEW();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSection_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSecID.Text = dgvSection.CurrentRow.Cells[0].Value.ToString();
            txtsname.Text = dgvSection.CurrentRow.Cells[1].Value.ToString();
            txtSecCap.Text = dgvSection.CurrentRow.Cells[2].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SP_SECTIONUPDATE(int.Parse(txtSecID.Text),txtsname.Text, txtSecCap.Text);
            MessageBox.Show("Succesfully Update");
            txtsname.Clear();
            txtSecCap.Clear();
            loadtable();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SP_SECTIONSAVE(txtsname.Text,txtSecCap.Text);
            MessageBox.Show("Succesfully Saved");
            txtsname.Clear();
            txtSecCap.Clear();
            loadtable();
        }

       
    }
}
