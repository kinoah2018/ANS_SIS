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
        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void btnChange_Click(object sender, EventArgs e)
        {
            if ( txtuname.Text != "" || txtNewpass.Text != "" || txtRetypepass.Text != "")
            {
                if (txtNewpass.Text != "1234" && txtRetypepass.Text != "1234")
                {
                    if (txtNewpass.Text.Length >= 8)
                    {
                        if (txtNewpass.Text == txtRetypepass.Text)
                        {
                            conn.Open();
                            SqlCommand get_UID = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME ='" + lbusername.Text + "'", conn);
                            int get_UID2 = Convert.ToInt32(get_UID.ExecuteScalar());
                            conn.Close();

                            db.SP_CHANGEDEFAULTPASS(get_UID2,txtuname.Text,txtNewpass.Text);
                            db.SP_SECUSAVE(cmbsecq.Text,txtans.Text,get_UID2);
                            if (cmbsecq.SelectedValue != null ||txtans.Text != "")
                            {
                                DialogResult dialog = MessageBox.Show("Information successfully changed ! \nDo you want to continue logging in ?", "Congrats !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (dialog == DialogResult.Yes)
                                {
                                    conn.Open();
                                    SqlCommand Utype = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERS WHERE USER_USERNAME = '" + lbusername.Text + "'", conn);
                                    string type = Convert.ToString(Utype.ExecuteScalar());
                                    conn.Close();

                                    if (type == "1")
                                    {
                                        HomeForm h = new HomeForm();
                                        conn.Open();
                                        h.pictureBox2.ImageLocation = Control_variables.img;
                                        h.lbUsername.Text = Control_variables.username;
                                        h.lbPosition.Text = Control_variables.type;
                                        this.Close();
                                        h.ShowDialog();
                                        conn.Close();
                                    }
                                    else if (type == "2")
                                    {
                                        HomeForm hs = new HomeForm();
                                        conn.Open();
                                        hs.pictureBox2.ImageLocation = Control_variables.img;
                                        hs.lbUsername.Text = Control_variables.username;
                                        hs.lbPosition.Text = Control_variables.type;
                                        this.Close();
                                        hs.ShowDialog();
                                        conn.Close();
                                    }

                                    else
                                    {
                                        HomeForm hs = new HomeForm();
                                        conn.Open();
                                        hs.pictureBox2.ImageLocation = Control_variables.img;
                                        hs.lbUsername.Text = Control_variables.username;
                                        hs.lbPosition.Text = Control_variables.type;
                                        this.Close();
                                        hs.ShowDialog();
                                        conn.Close();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Missing Security Question And Answer", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
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
            DialogResult dialog = MessageBox.Show("You are changing some of your Information! \nDo you want to close this form?","Ooops !",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialog)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lbusername_Click(object sender, EventArgs e)
        {

        }
    }
}
