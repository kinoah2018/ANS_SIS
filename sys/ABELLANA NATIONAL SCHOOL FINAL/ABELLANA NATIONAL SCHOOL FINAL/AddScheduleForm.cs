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
    public partial class AddScheduleForm : Form
    {
        public AddScheduleForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string timestart = cmbTimeStartHH.Text + ":" + cmbTimeStartMM.Text + ":" + cmbsessionstart.Text;
            string timeEnd = cmbTimeEndHH.Text + ":" + cmbTimeEndMM.Text + ":" + cmbsessEnd.Text;
            db.SP_SAVETIME(timestart,timeEnd);
            MessageBox.Show("Successfully Added !");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewScheduleTimeForm v = new ViewScheduleTimeForm();
            v.ShowDialog();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
