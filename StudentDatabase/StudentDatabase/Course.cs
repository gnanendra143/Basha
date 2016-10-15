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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
            conn.Open();
           SqlCommand cmdSql = new SqlCommand("INSERT INTO course(courseName) VALUES(@courseName)", conn);
            cmdSql.Parameters.AddWithValue("@courseName", textBox1.Text);
            cmdSql.ExecuteNonQuery();         
            MessageBox.Show("INSERTED SUCCESFULLY");
            conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }
    }
}
