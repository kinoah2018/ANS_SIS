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
    public partial class StudentProfileForm : Form
    {
        
        public StudentProfileForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            if (CurrentID()==1)
            {
                txtcstid.Text = "ST-" + (CurrentID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtcstid.Text = "ST-" + (CurrentID() + 1).ToString().PadLeft(5, '0');
            }
        }

        public int CurrentID()
        {
            return Convert.ToInt32(db.ST_CURRENTID());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStudentProfileForm spv = new ViewStudentProfileForm();
            spv.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text==""||txtlname.Text==""||txtmname.Text==""||cmbsyear.Text==""||cmbylevel.Text==""||dtpbdate.Text==""||txtage.Text==""||txtbplace.Text==""||txtadd.Text==""||cmbgen.Text==""||txtcnumber.Text==""||txtheight.Text==""||txtweight.Text==""||txtSystolic.Text==""||txtpname.Text==""||txtcnumber.Text==""||txtoccu.Text=="")
            {
                MessageBox.Show("Input all fields.","Ooops !",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }else
	        {
                
                db.SP_STSAVE(txtcstid.Text, txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, cmbsyear.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbplace.Text, txtadd.Text, cmbgen.Text, Convert.ToDecimal(txtheight.Text), Convert.ToDecimal(txtweight.Text), int.Parse(txtSystolic.Text),int.Parse(txtDiastolic.Text), txtpname.Text, txtcnumber.Text, txtoccu.Text);
                MessageBox.Show("Student Successfully Saved","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ClearALL();
                 txtDiastolic.Text = "";
	        }

            

        }

        public void ClearALL()
        {
            if (CurrentID() == 1)
            {
                txtcstid.Text = "ST-" + (CurrentID().ToString().PadLeft(5, '0'));
            }
            else
            {
                txtcstid.Text = "ST-" + (CurrentID() + 1).ToString().PadLeft(5, '0');
            }
            txtfname.Clear();
            txtlname.Clear();
            txtmname.Clear();
            cmbsyear.SelectedItem = null;
            cmbylevel.SelectedItem = null;
            dtpbdate.ResetText();
            txtage.Text = "0";
            txtbplace.Clear();
            txtadd.Clear();
            cmbgen.SelectedItem = null;
            txtheight.Clear();
            txtweight.Clear();
            txtSystolic.Clear();
            txtpname.Clear();
            txtcnumber.Clear();
            txtoccu.Clear();
            
        }

        private void dtpbdate_ValueChanged(object sender, EventArgs e)
        {
            txtage.Text = (DateTime.Today.Year - dtpbdate.Value.Year).ToString();
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtoccu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtptype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        

        

      
        
       

       
       
    }
}
