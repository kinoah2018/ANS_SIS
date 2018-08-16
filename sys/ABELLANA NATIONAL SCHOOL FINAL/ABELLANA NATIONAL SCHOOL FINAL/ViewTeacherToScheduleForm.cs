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
    public partial class ViewTeacherToScheduleForm : Form
    {
        public ViewTeacherToScheduleForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void dgvStudView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TeacherScheduleForm tsf = new TeacherScheduleForm();
            tsf.txtTeachername.Text = dgvTeacher.CurrentRow.Cells[0].Value.ToString();
            tsf.txtsubject.Text = dgvTeacher.CurrentRow.Cells[1].Value.ToString();
            this.Close();
            tsf.ShowDialog();
        }

        private void ViewTeacherToScheduleForm_Load(object sender, EventArgs e)
        {
            dgvTeacher.DataSource = db.View_THTOSCHEDs;
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
