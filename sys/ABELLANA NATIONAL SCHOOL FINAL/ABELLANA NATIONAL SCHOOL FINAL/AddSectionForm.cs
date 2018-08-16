using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    public partial class AddSectionForm : Form
    {
        public AddSectionForm()
        {
            InitializeComponent();
            //conn.Open();
            //SqlCommand lname = new SqlCommand("SELECT T_LASTNAME FROM TBL_TEACHER", conn);
            //SqlDataReader read = lname.ExecuteReader();
            //while (read.Read())
            //{
            //  cmbadvisory.Items.Add(read[0]);
            //}

            //conn.Close();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses2DataContext db = new DataClasses2DataContext();

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
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet10.View_GetTHNAME' table. You can move, or remove it, as needed.
            this.view_GetTHNAMETableAdapter.Fill(this.aNS_DATABASEDataSet10.View_GetTHNAME);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet8.TBL_TEACHER' table. You can move, or remove it, as needed.
            this.tBL_TEACHERTableAdapter.Fill(this.aNS_DATABASEDataSet8.TBL_TEACHER);

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
            //WALAY FUNCTION PA
            txtSecID.Text = dgvSection.CurrentRow.Cells[0].Value.ToString();
            txtsname.Text = dgvSection.CurrentRow.Cells[1].Value.ToString();
            txtSecCap.Text = dgvSection.CurrentRow.Cells[2].Value.ToString();
            txtTID.Text = dgvSection.CurrentRow.Cells[3].Value.ToString();
            cmbadvisory.Text = dgvSection.CurrentRow.Cells[4].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SEC_NAME FROM TBL_SECTION WHERE SEC_NAME ='" + txtsname.Text + "'", conn);
            string cmd1 = Convert.ToString(cmd.ExecuteScalar());
            SqlCommand getfname = new SqlCommand("SELECT T_FIRSTNAME FROM TBL_TEACHER WHERE T_ID ='" + txtTID.Text + "'", conn);
            string getfname1 = Convert.ToString(getfname.ExecuteScalar());
            SqlCommand getmname = new SqlCommand("SELECT T_MIDDLENAME FROM TBL_TEACHER WHERE T_ID ='" + txtTID.Text + "'", conn);
            string getmname1 = Convert.ToString(getmname.ExecuteScalar());
            SqlCommand getlname = new SqlCommand("SELECT T_LASTNAME FROM TBL_TEACHER WHERE T_ID ='" + txtTID.Text + "'", conn);
            string getlname1 = Convert.ToString(getlname.ExecuteScalar());
            conn.Close();
            //MessageBox.Show(getfname1+" "+getmname1+" "+getlname1);
            //MessageBox.Show(get_id1.ToString());
            //walay functin ang update
            if (txtsname.Text == "" || txtSecCap.Text == "")
            {
                MessageBox.Show("Input Fields");
            }
            else
            {
                db.SP_SECTIONUPDATE(int.Parse(txtSecID.Text), txtsname.Text, txtSecCap.Text, int.Parse(txtTID.Text), getfname1, getmname1, getlname1);
                MessageBox.Show("Succesfully Update");
                txtsname.Clear();
                txtSecCap.Clear();
                loadtable();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SEC_NAME FROM TBL_SECTION WHERE SEC_NAME ='"+txtsname.Text+"'",conn);
            string cmd1 = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            if (txtsname.Text ==""||txtSecCap.Text=="")
            {
                MessageBox.Show("Input Fields");
            }
            else if (txtsname.Text == cmd1)
            {
                MessageBox.Show("Section Name already exist");
                txtsname.Focus();
                txtSecCap.Clear();
            }
            else
            {
                db.SP_SECTIONSAVE(txtsname.Text, txtSecCap.Text, Convert.ToInt32(cmbadvisory.SelectedValue));
                MessageBox.Show("Succesfully Saved");
                txtsname.Clear();
                txtSecCap.Clear();
                loadtable();
            }

            
        }

        private void dgvSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
