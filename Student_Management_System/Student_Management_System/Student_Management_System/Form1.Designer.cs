namespace Student_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_slide = new Panel();
            button_exit = new Button();
            panel_scoresubmenu = new Panel();
            button_printScore = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_coursesubmenu = new Panel();
            button_printCourse = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
            button_course = new Button();
            panel_stdsubmenu = new Panel();
            button_printStd = new Button();
            button_statusStd = new Button();
            button_manageStd = new Button();
            button_registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label_female = new Label();
            label_male = new Label();
            label_total = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label4 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            panel_slide.SuspendLayout();
            panel_scoresubmenu.SuspendLayout();
            panel_coursesubmenu.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(panel_scoresubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_coursesubmenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_stdsubmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 561);
            panel_slide.TabIndex = 0;
            panel_slide.Paint += panel1_Paint;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 792);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(183, 55);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // panel_scoresubmenu
            // 
            panel_scoresubmenu.BackColor = Color.FromArgb(0, 71, 180);
            panel_scoresubmenu.Controls.Add(button_printScore);
            panel_scoresubmenu.Controls.Add(button_manageScore);
            panel_scoresubmenu.Controls.Add(button_newScore);
            panel_scoresubmenu.Dock = DockStyle.Top;
            panel_scoresubmenu.Location = new Point(0, 631);
            panel_scoresubmenu.Name = "panel_scoresubmenu";
            panel_scoresubmenu.Size = new Size(183, 161);
            panel_scoresubmenu.TabIndex = 5;
            // 
            // button_printScore
            // 
            button_printScore.Dock = DockStyle.Top;
            button_printScore.FlatAppearance.BorderSize = 0;
            button_printScore.FlatStyle = FlatStyle.Flat;
            button_printScore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_printScore.ForeColor = Color.White;
            button_printScore.Location = new Point(0, 100);
            button_printScore.Name = "button_printScore";
            button_printScore.Padding = new Padding(35, 0, 0, 0);
            button_printScore.Size = new Size(183, 50);
            button_printScore.TabIndex = 2;
            button_printScore.Text = "Print";
            button_printScore.TextAlign = ContentAlignment.MiddleLeft;
            button_printScore.UseVisualStyleBackColor = true;
            button_printScore.Click += button_printScore_Click;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageScore.ForeColor = Color.White;
            button_manageScore.Location = new Point(0, 50);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(35, 0, 0, 0);
            button_manageScore.Size = new Size(183, 50);
            button_manageScore.TabIndex = 1;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_newScore
            // 
            button_newScore.Dock = DockStyle.Top;
            button_newScore.FlatAppearance.BorderSize = 0;
            button_newScore.FlatStyle = FlatStyle.Flat;
            button_newScore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newScore.ForeColor = Color.White;
            button_newScore.Location = new Point(0, 0);
            button_newScore.Name = "button_newScore";
            button_newScore.Padding = new Padding(35, 0, 0, 0);
            button_newScore.Size = new Size(183, 50);
            button_newScore.TabIndex = 0;
            button_newScore.Text = "New Score";
            button_newScore.TextAlign = ContentAlignment.MiddleLeft;
            button_newScore.UseVisualStyleBackColor = true;
            button_newScore.Click += button_newScore_Click;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 576);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(183, 55);
            button_score.TabIndex = 4;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click;
            // 
            // panel_coursesubmenu
            // 
            panel_coursesubmenu.BackColor = Color.FromArgb(0, 71, 180);
            panel_coursesubmenu.Controls.Add(button_printCourse);
            panel_coursesubmenu.Controls.Add(button_manageCourse);
            panel_coursesubmenu.Controls.Add(button_newCourse);
            panel_coursesubmenu.Dock = DockStyle.Top;
            panel_coursesubmenu.Location = new Point(0, 415);
            panel_coursesubmenu.Name = "panel_coursesubmenu";
            panel_coursesubmenu.Size = new Size(183, 161);
            panel_coursesubmenu.TabIndex = 3;
            // 
            // button_printCourse
            // 
            button_printCourse.Dock = DockStyle.Top;
            button_printCourse.FlatAppearance.BorderSize = 0;
            button_printCourse.FlatStyle = FlatStyle.Flat;
            button_printCourse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_printCourse.ForeColor = Color.White;
            button_printCourse.Location = new Point(0, 100);
            button_printCourse.Name = "button_printCourse";
            button_printCourse.Padding = new Padding(35, 0, 0, 0);
            button_printCourse.Size = new Size(183, 50);
            button_printCourse.TabIndex = 3;
            button_printCourse.Text = "Print";
            button_printCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_printCourse.UseVisualStyleBackColor = true;
            button_printCourse.Click += button_printCourse_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageCourse.ForeColor = Color.White;
            button_manageCourse.Location = new Point(0, 50);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(35, 0, 0, 0);
            button_manageCourse.Size = new Size(183, 50);
            button_manageCourse.TabIndex = 1;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_newCourse
            // 
            button_newCourse.Dock = DockStyle.Top;
            button_newCourse.FlatAppearance.BorderSize = 0;
            button_newCourse.FlatStyle = FlatStyle.Flat;
            button_newCourse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newCourse.ForeColor = Color.White;
            button_newCourse.Location = new Point(0, 0);
            button_newCourse.Name = "button_newCourse";
            button_newCourse.Padding = new Padding(35, 0, 0, 0);
            button_newCourse.Size = new Size(183, 50);
            button_newCourse.TabIndex = 0;
            button_newCourse.Text = "New Course";
            button_newCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newCourse.UseVisualStyleBackColor = true;
            button_newCourse.Click += button_newCourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 360);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(183, 55);
            button_course.TabIndex = 2;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.BackColor = Color.FromArgb(0, 71, 180);
            panel_stdsubmenu.Controls.Add(button_printStd);
            panel_stdsubmenu.Controls.Add(button_statusStd);
            panel_stdsubmenu.Controls.Add(button_manageStd);
            panel_stdsubmenu.Controls.Add(button_registration);
            panel_stdsubmenu.Dock = DockStyle.Top;
            panel_stdsubmenu.Location = new Point(0, 155);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(183, 205);
            panel_stdsubmenu.TabIndex = 1;
            // 
            // button_printStd
            // 
            button_printStd.Dock = DockStyle.Top;
            button_printStd.FlatAppearance.BorderSize = 0;
            button_printStd.FlatStyle = FlatStyle.Flat;
            button_printStd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_printStd.ForeColor = Color.White;
            button_printStd.Location = new Point(0, 150);
            button_printStd.Name = "button_printStd";
            button_printStd.Padding = new Padding(35, 0, 0, 0);
            button_printStd.Size = new Size(183, 50);
            button_printStd.TabIndex = 3;
            button_printStd.Text = "Print";
            button_printStd.TextAlign = ContentAlignment.MiddleLeft;
            button_printStd.UseVisualStyleBackColor = true;
            button_printStd.Click += button_printStd_Click;
            // 
            // button_statusStd
            // 
            button_statusStd.Dock = DockStyle.Top;
            button_statusStd.FlatAppearance.BorderSize = 0;
            button_statusStd.FlatStyle = FlatStyle.Flat;
            button_statusStd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_statusStd.ForeColor = Color.White;
            button_statusStd.Location = new Point(0, 100);
            button_statusStd.Name = "button_statusStd";
            button_statusStd.Padding = new Padding(35, 0, 0, 0);
            button_statusStd.Size = new Size(183, 50);
            button_statusStd.TabIndex = 2;
            button_statusStd.Text = "Status";
            button_statusStd.TextAlign = ContentAlignment.MiddleLeft;
            button_statusStd.UseVisualStyleBackColor = true;
            button_statusStd.Click += button_statusStd_Click;
            // 
            // button_manageStd
            // 
            button_manageStd.Dock = DockStyle.Top;
            button_manageStd.FlatAppearance.BorderSize = 0;
            button_manageStd.FlatStyle = FlatStyle.Flat;
            button_manageStd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageStd.ForeColor = Color.White;
            button_manageStd.Location = new Point(0, 50);
            button_manageStd.Name = "button_manageStd";
            button_manageStd.Padding = new Padding(35, 0, 0, 0);
            button_manageStd.Size = new Size(183, 50);
            button_manageStd.TabIndex = 1;
            button_manageStd.Text = "Manage Student";
            button_manageStd.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStd.UseVisualStyleBackColor = true;
            button_manageStd.Click += button_manageStd_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_registration.ForeColor = Color.White;
            button_registration.Location = new Point(0, 0);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(35, 0, 0, 0);
            button_registration.Size = new Size(183, 50);
            button_registration.TabIndex = 0;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 100);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(183, 55);
            button_std.TabIndex = 0;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(183, 100);
            panel_logo.TabIndex = 1;
            panel_logo.Paint += panel_logo_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 63);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 5;
            label3.Text = "Dev Panda";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 48);
            label2.TabIndex = 4;
            label2.Text = "DP";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(200, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(914, 561);
            panel_main.TabIndex = 2;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Controls.Add(panel5);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(914, 561);
            panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources._class;
            pictureBox2.Location = new Point(3, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(899, 339);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label_female);
            panel2.Controls.Add(label_male);
            panel2.Controls.Add(label_total);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 81);
            panel2.TabIndex = 5;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(551, 15);
            label10.Name = "label10";
            label10.Size = new Size(101, 21);
            label10.TabIndex = 7;
            label10.Text = "Select Class";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(804, 48);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 6;
            label8.Text = "Female :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(696, 48);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 5;
            label9.Text = "Male :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(696, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 4;
            // 
            // label_female
            // 
            label_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_female.AutoSize = true;
            label_female.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_female.ForeColor = Color.White;
            label_female.Location = new Point(133, 41);
            label_female.Name = "label_female";
            label_female.Size = new Size(75, 21);
            label_female.TabIndex = 3;
            label_female.Text = "Female :";
            // 
            // label_male
            // 
            label_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_male.AutoSize = true;
            label_male.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_male.ForeColor = Color.White;
            label_male.Location = new Point(25, 41);
            label_male.Name = "label_male";
            label_male.Size = new Size(57, 21);
            label_male.TabIndex = 2;
            label_male.Text = "Male :";
            // 
            // label_total
            // 
            label_total.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_total.AutoSize = true;
            label_total.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_total.ForeColor = Color.White;
            label_total.Location = new Point(25, 11);
            label_total.Name = "label_total";
            label_total.Size = new Size(130, 21);
            label_total.TabIndex = 1;
            label_total.Text = "Total Students :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_role);
            panel1.Controls.Add(label_user);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 63);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Mushroom_1;
            pictureBox1.Location = new Point(810, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_role.ForeColor = Color.White;
            label_role.Location = new Point(133, 33);
            label_role.Name = "label_role";
            label_role.Size = new Size(62, 21);
            label_role.TabIndex = 3;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(133, 8);
            label_user.Name = "label_user";
            label_user.Size = new Size(75, 21);
            label_user.TabIndex = 2;
            label_user.Text = "Duc Huy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 33);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 1;
            label4.Text = "Role :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 8);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome :";
            // 
            // panel5
            // 
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(914, 57);
            panel5.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 71, 200);
            label11.Location = new Point(6, 20);
            label11.Name = "label11";
            label11.Size = new Size(165, 19);
            label11.TabIndex = 1;
            label11.Text = "Nha Trang University";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 549);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_scoresubmenu.ResumeLayout(false);
            panel_coursesubmenu.ResumeLayout(false);
            panel_stdsubmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_stdsubmenu;
        private Button button_registration;
        private Button button_printStd;
        private Button button_statusStd;
        private Button button_manageStd;
        private Button button_course;
        private Button button_score;
        private Panel panel_coursesubmenu;
        private Button button_printCourse;
        private Button button_manageCourse;
        private Button button_newCourse;
        private Panel panel_scoresubmenu;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_exit;
        private Button button_printScore;
        private Label label2;
        private Label label3;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel2;
        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Label label4;
        private Label label_role;
        private Label label_user;
        private Label label_male;
        private Label label_total;
        private Label label_female;
        private Label label10;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label11;
    }
}
