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
    public partial class ViewPaymentForm : Form
    {
        public ViewPaymentForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void ViewPaymentForm_Load(object sender, EventArgs e)
        {
            dgvPaymentView.DataSource = db.SP_PAYMENTVIEW();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
