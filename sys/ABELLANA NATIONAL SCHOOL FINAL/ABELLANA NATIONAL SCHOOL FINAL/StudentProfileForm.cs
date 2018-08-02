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
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet5.TBL_SCHOOLYEAR' table. You can move, or remove it, as needed.
            this.tBL_SCHOOLYEARTableAdapter.Fill(this.aNS_DATABASEDataSet5.TBL_SCHOOLYEAR);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet4.TBL_SECTION' table. You can move, or remove it, as needed.
            this.tBL_SECTIONTableAdapter.Fill(this.aNS_DATABASEDataSet4.TBL_SECTION);
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
           
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            

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
            txtSecname.SelectedIndex = -1;
            chk_subform137.Checked = false;
            chk_subform138.Checked = false;
            chk_subgrademoral.Checked = false;
            chk_subnso.Checked = false;
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnView_Click_2(object sender, EventArgs e)
        {
            ViewStudentProfileForm spv = new ViewStudentProfileForm();
            spv.ShowDialog();
        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == "" || cmbsyear.Text == "" || cmbylevel.Text == "" || dtpbdate.Text == "" || txtage.Text == "" || txtbplace.Text == "" || txtadd.Text == "" || cmbgen.Text == "" || txtcnumber.Text == "" || txtheight.Text == "" || txtweight.Text == "" || txtSystolic.Text == "" || txtpname.Text == "" || txtcnumber.Text == "" || txtoccu.Text == "")
            {
                MessageBox.Show("Input all fields.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string chek;
                if (chk_subform137.Checked)
                {
                    chek = "Submitted";
                }
                else if (chk_subform138.Checked)
                {
                    chek = "Submitted";
                }
                else if (chk_subgrademoral.Checked)
                {
                    chek = "Submitted";
                }
                else if (chk_subnso.Checked)
                {
                    chek = "Submitted";
                }
                else
                {
                    chek = "Not Submitted";
                }
                db.SP_STSAVE(txtcstid.Text, txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbplace.Text, txtadd.Text, cmbgen.Text, decimal.Parse(txtheight.Text), decimal.Parse(txtweight.Text), int.Parse(txtSystolic.Text), int.Parse(txtDiastolic.Text), chek, chek, chek, chek, txtpname.Text, txtcnumber.Text, txtoccu.Text, Convert.ToInt32(txtSecname.SelectedValue), Convert.ToInt32(cmbsyear.SelectedValue));
                MessageBox.Show("Student Successfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearALL();
                txtDiastolic.Text = "";
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void chk_subform137_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void chk_subform137_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void chk_subform137_Click(object sender, EventArgs e)
        {
            if (chk_subform137.Checked)
            {
                check1.Checked = false;
            }
           
            
        }

        private void chk_subform138_Click(object sender, EventArgs e)
        {
            if (chk_subform138.Checked)
            {
                check2.Checked = false;
            }
            
        }

        private void chk_subgrademoral_Click(object sender, EventArgs e)
        {
            if (chk_subgrademoral.Checked)
            {
                check3.Checked = false;
            }
           
        }

        private void chk_subnso_Click(object sender, EventArgs e)
        {
            if (chk_subnso.Checked)
            {
                check4.Checked = false;
            }
           
        }

        private void check1_Click(object sender, EventArgs e)
        {
             if (check1.Checked)
            {
                chk_subform137.Checked = false;
            }
        }

        private void check2_Click(object sender, EventArgs e)
        {
            if (check2.Checked)
            {
                chk_subform138.Checked = false;
            }
        }

        private void check3_Click(object sender, EventArgs e)
        {
            if (check3.Checked)
            {
                chk_subgrademoral.Checked = false;
            }
        }

        private void check4_Click(object sender, EventArgs e)
        {
             if (check4.Checked)
            {
                chk_subnso.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentSchoolYearForm ssyf = new StudentSchoolYearForm();
            ssyf.ShowDialog();
            this.Close();
        }

       

       

        

        

      
        
       

       
       
    }
}
