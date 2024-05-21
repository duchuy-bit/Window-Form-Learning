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
    public partial class ManageStudent : Form
    {

        StudentClass student = new StudentClass();
        public ManageStudent()
        {
            InitializeComponent();
        }



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

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            showtable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView_student.DataSource = student.filterStudentList(textBox_search.Text);
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

        //display student detail when choose student
        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_fName.Text = dataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_LName.Text = dataGridView_student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_dateOfBirth.Value = (DateTime)dataGridView_student.CurrentRow.Cells[3].Value;

            if (dataGridView_student.CurrentRow.Cells[0].ToString() == "Male")
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                radioButton_Female.Checked = true;
            }

            textBox_Address.Text = dataGridView_student.CurrentRow.Cells[6].Value.ToString();
            textBox_Phone.Text = dataGridView_student.CurrentRow.Cells[5].Value.ToString();

            byte[] img = (byte[])dataGridView_student.CurrentRow.Cells[7].Value;
            MemoryStream memoryStream = new MemoryStream(img);
            pictureBox_Photo.Image = Image.FromStream(memoryStream);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_fName.Clear();
            textBox_LName.Clear();
            textBox_Address.Clear();
            textBox_Phone.Clear();
            pictureBox_Photo.Image = null;
            textBox_id.Clear();
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

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_id.Text);
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
                        if (student.updateStudent(id, fname, lname, bdate, phone, gender, address, img))
                        {
                            MessageBox.Show("Student's Information Updated", "Update Student",
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
    }
}
