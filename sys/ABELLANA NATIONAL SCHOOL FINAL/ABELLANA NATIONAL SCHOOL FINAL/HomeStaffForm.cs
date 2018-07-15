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
    public partial class HomeStaffForm : Form
    {
        public HomeStaffForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeStaffForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LbDate.Text = DateTime.Now.ToLongDateString();
            LbTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
