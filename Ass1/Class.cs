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
    public partial class Class : Form
    {
        public string constr = @"Data Source=LAPTOP-KH2JGH1C\chirag;Initial Catalog=adc_100;User ID=sa;Password=sa123";
        public Class()
        {
            InitializeComponent();
            CourseData();
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
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "CourseName";
                    comboBox1.ValueMember = "CourseId";
                }
            }
        }
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                string query = @"SELECT c.ClassId,
                                c.ClassName,
                                co.CourseName
                         FROM Class c
                         INNER JOIN Course1 co
                         ON c.CourseId = co.CourseId";

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "insert into Class values(@ClassName,@CourseId)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClassName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@CourseId", comboBox1.SelectedValue);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record inserted");
                    LoadData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "update Class SET ClassName=@ClassName,CourseId=@CourseId where ClassId=@ClassId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CLassId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ClassName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@CourseId", comboBox1.SelectedValue);
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
                string query = "Delete from class where CLassId=@ClassId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CLassId", textBox1.Text);
                    //cmd.Parameters.AddWithValue("@ClassName", textBox2.Text);
                    //cmd.Parameters.AddWithValue("@CourseId", comboBox1.SelectedValue);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsaffected + "record deleted");
                    LoadData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Classid"].Value.ToString();
                textBox2.Text = row.Cells["ClassName"].Value.ToString();
                comboBox1.Text = row.Cells["CourseId"].Value.ToString();
            }
        }
    }
}
