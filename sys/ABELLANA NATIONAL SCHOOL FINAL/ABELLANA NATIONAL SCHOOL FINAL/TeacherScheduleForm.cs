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
    public partial class TeacherScheduleForm : Form
    {
        public TeacherScheduleForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
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

                dataGridView1.DataSource = db.SP_THSCHEDVIEW();
                
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
                db.SP_THSCHEDSAVE(txtTeachername.Text, Convert.ToInt32(cmbsection.SelectedValue.ToString()), txtsubject.Text, Convert.ToInt32(cmbStartEnd.SelectedValue.ToString()));
                MessageBox.Show("Successfully Saved");
                ClearALL();
                dataGridView1.DataSource = db.SP_THSCHEDVIEW();
            }
    }
}
