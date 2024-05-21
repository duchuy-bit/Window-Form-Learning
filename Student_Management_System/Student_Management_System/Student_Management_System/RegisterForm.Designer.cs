namespace Student_Management_System
{
    partial class RegisterForm
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
            panel3 = new Panel();
            button_Add = new Button();
            button_Clear = new Button();
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
            panel1.Size = new Size(918, 64);
            panel1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(424, 19);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 0;
            label7.Text = "Registration";
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_student.BackgroundColor = SystemColors.ControlLight;
            dataGridView_student.BorderStyle = BorderStyle.None;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student.Location = new Point(0, 64);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView_student.Size = new Size(918, 241);
            dataGridView_student.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button_Add);
            panel2.Controls.Add(button_Clear);
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
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 227);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 10);
            panel3.TabIndex = 33;
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Add.BackColor = Color.FromArgb(0, 71, 160);
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.ForeColor = Color.White;
            button_Add.Location = new Point(781, 188);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(125, 36);
            button_Add.TabIndex = 31;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.Orange;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(650, 188);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(125, 36);
            button_Clear.TabIndex = 30;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Upload
            // 
            button_Upload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Upload.BackColor = Color.Green;
            button_Upload.FlatStyle = FlatStyle.Flat;
            button_Upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Upload.ForeColor = Color.White;
            button_Upload.Location = new Point(781, 141);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(125, 36);
            button_Upload.TabIndex = 29;
            button_Upload.Text = "Upload";
            button_Upload.UseVisualStyleBackColor = false;
            button_Upload.Click += button_Upload_Click;
            // 
            // pictureBox_Photo
            // 
            pictureBox_Photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_Photo.BackColor = Color.Gainsboro;
            pictureBox_Photo.Location = new Point(781, 20);
            pictureBox_Photo.Name = "pictureBox_Photo";
            pictureBox_Photo.Size = new Size(125, 115);
            pictureBox_Photo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Photo.TabIndex = 32;
            pictureBox_Photo.TabStop = false;
            // 
            // textBox_Address
            // 
            textBox_Address.Anchor = AnchorStyles.None;
            textBox_Address.Location = new Point(131, 109);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(605, 68);
            textBox_Address.TabIndex = 27;
            // 
            // radioButton_Female
            // 
            radioButton_Female.Anchor = AnchorStyles.None;
            radioButton_Female.AutoSize = true;
            radioButton_Female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_Female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_Female.Location = new Point(646, 66);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(86, 23);
            radioButton_Female.TabIndex = 24;
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
            radioButton_Male.Location = new Point(573, 66);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(66, 23);
            radioButton_Male.TabIndex = 23;
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
            label4.Location = new Point(477, 68);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 28;
            label4.Text = "Gender :";
            // 
            // dateTimePicker_dateOfBirth
            // 
            dateTimePicker_dateOfBirth.Anchor = AnchorStyles.None;
            dateTimePicker_dateOfBirth.Location = new Point(131, 64);
            dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            dateTimePicker_dateOfBirth.Size = new Size(293, 27);
            dateTimePicker_dateOfBirth.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(43, 109);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 25;
            label5.Text = "Address : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(11, 68);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 26;
            label3.Text = "Date Of Birth : ";
            // 
            // textBox_Phone
            // 
            textBox_Phone.Anchor = AnchorStyles.None;
            textBox_Phone.Location = new Point(573, 20);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(163, 27);
            textBox_Phone.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(502, 24);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 21;
            label6.Text = "Phone :";
            // 
            // textBox_LName
            // 
            textBox_LName.Anchor = AnchorStyles.None;
            textBox_LName.Location = new Point(372, 20);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(119, 27);
            textBox_LName.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(267, 24);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 20;
            label2.Text = "Last Name :";
            // 
            // textBox_fName
            // 
            textBox_fName.Anchor = AnchorStyles.None;
            textBox_fName.Location = new Point(132, 20);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(123, 27);
            textBox_fName.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 16;
            label1.Text = "First Name : ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 533);
            Controls.Add(panel2);
            Controls.Add(dataGridView_student);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Photo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView_student;
        private Panel panel2;
        private Panel panel3;
        private Button button_Add;
        private Button button_Clear;
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
    }
}