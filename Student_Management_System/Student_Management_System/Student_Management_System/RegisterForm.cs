using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class RegisterForm : Form
    {

        StudentClass student = new StudentClass();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_Upload_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Photo(*.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Photo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //add new student
            string fname = textBox_fName.Text;
            string lname = textBox_LName.Text;
            string address = textBox_Address.Text;
            string phone = textBox_Phone.Text;
            DateTime bdate = dateTimePicker_dateOfBirth.Value;
            string gender = radioButton_Male.Checked ? "Male" : "Female";



            //check student age between 10 and 100
            int born_year = dateTimePicker_dateOfBirth.Value.Year;
            int now_year = DateTime.Now.Year;

            if (now_year - born_year >= 10 && now_year - born_year <= 100)
            {
                if (verify())
                {
                    //get photo from picture box
                    MemoryStream memoryStream = new MemoryStream();
                    pictureBox_Photo.Image.Save(memoryStream, pictureBox_Photo.Image.RawFormat);
                    byte[] img = memoryStream.ToArray();

                    try
                    {
                        if (student.insertStudent(fname, lname, bdate, phone, gender, address, img))
                        {
                            MessageBox.Show("New Student Added", "Add Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showtable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter all Student Infomation", "Warning",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birth Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //create a function to verify
        bool verify()
        {
            if (textBox_fName.Text == "" || textBox_LName.Text == "" ||
                textBox_Address.Text == "" || textBox_Phone.Text == "" ||
                pictureBox_Photo.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //show student list
        public void showtable()
        {
            dataGridView_student.DataSource = student.getStudentList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


            this.dataGridView_student.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridView_student.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridView_student.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridView_student.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridView_student.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridView_student.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dataGridView_student.RowTemplate.Resizable = DataGridViewTriState.True;
            this.dataGridView_student.RowTemplate.Height = 80;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showtable();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_fName.Clear();
            textBox_LName.Clear();
            textBox_Address.Clear();
            textBox_Phone.Clear();
            pictureBox_Photo.Image = null;
        }
    }
}
