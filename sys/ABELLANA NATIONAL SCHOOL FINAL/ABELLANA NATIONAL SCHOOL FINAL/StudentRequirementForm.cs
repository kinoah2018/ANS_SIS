﻿using System;
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
    public partial class StudentRequirementForm : Form
    {
        public StudentRequirementForm()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentRequirementForm_Load(object sender, EventArgs e)
        {
            dgvRequirment.DataSource = db.View_Requirments;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvRequirment.DataSource = db.SP_STREQSEARCH(textBox1.Text);
        }

 

      
    }
}
