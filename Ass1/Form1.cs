using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class class1= new Class();
            class1.MdiParent = this;
            class1.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.MdiParent = this;
            course.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student class1 = new Student();
            class1.MdiParent = this;
            class1.Show();
        }
    }
}
