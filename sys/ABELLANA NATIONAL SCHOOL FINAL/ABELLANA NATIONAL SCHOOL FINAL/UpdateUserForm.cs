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
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ViewUserForm vuf = new ViewUserForm();
            vuf.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand get_ident = new SqlCommand("SELECT USER_ID FROM TBL_USERS WHERE USER_ID='" + txtUser_ID.Text + "'", conn);
            Control_variables.identity_id = Convert.ToInt32(get_ident.ExecuteScalar());
            
            conn.Close();
            bool isactive = true;
            if (cmbStatus.Text == "Active")
            {
                isactive = true;
            }
            else
            {
                isactive = false;
            }
            
            int identity = Control_variables.identity_id;
            string datenow = DateTime.Now.ToShortDateString();
            db.SP_USERUPDATE(int.Parse(txtUser_ID.Text), txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, txtUsername.Text, isactive, PB_image.ImageLocation);
            MessageBox.Show("User Successfully Updated","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
            
            
        }
        public void ClearAll()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMiddlename.Clear();
            txtUsername.Clear();
            PB_image.ImageLocation = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand get_picsure = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID = '"+txtUser_ID.Text+"'",conn);
            string pic = Convert.ToString(get_picsure.ExecuteScalar());
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Images | *.jpg";
            op.ShowDialog();
            pic = op.FileName;
            PB_image.ImageLocation = pic;
            conn.Close();
        }
    }
}
