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
    public partial class StudentUpdateForm : Form
    {
        public StudentUpdateForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isactive = false;
            if (cmbstatus.Text == "Active")
            {
                isactive = true;
            }
            else
            {
                isactive = false;
            }
            if (txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == "" || cmbsyear.Text == "" || cmbylevel.Text == "" || dtpbdate.Text == "" || txtage.Text == "" || txtbplace.Text == "" || txtadd.Text == "" || cmbgen.Text == "" || txtcnumber.Text == "" || txtheight.Text == "" || txtweight.Text == "" || txtSystolic.Text == "" || txtpname.Text == "" || txtcnumber.Text == "" || txtoccu.Text == "")
            {
                MessageBox.Show("Input all fields.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                db.SP_STUPDATE(int.Parse(txtSID.Text), txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, cmbsyear.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbplace.Text, txtadd.Text, cmbgen.Text, isactive, Convert.ToDecimal(txtheight.Text), Convert.ToDecimal(txtweight.Text),int.Parse(txtSystolic.Text), int.Parse(txtDiasltolic.Text), int.Parse(txtPID.Text), txtpname.Text, txtcnumber.Text, txtoccu.Text);
                MessageBox.Show("Student Successfully Update !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearALL();
                this.Close();
            }
        }
        public void ClearALL()
        {
            txtfname.Clear();
            txtlname.Clear();
            txtmname.Clear();
            cmbsyear.SelectedText = "";
            cmbylevel.SelectedText = "";
            dtpbdate.ResetText();
            txtage.Text = "0";
            txtbplace.Clear();
            txtadd.Clear();
            cmbgen.SelectedText = "";
            txtheight.Clear();
            txtweight.Clear();
            txtSystolic.Clear();
            txtpname.Clear();
            txtcnumber.Clear();
            txtoccu.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
