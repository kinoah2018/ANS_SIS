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
    public partial class StudentGradeForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses2DataContext db = new DataClasses2DataContext();

        public StudentGradeForm()
        {
            InitializeComponent();

           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet9.TBL_SUBJECT' table. You can move, or remove it, as needed.
            this.tBL_SUBJECTTableAdapter1.Fill(this.aNS_DATABASEDataSet9.TBL_SUBJECT);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet2.TBL_STUDENT' table. You can move, or remove it, as needed.
            this.tBL_STUDENTTableAdapter.Fill(this.aNS_DATABASEDataSet2.TBL_STUDENT);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet1.TBL_SUBJECT' table. You can move, or remove it, as needed.
            //this.tBL_SUBJECTTableAdapter.Fill(this.aNS_DATABASEDataSet1.TBL_SUBJECT);

            loadsubject();

            conn.Open();

            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub + "' AND GRADEPERIOD = 'First Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd1.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[2].Value = read[3].ToString();
                }
                read.Close();
                cmd1.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub2 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub2 + "' AND GRADEPERIOD = 'Second Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd2.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[3].Value = read[3].ToString();
                }
                read.Close();
                cmd2.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub3 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub3 + "' AND GRADEPERIOD = 'Third Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd3.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[4].Value = read[3].ToString();
                }
                read.Close();
                cmd3.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub4 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub4 + "' AND GRADEPERIOD = 'Fourth Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd4.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[5].Value = read[3].ToString();
                }
                read.Close();
                cmd4.Dispose();
            }
            conn.Close();

             
        }

        public void loadsubject()
        {
            dgvGrade.Rows.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_SUBJECT", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgvGrade.Rows.Add(rdr[0], rdr[1]);
            }
            cmd.Dispose();
            conn.Close();
        }

        private void cmbsstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadsubject();
            conn.Open();
            
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {
                
                string sub = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub + "' AND GRADEPERIOD = 'First Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd1.ExecuteReader();
                
                while (read.Read())
                {
                    
                    dgvGrade.Rows[i].Cells[2].Value = read[3].ToString();
                }
                read.Close();
                cmd1.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub2 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub2 + "' AND GRADEPERIOD = 'Second Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd2.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[3].Value = read[3].ToString();
                }
                read.Close();
                cmd2.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub3 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub3 + "' AND GRADEPERIOD = 'Third Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd3.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[4].Value = read[3].ToString();
                }
                read.Close();
                cmd3.Dispose();
            }
            conn.Close();

            conn.Open();
            for (int i = 0; i < dgvGrade.Rows.Count; i++)
            {

                string sub4 = dgvGrade.Rows[i].Cells[0].Value.ToString();
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM TBL_GRADE WHERE SUBJECT_ID ='" + sub4 + "' AND GRADEPERIOD = 'Fourth Grading' AND ST_CURRENTID ='" + txtscid.Text + "'", conn);
                SqlDataReader read = cmd4.ExecuteReader();

                while (read.Read())
                {

                    dgvGrade.Rows[i].Cells[5].Value = read[3].ToString();
                }
                read.Close();
                cmd4.Dispose();
            }
            conn.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                db = new DataClasses2DataContext();
                var checkIfExist = from grade in db.TBL_GRADEs
                                   where grade.ST_CURRENTID == txtscid.Text && grade.GRADEPERIOD == txtgrper.Text && grade.SUBJECT_ID == Convert.ToInt32(txtsub.SelectedValue)
                                   select grade;
                var checkFourth = from grade in db.TBL_GRADEs
                                  where grade.ST_CURRENTID == txtscid.Text && grade.GRADEPERIOD == "Third Grading" && grade.SUBJECT_ID == Convert.ToInt32(txtsub.SelectedValue)
                                  select grade;
                var checkThird = from grade in db.TBL_GRADEs
                                 where grade.ST_CURRENTID == txtscid.Text && grade.GRADEPERIOD == "Second Grading" && grade.SUBJECT_ID == Convert.ToInt32(txtsub.SelectedValue)
                                 select grade;
                var checkSecond = from grade in db.TBL_GRADEs
                                  where grade.ST_CURRENTID == txtscid.Text && grade.GRADEPERIOD == "First Grading" && grade.SUBJECT_ID == Convert.ToInt32(txtsub.SelectedValue)
                                  select grade;
                if (txtscid.Text == "" || txtgrper.Text == "" || txtgrade.Text == "" || txtFname.Text == "")
                {
                    MessageBox.Show("Incomplete Data !", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (checkIfExist.Count() > 0)
                {
                    MessageBox.Show("If you want something to change you need to update", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (txtgrper.Text == "Fourth Grading")
                    {
                        if (checkFourth.Count() > 0)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_GRADE VALUES('" + txtscid.Text + "','" + txtgrper.Text + "','" + txtgrade.Text + "','" + txtsub.SelectedValue + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            int currentindex = txtsub.SelectedIndex;
                            txtgrade.Text = "";

                            conn.Close();
                            StudentGrade_Load(this, null);
                            if (txtsub.Items.Count - 1 == currentindex)
                            {
                                currentindex = -1;
                            }
                            txtsub.SelectedIndex = currentindex + 1;
                        }
                        else
                        {
                            MessageBox.Show("You need to complete grades in third grading", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if (txtgrper.Text == "Third Grading")
                    {
                        if (checkThird.Count() > 0)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_GRADE VALUES('" + txtscid.Text + "','" + txtgrper.Text + "','" + txtgrade.Text + "','" + txtsub.SelectedValue + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int currentindex = txtsub.SelectedIndex;
                            txtgrade.Text = "";

                            conn.Close();
                            StudentGrade_Load(this, null);
                            if (txtsub.Items.Count - 1 == currentindex)
                            {
                                currentindex = -1;
                            }
                            txtsub.SelectedIndex = currentindex + 1;
                        }
                        else
                        {
                            MessageBox.Show("You need to complete grades in second grading", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if (txtgrper.Text == "Second Grading")
                    {
                        if (checkSecond.Count() > 0)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_GRADE VALUES('" + txtscid.Text + "','" + txtgrper.Text + "','" + txtgrade.Text + "','" + txtsub.SelectedValue + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int currentindex = txtsub.SelectedIndex;
                            txtgrade.Text = "";

                            conn.Close();
                            StudentGrade_Load(this, null);
                            if (txtsub.Items.Count - 1 == currentindex)
                            {
                                currentindex = -1;
                            }
                            txtsub.SelectedIndex = currentindex + 1;
                        }
                        else
                        {
                            MessageBox.Show("You need to complete grades in first grading", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_GRADE VALUES('" + txtscid.Text + "','" + txtgrper.Text + "','" + txtgrade.Text + "','" + txtsub.SelectedValue + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int currentindex = txtsub.SelectedIndex;
                            txtgrade.Text = "";

                            conn.Close();
                            StudentGrade_Load(this, null);
                            if (txtsub.Items.Count - 1 == currentindex)
                            {
                                currentindex = -1;
                            }
                            txtsub.SelectedIndex = currentindex + 1;
                    }
                }
           
            }
            else
            {
                btnSave.Text = "Save";
                txtgrade.Clear();
                txtgrper.SelectedIndex = -1;
            }
            
           

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ClearAll()
        {
            txtsub.SelectedItem = null;
            txtgrper.SelectedItem = null;
            txtgrade.Text = "";

        }

        private void txtgrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db = new DataClasses2DataContext();
            var grade = db.TBL_GRADEs.FirstOrDefault(g => g.ST_CURRENTID.Equals(txtscid.Text)&&g.SUBJECT_ID.Equals(Convert.ToInt32(txtsub.SelectedValue))&&g.GRADEPERIOD.Equals(txtgrper.Text));
            grade.GRADE = int.Parse(txtgrade.Text);
            db.SubmitChanges();
            MessageBox.Show("Successfully Update","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            StudentGrade_Load(this, null);
            btnViewStud.Enabled = true;
            txtgrade.Text = "";
            txtgrper.SelectedItem = null;
            txtsub.SelectedValue = -1;
        }

        private void dgvGrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnHeader = dgvGrade.SelectedCells[0].OwningColumn.HeaderText;
            string cellValue = dgvGrade.SelectedCells[0].Value.ToString();
            int selectedrowindex = dgvGrade.SelectedCells[0].RowIndex;
            string sub =Convert.ToString(dgvGrade.Rows[selectedrowindex].Cells["SUBJECT"].Value);
            txtgrper.Text = columnHeader;
            txtgrade.Text = cellValue;
            txtsub.Text = sub;
            btnUpdate.Enabled = true;
            txtsub.Enabled = false;
            txtgrper.Enabled = false;
            
        }

        private void dgvGrade_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtscid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgrper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnViewStud_Click(object sender, EventArgs e)
        {
            View_Student1Form vsf = new View_Student1Form();
            this.Close();
            vsf.ShowDialog();
            
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
    }
}
