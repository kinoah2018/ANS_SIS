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
    public partial class ReleasingBookForm : Form
    {
        public ReleasingBookForm()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReleasingBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet15.TBL_STUDENT' table. You can move, or remove it, as needed.
            this.tBL_STUDENTTableAdapter1.Fill(this.aNS_DATABASEDataSet15.TBL_STUDENT);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet14.TBL_STUDENT' table. You can move, or remove it, as needed.
            this.tBL_STUDENTTableAdapter.Fill(this.aNS_DATABASEDataSet14.TBL_STUDENT);

        }
    }
}
