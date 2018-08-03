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
    public partial class StudentBookForm : Form
    {
        public StudentBookForm()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
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
            db.SP_BOOKSSAVE(txtBookName.Text,txtBookDesc.Text,cmbYLevel.Text);
            MessageBox.Show("Successfully Save");
            txtBookName.Clear();
            txtBookDesc.Clear();
            cmbYLevel.SelectedItem = null;
            loadtable();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SP_BOOKSUPDATE(int.Parse(txtBookID.Text),txtBookName.Text, txtBookDesc.Text, txtSTID.Text,cmbYLevel.Text);
            MessageBox.Show("Successfully Update");
            txtBookName.Clear();
            txtBookDesc.Clear();
            cmbYLevel.SelectedItem = null;
            loadtable();
            btnUpdate.Enabled = false;
            btnSAVE.Enabled = true;
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
