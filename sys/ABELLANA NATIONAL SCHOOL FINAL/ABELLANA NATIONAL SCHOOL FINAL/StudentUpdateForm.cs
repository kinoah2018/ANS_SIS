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
    public partial class StudentUpdateForm : Form
    {
        public StudentUpdateForm()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
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
            if (txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == "" || cmbsyear.Text == "" || cmbylevel.Text == "" || dtpbdate.Text == "" || txtage.Text == "" || txtbplace.Text == "" || txtadd.Text == "" || cmbgen.Text == "" || txtcnumber.Text == "" || txtheight.Text == "" || txtweight.Text == "" || txtSystolic.Text == "" || txtpname.Text == "" || txtcnumber.Text == "" || txtoccu.Text == "")
            {
                MessageBox.Show("Input all fields.", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string chek1;
                if (chk_subform137.Checked)
                {
                    chek1 = "Submitted";
                }
                else
                {
                    chek1 = "Not Submitted";
                }
                string chek2;
                if (chk_subform138.Checked)
                {
                    chek2 = "Submitted";
                }
                else
                {
                    chek2 = "Not Submitted";
                }
                string chek3;
                if (chk_subgrademoral.Checked)
                {
                    chek3 = "Submitted";
                }
                else
                {
                    chek3 = "Not Submitted";
                }
                string chek4;
                if (chk_subnso.Checked)
                {
                    chek4 = "Submitted";
                }
                else
                {
                    chek4 = "Not Submitted";
                }
                db.SP_STUPDATE(txtcstid.Text,txtfname.Text,txtmname.Text,txtlname.Text,cmbylevel.Text,DateTime.Parse(dtpbdate.Text),int.Parse(txtage.Text),txtbplace.Text,txtadd.Text,cmbgen.Text,isactive,decimal.Parse(txtheight.Text),decimal.Parse(txtweight.Text),int.Parse(txtSystolic.Text),int.Parse(txtDiastolic.Text),chek1,chek2,chek3,chek4,int.Parse(lbPID.Text),txtpname.Text,txtcnumber.Text,txtoccu.Text,int.Parse(lbSecID.Text),txtSecname.Text,int.Parse(lbSYID.Text),cmbsyear.Text);
                MessageBox.Show("Student Successfully Update !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearALL();
                this.Close();
            }
        }
        public void ClearALL()
        {
            txtfname.Clear();
            txtlname.Clear();
            txtmname.Clear();
            cmbsyear.SelectedText = "";
            cmbylevel.SelectedText = "";
            dtpbdate.ResetText();
            txtage.Text = "0";
            txtbplace.Clear();
            txtadd.Clear();
            cmbgen.SelectedText = "";
            txtheight.Clear();
            txtweight.Clear();
            txtSystolic.Clear();
            txtpname.Clear();
            txtcnumber.Clear();
            txtoccu.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentUpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet5.TBL_SCHOOLYEAR' table. You can move, or remove it, as needed.
            this.tBL_SCHOOLYEARTableAdapter.Fill(this.aNS_DATABASEDataSet5.TBL_SCHOOLYEAR);
            // TODO: This line of code loads data into the 'aNS_DATABASEDataSet4.TBL_SECTION' table. You can move, or remove it, as needed.
            this.tBL_SECTIONTableAdapter.Fill(this.aNS_DATABASEDataSet4.TBL_SECTION);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SEC_NAME FROM TBL_SECTION WHERE SEC_ID='"+lbSecID.Text+"'",conn);
            SqlCommand get_sy = new SqlCommand("SELECT SCHOOLYEAR FROM TBL_SCHOOLYEAR WHERE SCHOOLYEAR_ID='" + lbSYID.Text + "'", conn);
            string cmd1 = Convert.ToString(cmd.ExecuteScalar());
            string get_sy1 = Convert.ToString(get_sy.ExecuteScalar());
            txtSecname.Text = cmd1;
            cmbstatus.Text = get_sy1;
            conn.Close();

        }

        private void dtpbdate_ValueChanged(object sender, EventArgs e)
        {
            txtage.Text = (DateTime.Today.Year - dtpbdate.Value.Year).ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void chk_subform137_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
