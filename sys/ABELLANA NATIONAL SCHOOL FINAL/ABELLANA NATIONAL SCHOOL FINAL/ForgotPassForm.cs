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
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnok_Click(object sender, EventArgs e)
        {

            int result1 = db.SP_ACCOUNTRECOVERY(txtUsername.Text, cmbSques.Text, txtans.Text).Count();
            if (txtUsername.Text == "" || cmbSques.Text == "" || txtans.Text == "")
            {
                MessageBox.Show("Input all fields");
            }
            else if (result1 != 1)
            {
                MessageBox.Show("The data you been input was not match!");
            }
            else
            {
                MessageBox.Show("Proceed to Changepass !");
                ChangePassForm2 cpf = new ChangePassForm2();
                cpf.txtUsername.Text = txtUsername.Text;
                this.Close();
                cpf.ShowDialog();
                cpf.txtnewpass.Focus();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
