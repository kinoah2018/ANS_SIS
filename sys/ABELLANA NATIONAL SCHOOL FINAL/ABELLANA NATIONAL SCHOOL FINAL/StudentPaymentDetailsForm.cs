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
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet5.TBL_SCHOOLYEAR' table. You can move, or remove it, as needed.
            this.tBL_SCHOOLYEARTableAdapter.Fill(this.aNS_DATABASEDataSet5.TBL_SCHOOLYEAR);
            dgvPayDetails.DataSource = db.View_PAYDETs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SP_PAYSAVE(txtPayFor.Text, decimal.Parse(txtAmount.Text), Convert.ToInt32(cmbSY.SelectedValue));
            MessageBox.Show("Successfully Save");
            txtAmount.Text = "";
            txtPayFor.Text = "";
            cmbSY.Text = "";
            dgvPayDetails.DataSource = db.View_PAYDETs;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.SP_PAYUPDATE(int.Parse(lbPYID.Text), txtPayFor.Text, decimal.Parse(txtAmount.Text), Convert.ToInt32(cmbSY.SelectedValue));
            MessageBox.Show("Successfully Update");
            txtAmount.Text = "";
            txtPayFor.Text = "";
            cmbSY.Text = "";
            dgvPayDetails.DataSource = db.View_PAYDETs;
        }
    }
}