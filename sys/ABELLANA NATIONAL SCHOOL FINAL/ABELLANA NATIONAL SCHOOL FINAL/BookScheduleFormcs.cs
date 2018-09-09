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
    public partial class BookScheduleFormcs : Form
    {
        public BookScheduleFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookScheduleFormcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet16.TBL_SCHOOLYEAR' table. You can move, or remove it, as needed.
            this.tBL_SCHOOLYEARTableAdapter.Fill(this.aNS_DATABASEDataSet16.TBL_SCHOOLYEAR);

        }
    }
}
