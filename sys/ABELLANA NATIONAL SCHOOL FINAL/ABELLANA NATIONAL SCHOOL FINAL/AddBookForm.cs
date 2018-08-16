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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.SP_BOOKSEARCH(textBox1.Text);
        }

        public void loadtable()
        {
            dgvBooks.DataSource = db.SP_BOOKVIEW();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text ==""||txtBookDesc.Text ==""||cmbYLevel.Text ==""||txtAuthor.Text ==""||dtpPublished.Text==null )
            {
                MessageBox.Show("Input Fields");
            }
            else 
            {
                
                db.SP_BOOKSSAVE(txtBookName.Text, txtBookDesc.Text, cmbYLevel.Text,txtAuthor.Text,DateTime.Parse(dtpPublished.Text));
                MessageBox.Show("Successfully Save");
                txtBookName.Clear();
                txtBookDesc.Clear();
                cmbYLevel.SelectedItem = null;
                loadtable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" || txtBookDesc.Text == "" || cmbYLevel.Text == "" || txtAuthor.Text == "" || dtpPublished.Text == null)
            {
                MessageBox.Show("Input Fields");
            }
            else
            {
                db.SP_BOOKSUPDATE(int.Parse(txtBookID.Text), txtBookName.Text, txtBookDesc.Text, cmbYLevel.Text, txtAuthor.Text, DateTime.Parse(dtpPublished.Text));
                MessageBox.Show("Successfully Update");
                txtBookName.Clear();
                txtBookDesc.Clear();
                cmbYLevel.SelectedItem = null;
                loadtable();
                btnUpdate.Enabled = false;
                btnSAVE.Enabled = true;
            }
        }

        private void StudentBookForm_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void dgvBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            txtBookName.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            txtBookDesc.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            cmbYLevel.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
            btnUpdate.Enabled = true;
            btnSAVE.Enabled = false;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
