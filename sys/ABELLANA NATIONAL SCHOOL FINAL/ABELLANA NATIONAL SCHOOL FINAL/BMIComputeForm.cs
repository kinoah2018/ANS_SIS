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
    public partial class BMIComputeForm : Form
    {
        public BMIComputeForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dt = db.TBL_BMICOMPs.FirstOrDefault(fdef => fdef.ST_CURRENTID == txtstcid.Text);
            if (String.IsNullOrWhiteSpace(txtResult.Text))
            {
                MessageBox.Show("No result was found !");
            }
            else if (dt==null)
            {
                //linq insert
                TBL_BMICOMP bmi = new TBL_BMICOMP
                {
                    BMI_HWRESULT = lblBmi_Cat.Text,
                    BMI_BPRESULT = lblBlood_Cat.Text,
                    ST_CURRENTID = txtstcid.Text
                };
                db.TBL_BMICOMPs.InsertOnSubmit(bmi);
                db.SubmitChanges();

                MessageBox.Show("Successfully Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstcid.Text = "";
                txtfulln.Text = "";
                txtheight.Text = "";
                txtweight.Text = "";
                txtSystolic.Text = "";
                txtDiastolic.Text = "";
                txtResult.Text = "";
                lblBlood_Cat.Visible = false;
                lblBmi_Cat.Visible = false;

                loadbmitable();
            }
            else
            {
                MessageBox.Show("Data cannot be duplicate !");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelStud_Click(object sender, EventArgs e)
        {
            View_SelectStudentForm vssf = new View_SelectStudentForm();
            this.Close();
            vssf.ShowDialog();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtstcid.Text=="")
            {
                MessageBox.Show("No value can be compute !");
            }
            else
            {

            #region Calculation BMI
            double BMI_Total;
            double wttotal;

            var data = db.TBL_STUDENTs.First(z=>z.ST_CURRENTID == txtstcid.Text);
            double get_height = (double)data.ST_HEIGHT;
            double get_weight = (double)data.ST_WEIGHT;
            //[ kg / ( ft / 3.28 = m) ] = Ans.
            wttotal = get_height/ 3.28;

            //[ kg / (ft * 3.28 = m2(m*m) ) ] = Ans.
            BMI_Total = (get_weight / Math.Pow((wttotal), 2));

            BMI_Total = Math.Round(BMI_Total, 2);//roundoff 2 decimal places
            //step 3: Get the result of the meter then divide it with your weight. 
            txtResult.Text = BMI_Total.ToString();
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
            else if (BMI_Total >= 25 && BMI_Total <30)
            {
                BmiCat = "Overweight";
            }
            else if (BMI_Total >= 30 && BMI_Total <35)
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
            lblBmi_Cat.Text = BmiCat;
            #endregion

            #region bloodpresure category
            int systolic = 0, diatolic = 0;
            if (!(int.TryParse(txtSystolic.Text, out systolic)&& int.TryParse(txtDiastolic.Text, out diatolic)))
            {
                MessageBox.Show("Please input a valid value");
            }
            
            var bloodpressureLevel = "";
            if (systolic <= 90  && diatolic <= 60)
            {
                bloodpressureLevel = "Low Blood Pressure";
            }
            else if ((systolic >= 90 && systolic <= 120) && (diatolic >= 60 && diatolic <= 80))
            {
                bloodpressureLevel = "Ideal and Helthy Blood Pressure";
            }
            else if ((systolic >= 120 && systolic <= 140 ) && (diatolic >= 80 && diatolic <= 90))  
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
            lblBlood_Cat.Text = bloodpressureLevel;
            #endregion

            lblBmi_Cat.Visible = true;
            lblBlood_Cat.Visible = true;
            }
           
        }

        private void txtfulln_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                loadbmitable();
            }
            else
            {
                dgvViewBmi.DataSource = from z in db.TBL_BMICOMPs
                                        where z.ST_CURRENTID.Contains(txtSearch.Text)
                                        select new
                                        {
                                            z.ST_CURRENTID,
                                            z.BMI_HWRESULT,
                                            z.BMI_BPRESULT
                                        };
            }
           

        }

        private void BMIComputeForm_Load(object sender, EventArgs e)
        {
            loadbmitable();
        }

        private void loadbmitable()
        {
            //// linq display data table in dgv 
            //dgvViewBmi.DataSource = from z in db.TBL_BMICOMPs
            //                        select new
            //                        {
            //                            z.ST_CURRENTID,
            //                            z.BMI_HWRESULT,
            //                            z.BMI_BPRESULT
            //                        };
            dgvViewBmi.DataSource = db.SP_VIEWBMI();
        }

        private void dgvViewBmi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
