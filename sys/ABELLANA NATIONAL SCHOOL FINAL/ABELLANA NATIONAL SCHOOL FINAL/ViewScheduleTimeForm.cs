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
    public partial class ViewScheduleTimeForm : Form
    {
        public ViewScheduleTimeForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void ViewScheduleTimeForm_Load(object sender, EventArgs e)
        {
            dgvTime.DataSource = db.SP_VIEWTIME();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
