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
    public partial class ChangePassForm2 : Form
    {
        public ChangePassForm2()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text != "" && txtrepass.Text != "" && txtUsername.Text !="")
            {
                if (txtnewpass.Text != "1234" && txtrepass.Text != "1234")
                {
                    if (txtnewpass.Text.Length >= 8)
                    {
                        if (txtnewpass.Text == txtrepass.Text)
                        {
                            db.SP_CHANGEPASS(txtUsername.Text,txtnewpass.Text);
                            MessageBox.Show("Successfully Update !");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtnewpass.Focus();
                            txtrepass.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnewpass.Clear();
                        txtrepass.Clear();
                        txtnewpass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please do not use the default password.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewpass.Clear();
                    txtrepass.Clear();
                    txtnewpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are changing your pass! \nDo you want to close this form?", "Oops.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialog)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
