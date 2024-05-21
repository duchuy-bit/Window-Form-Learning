using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System.Xml.Serialization;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_total.Text = "Total Students : " + getTotalStudent();
            label_male.Text = "Male : " + getTotalMale();
            label_female.Text = "Female : " + getTotalFemale();
        }

        private void customizeDesign()
        {
            studentCount();
        }
        void studentCount()
        {
            panel_stdsubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
            panel_coursesubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_stdsubmenu.Visible == true)
            {
                panel_stdsubmenu.Visible = false;
            }

            if (panel_scoresubmenu.Visible == true)
            {
                panel_scoresubmenu.Visible = false;
            }

            if (panel_coursesubmenu.Visible == true)
            {
                panel_coursesubmenu.Visible = false;
            }
        }

        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Student_Button
        private void button_std_Click(object sender, EventArgs e)
        {
            showMenu(panel_stdsubmenu);
        }
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudent());
        }

        private void button_statusStd_Click(object sender, EventArgs e)
        {

        }

        private void button_printStd_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Course_Button 
        private void button_course_Click(object sender, EventArgs e)
        {
            showMenu(panel_coursesubmenu);
        }
        private void button_newCourse_Click(object sender, EventArgs e)
        {

        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {

        }

        private void button_printCourse_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Score_Button
        private void button_score_Click(object sender, EventArgs e)
        {
            showMenu(panel_scoresubmenu);
        }

        private void button_newScore_Click(object sender, EventArgs e)
        {

        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {

        }

        private void button_printScore_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Exit Button

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        //Show Register From Main Form
        private Form activateFrom = null;
        private void openChildForm(Form childForm)
        {
            if (activateFrom != null)
            {
                activateFrom.Close();
            }

            activateFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public string getTotalStudent()
        {
            StudentClass studentClass = new StudentClass();
            return studentClass.exeCount("SELECT COUNT(*) FROM student");
        }

        public string getTotalMale()
        {
            StudentClass studentClass = new StudentClass();
            return studentClass.exeCount("SELECT COUNT(*) FROM student where gender = 'Male' ");
        }

        public string getTotalFemale()
        {
            StudentClass studentClass = new StudentClass();
            return studentClass.exeCount("SELECT COUNT(*) FROM student where gender = 'Female' ");
        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            showDashboard();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            showDashboard();
        }

        void showDashboard()
        {
            if (activateFrom != null)
            {
                activateFrom.Close();
            }

            panel_main.Controls.Add(panel_cover);
            studentCount();
        }
    }
}
