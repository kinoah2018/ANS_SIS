﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //ADO CONNECTION
            conn.Open();

            SqlCommand username = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand ID = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand password = new SqlCommand("SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand isActive = new SqlCommand("SELECT ISACTIVE FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand FName = new SqlCommand("SELECT USER_FIRSTNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand LName = new SqlCommand("SELECT USER_LASTNAME FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand type = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);
            SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_USERNAME LIKE '" + txtUsername.Text + "'", conn);

            //CREATE STRING VARIABLES

            string usern = Convert.ToString(username.ExecuteScalar());
            string USERID = Convert.ToString(ID.ExecuteScalar());
            string pass = Convert.ToString(password.ExecuteScalar());
            string stat = Convert.ToString(isActive.ExecuteScalar());
            string FIname = Convert.ToString(FName.ExecuteScalar());
            string LAname = Convert.ToString(LName.ExecuteScalar());
            int utype = Convert.ToInt32(type.ExecuteScalar());
            if (utype == 1)
            {
                Control_variables.type = "Admin";
            }
            else
            {
                Control_variables.type = "Registrar";
            }
            conn.Close();



            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (txtUsername.Text == usern && txtPassword.Text == pass)
                {
                    ChangePassForm changepass = new ChangePassForm();
                    Control_variables.username = FIname.ToString() + " " + LAname.ToString();
                    if (stat == "True")
                    {
                        if (pass == "1234")
                        {
                            conn.Open();
                            SqlCommand get_id = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME='" + txtUsername.Text + "'", conn);
                            Control_variables.current_id = Convert.ToInt32(get_id.ExecuteScalar());

                            changepass.lbname.Text = Control_variables.username;
                            changepass.lbusername.Text = usern;
                            changepass.txtDefaultpass.Text = pass.ToString();


                            txtUsername.Clear();
                            txtPassword.Clear();
                            changepass.ShowDialog();
                            conn.Close();
                        }
                        else
                        {
                            if (utype == 1)
                            {
                               MessageBox.Show("Welcome " + Control_variables.username,"ADMIN",MessageBoxButtons.OK,MessageBoxIcon.Information);

                               HomeForm h = new HomeForm();                   
                               // GET PICTURE 
                               conn.Open();
                               SqlCommand get_pic = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_USERNAME LIKE'"+txtUsername.Text+"'",conn);
                               Control_variables.img = Convert.ToString(get_pic.ExecuteScalar());
                               h.pictureBox2.ImageLocation = Control_variables.img;
                               SqlCommand get_id = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME LIKE'"+txtUsername.Text+"'",conn);
                               Control_variables.current_id = Convert.ToInt32(get_id.ExecuteScalar());

                               conn.Close();

                               //PASS VARIABLES
                               h.lbUsername.Text = Control_variables.username;
                               h.lbPosition.Text = Control_variables.type;
                                                                                       
                               //CLEAR TEXTBOXES
                               txtUsername.Clear();
                               txtPassword.Clear();

                              
                               
                               h.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Welcome " + Control_variables.username, "STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                HomeForm hs = new HomeForm();
                                // GET PICTURE 
                                conn.Open();
                                SqlCommand get_pic = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_USERNAME LIKE'" + txtUsername.Text + "'", conn);
                                Control_variables.img = Convert.ToString(get_pic.ExecuteScalar());
                                hs.pictureBox2.ImageLocation = Control_variables.img;
                                SqlCommand get_id = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_USERNAME LIKE'" + txtUsername.Text + "'", conn);
                                Control_variables.current_id = Convert.ToInt32(get_id.ExecuteScalar());

                                conn.Close();

                                //PASS VARIABLES
                                hs.lbUsername.Text = Control_variables.username;
                                hs.lbPosition.Text = Control_variables.type;

                                //CLEAR TEXTBOXES
                                txtUsername.Clear();
                                txtPassword.Clear();



                                hs.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your account is Inactive, Please contact your Administrator.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Password!");
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please input Username and Password");
                txtUsername.Focus();
            }

   }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnfpass_Click(object sender, EventArgs e)
        {
            ForgotPassForm fpf = new ForgotPassForm();
            fpf.ShowDialog();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        }
    }

