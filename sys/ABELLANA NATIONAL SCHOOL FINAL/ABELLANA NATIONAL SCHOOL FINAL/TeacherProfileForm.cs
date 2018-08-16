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
    public partial class TeacherProfileForm : Form
    {
        public TeacherProfileForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet7.TBL_SUBJECT' table. You can move, or remove it, as needed.
            this.tBL_SUBJECTTableAdapter.Fill(this.aNS_DATABASEDataSet7.TBL_SUBJECT);

            loadtable();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadtable()
        {
            dgvTeacher.DataSource = db.SP_TEACHERVIEW();
        }

        public void Clear()
        {
            txtfname.Clear();
            txtlname.Clear();
            txtcontact.Clear();
            txtmname.Clear();
            cmbsubject.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text ==""||txtmname.Text ==""||txtlname.Text ==""||txtcontact.Text ==""||cmbsubject.SelectedValue == null)
            {
                MessageBox.Show("Inpute Data");
            }
            else
            {
                db.SP_TEACHERSAVE(txtfname.Text, txtmname.Text, txtlname.Text, txtcontact.Text, Convert.ToInt32(cmbsubject.SelectedValue));
                Clear();
                loadtable();
            }
        }

        private void dgvTeacher_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTID.Text = dgvTeacher.CurrentRow.Cells[0].Value.ToString();
            txtfname.Text = dgvTeacher.CurrentRow.Cells[1].Value.ToString();
            txtmname.Text = dgvTeacher.CurrentRow.Cells[2].Value.ToString();
            txtlname.Text = dgvTeacher.CurrentRow.Cells[3].Value.ToString();
            if (dgvTeacher.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                cmbstatus.SelectedIndex = 0;
            }
            else
            {
                cmbstatus.SelectedIndex = 1;
            }
            txtcontact.Text = dgvTeacher.CurrentRow.Cells[5].Value.ToString();
            txtSID.Text = dgvTeacher.CurrentRow.Cells[6].Value.ToString();
            cmbsubject.Text = dgvTeacher.CurrentRow.Cells[7].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            cmbstatus.Enabled = true;
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtmname.Text == "" || txtlname.Text == "" || txtcontact.Text == "" || cmbsubject.SelectedValue == null)
            {
                MessageBox.Show("Inpute Data");
            }
            else
            {
                bool isactive = true;
                if (cmbstatus.Text == "Active")
                {
                    isactive = true;
                }
                else
                {
                    isactive = false;
                }
                db.SP_TEACHERUPDATE(int.Parse(txtTID.Text), txtfname.Text, txtmname.Text, txtlname.Text,isactive, txtcontact.Text, int.Parse(txtSID.Text),cmbsubject.Text);
                MessageBox.Show("Successfully Update");
                Clear();
                loadtable();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                cmbstatus.Text = "Active";
               
            }
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                dgvTeacher.DataSource = db.SP_TEACHERVIEW();
            }
            else
            {
                dgvTeacher.DataSource = db.SP_TEACHERSEARCH(txtsearch.Text);      
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
