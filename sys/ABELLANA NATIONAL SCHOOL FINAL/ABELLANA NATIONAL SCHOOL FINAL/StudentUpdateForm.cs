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
    public partial class StudentUpdateForm : Form
    {
        public StudentUpdateForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isactive = false;
            if (cmbstatus.Text == "Active")
            {
                isactive = true;
            }
            else
            {
                isactive = false;
            }
            db.SP_STUPDATE(int.Parse(txtSTID.Text),txtfname.Text, txtmname.Text, txtlname.Text, cmbylevel.Text, cmbsyear.Text, DateTime.Parse(dtpbdate.Text), int.Parse(txtage.Text), txtbplace.Text
               , txtadd.Text, cmbgen.Text, txtcnumber.Text,isactive, decimal.Parse(txtheight.Text), decimal.Parse(txtheight.Text), txtbp.Text,int.Parse(txtPID.Text), txtpname.Text, txtcnumber.Text, txtoccu.Text, txtptype.Text );
            MessageBox.Show("Wala na Finish na!");
            
        }
    }
}
