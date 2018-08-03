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
    public partial class StudentPaymentDetailsForm : Form
    {
        public StudentPaymentDetailsForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentPaymentDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet6.TBL_PAYMENT' table. You can move, or remove it, as needed.
            this.tBL_PAYMENTTableAdapter.Fill(this.aNS_DATABASEDataSet6.TBL_PAYMENT);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet5.TBL_SCHOOLYEAR' table. You can move, or remove it, as needed.
            this.tBL_SCHOOLYEARTableAdapter.Fill(this.aNS_DATABASEDataSet5.TBL_SCHOOLYEAR);
            load();
        }
        public void load()
        {
            dgvPayDetails.DataSource = db.SP_PAYDETVIEW();
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SP_PAYSAVE(cmbPayfor.Text, Convert.ToDecimal(txtAmount.Text), Convert.ToInt32(cmbSY.SelectedValue), Convert.ToInt32(cmbPayfor.SelectedValue));
            MessageBox.Show("Successfully Save");
            txtAmount.Text = "";
            cmbPayfor.SelectedItem = null;
            cmbSY.SelectedItem = null;
            load();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SP_PAYUPDATE(int.Parse(lbPYID.Text), cmbPayfor.Text, decimal.Parse(txtAmount.Text), Convert.ToInt32(cmbSY.SelectedValue));
            MessageBox.Show("Successfully Update");
            txtAmount.Text = "";
            cmbPayfor.SelectedItem = null;
            cmbSY.SelectedItem = null;
            load();
            btnUpdate.Enabled = false;
        }

        private void dgvPayDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPayDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbPYID.Text = dgvPayDetails.CurrentRow.Cells[0].Value.ToString();
            cmbPayfor.Text = dgvPayDetails.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dgvPayDetails.CurrentRow.Cells[2].Value.ToString();
            lbSYID.Text = dgvPayDetails.CurrentRow.Cells[3].Value.ToString();
            cmbSY.Text = dgvPayDetails.CurrentRow.Cells[4].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnAddPay_Click(object sender, EventArgs e)
        {
            AddPaymentForm apf = new AddPaymentForm();
            this.Close();
            apf.ShowDialog();
        }
    }
}