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
    public partial class Course : Form
    {
        public string constr = @"Data Source=LAPTOP-KH2JGH1C\chirag;Initial Catalog=adc_100;User ID=sa;Password=sa123";
        public Course()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "select * from Course1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }


            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ClassId"].Value.ToString();
                textBox2.Text = row.Cells["ClassName"].Value.ToString();

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "insert into Course1 values(@CourseName)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseName", textBox2.Text);
                    int rowsaffected=cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected+"record inserted");
                    LoadData();

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "update Course1 SET CourseName=@CourseName Where CourseId=@CourseId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CourseName", textBox2.Text);
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
                string query = "delete from Course1 where CourseId=@CourseId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CourseId", textBox1.Text);
                    //cmd.Parameters.AddWithValue("@CourseName", textBox2.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record deleted");
                    LoadData();

                }
            }

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {
             
        }
    }
}
