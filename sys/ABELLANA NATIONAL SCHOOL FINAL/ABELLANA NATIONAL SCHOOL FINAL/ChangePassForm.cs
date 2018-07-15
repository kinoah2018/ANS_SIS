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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewpass.Text != "" && txtRetypepass.Text != "")
            {
                if (txtNewpass.Text != "1234" && txtRetypepass.Text != "1234")
                {
                    if (txtNewpass.Text.Length >= 8)
                    {
                        if (txtNewpass.Text == txtRetypepass.Text)
                        {
                            db.SP_CHANGEPASS(txtuname.Text,txtNewpass.Text);
                            DialogResult dialog = MessageBox.Show("Password successfully changed ! \nDo you want to continue logging in ?", "Congrats !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialog == DialogResult.Yes)
                            {
                                conn.Open();
                                SqlCommand username = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand password = new SqlCommand("SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand userStat = new SqlCommand("SELECT ISACTIVE FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand FName = new SqlCommand("SELECT USER_FIRSTNAME FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand LName = new SqlCommand("SELECT USER_LASTNAME FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand Utype = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);
                                SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID = '" + txtuname.Text + "'", conn);

                                //CREATE STRING VARIABLES

                                string usern = Convert.ToString(username.ExecuteScalar());
                                string pass = Convert.ToString(password.ExecuteScalar());
                                string stat = Convert.ToString(userStat.ExecuteScalar());
                                string FIname = Convert.ToString(FName.ExecuteScalar());
                                string LAname = Convert.ToString(LName.ExecuteScalar());
                                string type = Convert.ToString(Utype.ExecuteScalar());
                                if (type == "1")
                                {
                                    type = "Admin";
                                }
                                else
                                {
                                    type = "Registrar";
                                }

                                conn.Close();
                                HomeAdminForm h = new HomeAdminForm();

                                // GET PICTURE 
                                conn.Open();
                                SqlCommand get_pic = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID='" + txtuname.Text + "'", conn);
                                Control_variables.img = Convert.ToString(get_pic.ExecuteScalar());
                                h.pictureBox2.ImageLocation = Control_variables.img;

                                h.lbUsername.Text = Control_variables.username;
                                h.lbPosition.Text = Control_variables.type;
                                this.Close();
                                h.ShowDialog();
                                conn.Close();
                            }
                            else
                            {
                                this.Close();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewpass.Focus();
                            txtRetypepass.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewpass.Clear();
                        txtRetypepass.Clear();
                        txtNewpass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please do not use the default password.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewpass.Clear();
                    txtRetypepass.Clear();
                    txtNewpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields","Ooops !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are changing your default pass! \nDo you want to close this form?","Oops.",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialog)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
