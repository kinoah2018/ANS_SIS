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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        DataClasses1DataContext db = new DataClasses1DataContext();
        Hashpass hp = new Hashpass();

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewUserForm v = new ViewUserForm();
            v.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet.TBL_USERTYPE' table. You can move, or remove it, as needed.
            this.tBL_USERTYPETableAdapter.Fill(this.aNS_DATABASEDataSet.TBL_USERTYPE);
            txtPassword.Text = "1234";
        }

        public void ClearAll()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMiddlename.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtContactNo.Clear();
            PB_image.ImageLocation = null;
            cmbutype.SelectedItem = null;
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Images | *.jpg";
            op.ShowDialog();
            Control_variables.img = op.FileName;
            PB_image.ImageLocation = Control_variables.img;
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtMiddlename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm h = new HomeForm();
            AddUserForm a = new AddUserForm();
            h.msRegistration.BackColor = Color.Black;
            h.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_USERNAME LIKE'" + txtUsername.Text + "'", conn);
            string get_uname = Convert.ToString(command.ExecuteScalar());
            conn.Close();
            if (txtLastname.Text == "" || txtFirstname.Text == "" || txtMiddlename.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtContactNo.Text == "" || PB_image.ImageLocation == null || txtUsername.Text == "")
            {
                MessageBox.Show("Information Required! Please fill out the necessary fields", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (txtUsername.Text == get_uname)
            {
                MessageBox.Show("Username exist already", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Control_variables.type = "Administrator";
                TBL_USER u = new TBL_USER();
                string dateNow = DateTime.Now.ToShortDateString();
                u.USER_IMAGE = Control_variables.img;
                Image im = Image.FromFile(Control_variables.img);
                u.USER_IMAGE = Photo.byteArrayToBase64String(Photo.imageToByteArray(im));
                db.SP_USERSAVE(txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtUsername.Text, txtPassword.Text, txtContactNo.Text, Control_variables.type, int.Parse(cmbutype.SelectedValue.ToString()), Control_variables.img);
                MessageBox.Show("User Successfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();

            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            string lname = txtLastname.Text;
            if (lname.Length >= 4)
            {
                if (txtFirstname.TextLength >= 4)
                {
                    txtUsername.Text = lname.Substring(0, 4) + txtFirstname.Text.Substring(0, 4);
                }
                else
                {
                    txtUsername.Text = lname.Substring(0, 4);
                }


            }


        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text;
            if (fname.Length >= 4)
            {
                txtUsername.Text = txtLastname.Text.Substring(0, 4) + fname.Substring(0, 4);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
          
        }


    }
}
    
        