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
        DataClasses2DataContext db = new DataClasses2DataContext();
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
            dgvBooks.DataSource = db.SP_VIEWSTUDBOOKS();

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var x = from s in db.TBL_BOOKs
                    where s.BOOK_YEARLEVEL == cmbYearlevel.Text
                    select s;

            cmbAvailablebooks.ValueMember = "B_ID";
            cmbAvailablebooks.DisplayMember = "B_BOOKNAME";
            cmbAvailablebooks.DataSource = x;
           
        }

        private void txtStudID_Leave(object sender, EventArgs e)
        {
           
            var x = db.TBL_STUDENTs.FirstOrDefault(z => z.ST_CURRENTID == txtStudID.Text);
            if (x == null)
            {
                MessageBox.Show("Student Not FOund !");
            }
            else
            {
                txtStudentName.Text = x.ST_FIRSTNAME + " " + x.ST_MIDDLENAME + " " + x.ST_LASTNAME;
            }
            
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            TBL_STUDBOOK bookavail = new TBL_STUDBOOK();
            bookavail.B_ID =Convert.ToInt32(cmbAvailablebooks.SelectedValue);
            bookavail.ST_CURRENTID = txtStudID.Text;
            bookavail.RETURNDATE = null;
            db.TBL_STUDBOOKs.InsertOnSubmit(bookavail);
            db.SubmitChanges();
            MessageBox.Show("Successfully Added!");
        }
    }
}
