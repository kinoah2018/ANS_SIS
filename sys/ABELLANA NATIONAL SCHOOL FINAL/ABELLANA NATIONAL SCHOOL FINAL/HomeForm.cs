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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            
        }

        DataClasses2DataContext db = new DataClasses2DataContext();
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ANS_DATABASE;Integrated Security=True");
        private void msRegistration_Click(object sender, EventArgs e)
        {
                  
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LbDate.Text = DateTime.Now.ToLongDateString();
            LbTime.Text = DateTime.Now.ToLongTimeString();
      
        }

        private void LbTime_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to logout ?", "Wait !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }  

           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm pro = new UserProfileForm();
            pro.groupChangePass.Visible = false;
            conn.Open();
            SqlCommand Firstname = new SqlCommand("SELECT USER_FIRSTNAME FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            SqlCommand Lastname = new SqlCommand("SELECT USER_LASTNAME FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            SqlCommand Middlename = new SqlCommand("SELECT USER_MIDDLENAME FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            SqlCommand Utype = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERTYPE WHERE USER_TYPEID = '" + Control_variables.current_id + "'", conn);
            SqlCommand ContactNo = new SqlCommand("SELECT USER_CONTACT FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            SqlCommand cmd = new SqlCommand("SELECT USER_USERNAME FROM TBL_USERS WHERE USER_ID = '" + Control_variables.current_id + "'", conn);

            string fname = Convert.ToString(Firstname.ExecuteScalar());
            string lname = Convert.ToString(Lastname.ExecuteScalar());
            string midname = Convert.ToString(Middlename.ExecuteScalar());
            int pos = Convert.ToInt32(Utype.ExecuteScalar());
            string contactno = Convert.ToString(ContactNo.ExecuteScalar());
            string image = Convert.ToString(command.ExecuteScalar());
            string usern = Convert.ToString(cmd.ExecuteScalar());
            pro.txtFirstname.Text = fname;
            pro.txtLastname.Text = lname;
            pro.txtMiddlename.Text = midname;
            if (pos == 1)
            {
                pro.txtPosition.Text = "Admin";
            }
            else
            {
                pro.txtPosition.Text = "Registrar";
            }
            //pro.txtPosition.Text = pos;
            pro.txtContactNo.Text = contactno;
            pro.txtUserID.Text = Control_variables.current_id.ToString();
            pro.PB_image.ImageLocation = image;
            pro.lbluname.Text = usern;
           
            conn.Close();
            pro.ShowDialog();
        }

        private void menuRegistration_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand seltype = new SqlCommand("SELECT USER_TYPEID FROM TBL_USERTYPE WHERE USER_TYPE ='"+lbPosition.Text+"'",conn);
            int utype = Convert.ToInt32(seltype.ExecuteScalar());
            conn.Close();

            if (utype == 1)
            {
                AddUserForm addu = new AddUserForm();
                addu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only the Administrator was authorized to use!", "Ooops !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            


           
        }

   

        private void ProfiletoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            StudentProfileForm studp = new StudentProfileForm();
            studp.ShowDialog();
        }

        private void BMItoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BMIComputeForm bts = new BMIComputeForm();
            bts.ShowDialog();
        }

        private void GradestoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            StudentGradeForm sg = new StudentGradeForm();
            sg.ShowDialog();
        }

        private void SectiontoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AddSectionForm ss = new AddSectionForm();
            ss.ShowDialog();
        }

        private void RequirmentstoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            StudentRequirementForm sr = new StudentRequirementForm();
            sr.ShowDialog();
        }

        private void PaymenttoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            StudentPaymentDetailsForm spd = new StudentPaymentDetailsForm();
            spd.ShowDialog();
        }

        private void TProfiletoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            TeacherProfileForm tp = new TeacherProfileForm();
            tp.ShowDialog();
        }

        private void TSectiontoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void TScheduletoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            TeacherScheduleForm tes = new TeacherScheduleForm();
            tes.ShowDialog();
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            //conn.Open();
            //UserProfileForm upf = new UserProfileForm();
            //SqlCommand command = new SqlCommand("SELECT USER_IMAGE FROM TBL_USER WHERE USER_ID = '" + Control_variables.current_id + "'", conn);
            //string image = Convert.ToString(command.ExecuteScalar());
            //upf.PB_image.ImageLocation = image;
            
            //conn.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            InquiryForm inq = new InquiryForm();
            inq.ShowDialog();
        }

        
        private void ComplimentarytoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            AddBookForm bo = new AddBookForm();
            bo.ShowDialog();
        }

        private void ProfiletoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            StudentProfileForm spf = new StudentProfileForm();
            spf.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMItoolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            BMIComputeForm bcf = new BMIComputeForm();
            bcf.ShowDialog();
        }

        private void GradestoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            StudentGradeForm sgf = new StudentGradeForm();
            sgf.ShowDialog();  
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void SectiontoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            AddSectionForm sec = new AddSectionForm();
            sec.ShowDialog();
        }

        private void RequirmentstoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            StudentRequirementForm strec = new StudentRequirementForm();
            strec.ShowDialog();

        }

        private void ComplimentarytoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AddBookForm sbf = new AddBookForm();
            sbf.ShowDialog();
        }

        private void PaymenttoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            StudentPaymentDetailsForm spf = new StudentPaymentDetailsForm();
            spf.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AddSectionForm ssf = new AddSectionForm();
            ssf.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void BooktoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AddBookForm sbf = new AddBookForm();
            sbf.ShowDialog();
        }

        private void TProfiletoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            TeacherProfileForm tpf = new TeacherProfileForm();
            tpf.ShowDialog();
        }

        private void TScheduletoolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            TeacherScheduleForm tsf = new TeacherScheduleForm();
            tsf.ShowDialog();
        }

        private void TSubjecttoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AddSubjectForm tsf = new AddSubjectForm();
            tsf.ShowDialog();
        }

        private void menuStrip9_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ReltoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ReleasingBookForm bk = new ReleasingBookForm();
            bk.ShowDialog();
        }

        private void RettoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ReturningBooksForm br = new ReturningBooksForm();
            br.ShowDialog();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            InquiryForm inqf = new InquiryForm();
            inqf.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RequisitionOfRequirmentForm rrf = new RequisitionOfRequirmentForm();
            rrf.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SYPaymentForm sypf = new SYPaymentForm();
            sypf.ShowDialog();
        }
    }
}
