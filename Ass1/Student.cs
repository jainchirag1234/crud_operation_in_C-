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
namespace Ass1
{
    public partial class Student : Form
    {
        public string constr = @"Data Source=LAPTOP-KH2JGH1C\chirag;Initial Catalog=adc_100;User ID=sa;Password=sa123";
        public Student()
        {
            InitializeComponent();
            CourseData();
            ClassData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "insert into student values(@rollno,@name,@course,@class,@email,@mobile,@dob)";
                using (SqlCommand cmd = new SqlCommand(query, con))
               
                {
                    //cmd.Parameters.AddWithValue("@enrollno", textBox1.Text);
                    cmd.Parameters.AddWithValue("@rollno", textBox2.Text);
                    cmd.Parameters.AddWithValue("@name", textBox3.Text);
                    cmd.Parameters.AddWithValue("@class", comboBoxClass.SelectedValue);
                    cmd.Parameters.AddWithValue("@course", comboBoxCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@mobile", textBox5.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record inserted");
                    LoadData();
                }
            }
        }
        public void CourseData()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "SELECT * FROM Course1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    comboBoxCourse.DataSource = dt;
                    comboBoxCourse.DisplayMember = "CourseName";
                    comboBoxCourse.ValueMember = "CourseId";
                }
            }
        }
       public void ClassData()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "SELECT * FROM Class";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    comboBoxClass.DataSource = dt;
                    comboBoxClass.DisplayMember = "ClassName";
                    comboBoxClass.ValueMember = "ClassId";
                }
            }
        }
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                string query = @"
            SELECT 
                s.enrollment_no,
                s.rollno,
                s.name,
                cl.ClassName,
                c.CourseName,
                s.email,
                s.mobile,
                s.dob
            FROM Student s
            INNER JOIN [Class] cl ON s.[class] = cl.ClassId
            INNER JOIN Course1 c ON s.[course] = c.CourseId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["enrollment_no"].Value.ToString();
                textBox2.Text = row.Cells["roll_no"].Value.ToString();
                textBox3.Text = row.Cells["Name"].Value.ToString();
                comboBoxClass.Text = row.Cells["class"].Value.ToString();
                comboBoxCourse.Text = row.Cells["course"].Value.ToString();
                textBox4.Text = row.Cells["email"].Value.ToString();
                textBox5.Text = row.Cells["mobile"].Value.ToString();
                dateTimePicker1.Text = row.Cells["date"].Value.ToString();

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "update Student SET rollno=@rollno,course=@course,class=@class,email=@email,mobile=@mobile,dob=@dob where enrollment_no=@enrollment_no";
                using (SqlCommand cmd = new SqlCommand(query, con))

                {
                    cmd.Parameters.AddWithValue("@enrollment_no", textBox1.Text);
                    cmd.Parameters.AddWithValue("@rollno", textBox2.Text);
                    cmd.Parameters.AddWithValue("@class", comboBoxCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@course", comboBoxClass.SelectedValue);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@mobile", textBox4.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record updated");
                    LoadData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "delete from Student where enrollment_no=@enrollment_no";
                using (SqlCommand cmd = new SqlCommand(query, con))

                {
                    cmd.Parameters.AddWithValue("@enrollment_no", textBox1.Text);
                  
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record updated");
                    LoadData();
                }
            }
        }
    }
    }

