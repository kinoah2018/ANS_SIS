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
    public partial class TeacherScheduleForm : Form
    {
        public TeacherScheduleForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

            private void TeacherScheduleForm_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'aNS_DATABASEDataSet13.TBL_SECTION' table. You can move, or remove it, as needed.
                this.tBL_SECTIONTableAdapter.Fill(this.aNS_DATABASEDataSet13.TBL_SECTION);
                // TODO: This line of code loads data into the 'aNS_DATABASEDataSet12.View_CombSchedule' table. You can move, or remove it, as needed.
                this.view_CombScheduleTableAdapter1.Fill(this.aNS_DATABASEDataSet12.View_CombSchedule);
                // TODO: This line of code loads data into the 'aNS_DATABASEDataSet11.View_CombSchedule' table. You can move, or remove it, as needed.
                this.view_CombScheduleTableAdapter.Fill(this.aNS_DATABASEDataSet11.View_CombSchedule);


                if (txtTeachername.Text == "")
                {
                    dgvSchedule.DataSource = db.SP_THSCHEDVIEW();
                    this.dgvSchedule.Columns["TSCHED_ID"].Visible = false;
                    this.dgvSchedule.Columns["SEC_ID"].Visible = false;
                    this.dgvSchedule.Columns["TIME_ID"].Visible = false;
                }
                else
                {
                    dgvSchedule.DataSource = db.SP_THSCHEDSEARCH(txtTeachername.Text);
                    this.dgvSchedule.Columns["TSCHED_ID"].Visible = false;
                    this.dgvSchedule.Columns["SEC_ID"].Visible = false;
                    this.dgvSchedule.Columns["TIME_ID"].Visible = false;
                }
                    
              
            }

            private void button1_Click(object sender, EventArgs e)
            {
                ViewTeacherToScheduleForm vts = new ViewTeacherToScheduleForm();
                this.Close();
                vts.ShowDialog();
                
            }

            public void ClearALL()
            {
                txtTeachername.Clear();
                txtsubject.Text = "";
            }

            private void button2_Click(object sender, EventArgs e)
            {
                AddScheduleForm asf = new AddScheduleForm();
                asf.ShowDialog();
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                int result = db.SP_EXISTSEC(txtTeachername.Text, Convert.ToInt32(cmbsection.SelectedValue)).Count();
                if (txtTeachername.Text == "" && txtsubject.Text == "")
                {
                    MessageBox.Show("Missing Data!", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else if (result > 0)
                //{
                //    MessageBox.Show("You have already schedule for this section!", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                else
                {
                    db.SP_THSCHEDSAVE(txtTeachername.Text, Convert.ToInt32(cmbsection.SelectedValue), txtsubject.Text, Convert.ToInt32(cmbStartEnd.SelectedValue));
                    MessageBox.Show("Successfully Saved");
                    dgvSchedule.DataSource = db.SP_THSCHEDSEARCH(txtTeachername.Text);
                    this.dgvSchedule.Columns["TSCHED_ID"].Visible = false;
                    this.dgvSchedule.Columns["SEC_ID"].Visible = false;
                    this.dgvSchedule.Columns["TIME_ID"].Visible = false;

                }
                
               
            }

            private void txtSearch_TextChanged(object sender, EventArgs e)
            {
                if (txtSearch.Text == "")
                {
                    dgvSchedule.DataSource = db.SP_THSCHEDVIEW();
                }
                else
                {
                    dgvSchedule.DataSource = db.SP_THSCHEDSEARCH(txtSearch.Text);
                }
            }
    }
}
