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
    public partial class View_Student1Form : Form
    {
        public View_Student1Form()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void View_Student1Form_Load(object sender, EventArgs e)
        {
            dgvStudView.DataSource = db.View_Student1s;
        }

        private void dgvStudView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentGradeForm sgf = new StudentGradeForm();

            sgf.txtscid.Text = dgvStudView.CurrentRow.Cells[0].Value.ToString();
            sgf.txtFname.Text = dgvStudView.CurrentRow.Cells[1].Value.ToString() + " " + dgvStudView.CurrentRow.Cells[2].Value.ToString() + " " + dgvStudView.CurrentRow.Cells[3].Value.ToString();
            sgf.txtSY.Text = dgvStudView.CurrentRow.Cells[4].Value.ToString();

            this.Close();
            sgf.dgvGrade.Enabled = true;
            sgf.ShowDialog();
            
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
