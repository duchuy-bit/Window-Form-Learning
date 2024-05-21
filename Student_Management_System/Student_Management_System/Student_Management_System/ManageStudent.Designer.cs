namespace Student_Management_System
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            dataGridView_student = new DataGridView();
            panel2 = new Panel();
            textBox_id = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button_Delete = new Button();
            button_Update = new Button();
            button_Upload = new Button();
            pictureBox_Photo = new PictureBox();
            textBox_Address = new TextBox();
            radioButton_Female = new RadioButton();
            radioButton_Male = new RadioButton();
            label4 = new Label();
            dateTimePicker_dateOfBirth = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            textBox_Phone = new TextBox();
            label6 = new Label();
            textBox_LName = new TextBox();
            label2 = new Label();
            textBox_fName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            textBox_search = new TextBox();
            button_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Photo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 50);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(372, 12);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 0;
            label7.Text = "Manage Student";
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_student.BackgroundColor = SystemColors.ControlLight;
            dataGridView_student.BorderStyle = BorderStyle.None;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student.Location = new Point(-3, 96);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView_student.Size = new Size(918, 241);
            dataGridView_student.TabIndex = 17;
            dataGridView_student.CellClick += dataGridView_student_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button_Delete);
            panel2.Controls.Add(button_Update);
            panel2.Controls.Add(button_Upload);
            panel2.Controls.Add(pictureBox_Photo);
            panel2.Controls.Add(textBox_Address);
            panel2.Controls.Add(radioButton_Female);
            panel2.Controls.Add(radioButton_Male);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker_dateOfBirth);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_Phone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox_LName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_fName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 226);
            panel2.TabIndex = 18;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.BackColor = SystemColors.Menu;
            textBox_id.Enabled = false;
            textBox_id.Location = new Point(617, 135);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(119, 27);
            textBox_id.TabIndex = 53;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 71, 160);
            label8.Location = new Point(579, 139);
            label8.Name = "label8";
            label8.Size = new Size(32, 19);
            label8.TabIndex = 54;
            label8.Text = "ID :";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(519, 187);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 52;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Delete.BackColor = Color.Red;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.White;
            button_Delete.Location = new Point(781, 187);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(125, 36);
            button_Delete.TabIndex = 51;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Update
            // 
            button_Update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Update.BackColor = Color.OrangeRed;
            button_Update.FlatStyle = FlatStyle.Flat;
            button_Update.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Update.ForeColor = Color.White;
            button_Update.Location = new Point(650, 187);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(125, 36);
            button_Update.TabIndex = 50;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Upload.BackColor = Color.Green;
            button_Upload.FlatStyle = FlatStyle.Flat;
            button_Upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Upload.ForeColor = Color.White;
            button_Upload.Location = new Point(780, 146);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(125, 36);
            button_Upload.TabIndex = 48;
            button_Upload.Text = "Upload";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // pictureBox_Photo
            // 
            pictureBox_Photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_Photo.BackColor = Color.Gainsboro;
            pictureBox_Photo.Location = new Point(796, 48);
            pictureBox_Photo.Name = "pictureBox_Photo";
            pictureBox_Photo.Size = new Size(92, 92);
            pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Photo.TabIndex = 49;
            pictureBox_Photo.TabStop = false;
            // 
            // textBox_Address
            // 
            textBox_Address.Anchor = AnchorStyles.None;
            textBox_Address.Location = new Point(131, 114);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(437, 68);
            textBox_Address.TabIndex = 46;
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.None;
            radioButton_Female.AutoSize = true;
            radioButton_Female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_Female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_Female.Location = new Point(646, 82);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(86, 23);
            radioButton_Female.TabIndex = 43;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            radioButton_Male.Anchor = AnchorStyles.None;
            radioButton_Male.AutoSize = true;
            radioButton_Male.Checked = true;
            radioButton_Male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_Male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_Male.Location = new Point(573, 82);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(66, 23);
            radioButton_Male.TabIndex = 42;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(477, 84);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 47;
            label4.Text = "Gender :";
            // 
            // dateTimePicker_dateOfBirth
            // 
            dateTimePicker_dateOfBirth.Anchor = AnchorStyles.None;
            dateTimePicker_dateOfBirth.Location = new Point(131, 80);
            dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            dateTimePicker_dateOfBirth.Size = new Size(293, 27);
            dateTimePicker_dateOfBirth.TabIndex = 41;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(43, 114);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 44;
            label5.Text = "Address : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(11, 84);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 45;
            label3.Text = "Date Of Birth : ";
            // 
            // textBox_Phone
            // 
            textBox_Phone.Anchor = AnchorStyles.None;
            textBox_Phone.Location = new Point(573, 48);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(163, 27);
            textBox_Phone.TabIndex = 38;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(502, 52);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 40;
            label6.Text = "Phone :";
            // 
            // textBox_LName
            // 
            textBox_LName.Anchor = AnchorStyles.None;
            textBox_LName.Location = new Point(372, 48);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(119, 27);
            textBox_LName.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(267, 52);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 39;
            label2.Text = "Last Name :";
            // 
            // textBox_fName
            // 
            textBox_fName.Anchor = AnchorStyles.None;
            textBox_fName.Location = new Point(132, 48);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(123, 27);
            textBox_fName.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 35;
            label1.Text = "First Name : ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 10);
            panel3.TabIndex = 34;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(615, 60);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(157, 27);
            textBox_search.TabIndex = 19;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(781, 55);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 36);
            button_search.TabIndex = 53;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button2_Click;
            // 
            // ManageStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(dataGridView_student);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ManageStudent";
            Text = "ManageStudent";
            Load += ManageStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_student;
        private Panel panel2;
        private Panel panel3;
        private Button button_Upload;
        private PictureBox pictureBox_Photo;
        private TextBox textBox_Address;
        private RadioButton radioButton_Female;
        private RadioButton radioButton_Male;
        private Label label4;
        private DateTimePicker dateTimePicker_dateOfBirth;
        private Label label5;
        private Label label3;
        private TextBox textBox_Phone;
        private Label label6;
        private TextBox textBox_LName;
        private Label label2;
        private TextBox textBox_fName;
        private Label label1;
        private Button button_Delete;
        private Button button_Update;
        private Button button1;
        private TextBox textBox_search;
        private Button button_search;
        private TextBox textBox_id;
        private Label label8;
    }
}