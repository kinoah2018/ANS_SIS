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
        DataClasses2DataContext db = new DataClasses2DataContext();
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
        }

        private void dtpbdate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now<dtpbdate.Value)
            {
                MessageBox.Show("Lapas naka");
                dtpbdate.ResetText();
            }
            else
            {
                txtage.Text = (DateTime.Today.Year - dtpbdate.Value.Year).ToString();    
            }
            
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtoccu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
            if (txtfname.Text == "" || txtlname.Text == "" || cmbsyear.Text == "" || cmbylevel.Text == "" || dtpbdate.Text == "" || txtage.Text == "" || txtbplace.Text == "" || txtadd.Text == "" || cmbgen.Text == "" || txtcnumber.Text == "" || txtheight.Text == "" || txtweight.Text == "" || txtSystolic.Text == "" || txtpname.Text == "" || txtcnumber.Text == "" || txtoccu.Text == "")
            {
                MessageBox.Show("Input all fields.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string chek1;
                if (chk_subform137.Checked)
                {
                    chek1 = "Submitted";
                }
                else
                {
                    chek1 = "Not Submitted";
                }
                string chek2;
                if (chk_subform138.Checked)
                {
                     chek2 = "Submitted";
                }
                else
                {
                    chek2 = "Not Submitted";
                }
                string chek3;
                if (chk_subgrademoral.Checked)
                {
                    chek3 = "Submitted";
                }
                else
                {
                    chek3 = "Not Submitted";
                }
                string chek4;
                if (chk_subnso.Checked)
                {
                    chek4 = "Submitted";
                }
                else
                {
                    chek4 = "Not Submitted";   
                }

                #region Calculation BMI
                double BMI_Total;
                double wttotal;

                double get_height = double.Parse(txtheight.Text);
                double get_weight = double.Parse(txtweight.Text);

                //[ kg / ( ft / 3.28 = m) ] = Ans.
                wttotal = get_height / 3.28;

                //[ kg / (ft * 3.28 = m2(m*m) ) ] = Ans.
                BMI_Total = (get_weight / Math.Pow((wttotal), 2));

                BMI_Total = Math.Round(BMI_Total, 2);//roundoff 2 decimal places
                //step 3: Get the result of the meter then divide it with your weight. 
                //txtResult.Text = BMI_Total.ToString();
                #endregion

                #region bmi category
                //BMI	BMI Category
                //Less than 15	Very severely underweight
                //Between 15 and 16	Severely underweight
                //Between 16 and 18.5	Underweight
                //Between 18.5 and 25	Normal (healthy weight)
                //Between 25 and 30	Overweight
                //Between 30 and 35	Moderately obese
                //Between 35 and 40	Severely obese
                //Over 40	Very severely obese
                string BmiCat;
                if (BMI_Total < 15)
                {
                    BmiCat = "Very severely underweight";
                }
                else if (BMI_Total >= 15 && BMI_Total < 16)
                {
                    BmiCat = "Severely underweight";
                }
                else if (BMI_Total >= 16 && BMI_Total < 18.5)
                {
                    BmiCat = "Underweight";
                }
                else if (BMI_Total >= 18.5 && BMI_Total < 25)
                {
                    BmiCat = "Normal (healthy weight)";
                }
                else if (BMI_Total >= 25 && BMI_Total < 30)
                {
                    BmiCat = "Overweight";
                }
                else if (BMI_Total >= 30 && BMI_Total < 35)
                {
                    BmiCat = "Moderately obese";
                }
                else if (BMI_Total >= 35 && BMI_Total < 40)
                {
                    BmiCat = "Severely obese";
                }
                else
                {
                    BmiCat = "Very severely obese";
                }
                //lblBmi_Cat.Text = BmiCat;
                #endregion

                #region bloodpresure category
                int systolic = 0, diatolic = 0;
                if (!(int.TryParse(txtSystolic.Text, out systolic) && int.TryParse(txtDiastolic.Text, out diatolic)))
                {
                    MessageBox.Show("Please input a valid value");
                }

                var bloodpressureLevel = "";
                if (systolic <= 90 && diatolic <= 60)
                {
                    bloodpressureLevel = "Low Blood Pressure";
                }
                else if ((systolic >= 90 && systolic <= 120) && (diatolic >= 60 && diatolic <= 80))
                {
                    bloodpressureLevel = "Ideal and Helthy Blood Pressure";
                }
                else if ((systolic >= 120 && systolic <= 140) && (diatolic >= 80 && diatolic <= 90))
                {
                    bloodpressureLevel = "Normal blood pressure ";
                }
                else if (systolic >= 140 && diatolic >= 90)
                {
                    bloodpressureLevel = "High blood pressure";
                }
                else if (systolic >= 140 || diatolic >= 110)
                {
                    bloodpressureLevel = "High blood pressure";
                }
                else if (systolic <= 90 || diatolic <= 60)
                {
                    bloodpressureLevel = "Low blood pressure";
                }
                //lblBlood_Cat.Text = bloodpressureLevel;
                #endregion

                db.SP_STSAVE(txtcstid.Text, txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbplace.Text, txtadd.Text, cmbgen.Text, decimal.Parse(txtheight.Text), decimal.Parse(txtweight.Text), int.Parse(txtSystolic.Text), int.Parse(txtDiastolic.Text), chek1, chek2, chek3, chek4, txtpname.Text, txtcnumber.Text, txtoccu.Text, Convert.ToInt32(txtSecname.SelectedValue), Convert.ToInt32(cmbsyear.SelectedValue));
                MessageBox.Show("Student Successfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //linq insert
                TBL_BMICOMP bmi = new TBL_BMICOMP
                {
                    BMI_HWRESULT = BmiCat,
                    BMI_BPRESULT = bloodpressureLevel,
                    ST_CURRENTID = txtcstid.Text
                };
                db.TBL_BMICOMPs.InsertOnSubmit(bmi);
                db.SubmitChanges();
                
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
           
            
        }

        private void chk_subform138_Click(object sender, EventArgs e)
        {

        }

        private void chk_subgrademoral_Click(object sender, EventArgs e)
        {
           
        }

        private void chk_subnso_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSchoolYearForm ssyf = new AddSchoolYearForm();
            ssyf.ShowDialog();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearALL();
        }

        private void txtcnumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMIComputeForm bmi = new BMIComputeForm();
            bmi.ShowDialog();
        }

        private void txtbplace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtheight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtweight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSystolic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtDiastolic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtcstid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbylevel_SelectedValueChanged(object sender, EventArgs e)
        {
            var section = from s_section in db.TBL_SECTIONs
                          where s_section.SEC_YEARLEVEL == cmbylevel.Text
                          select s_section.SEC_NAME;

            txtSecname.Items.Clear(); 
            foreach (var item in section)
            {
                txtSecname.Items.Add(item);
            }
        }

        

       

       

        

        

      
        
       

       
       
    }
}
