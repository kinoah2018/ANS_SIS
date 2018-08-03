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
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SP_PAYMENTSAVE(txtPaymentName.Text,txtPayment_Desc.Text);
            MessageBox.Show("Successfully Save");
            txtPaymentName.Text = "";
            txtPayment_Desc.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewPaymentForm vpf = new ViewPaymentForm();
            vpf.Show();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            StudentPaymentDetailsForm spdf = new StudentPaymentDetailsForm();
            this.Close();
            spdf.ShowDialog();
        }
    }
}
