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

namespace StudentDatabase
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.Show();
            Hide();
        }
    }
}
