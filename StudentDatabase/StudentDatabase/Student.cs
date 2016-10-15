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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
            conn.Open();
            string s2 = "INSERT INTO student(studentUsn, studentName, joiningYear, courseName) VALUES(@studUsn, @studName, @yoj, @course)";
            SqlCommand cmdSql2 = new SqlCommand(s2, conn);
            cmdSql2.Parameters.AddWithValue("@studUsn", studUsn.Text);
            cmdSql2.Parameters.AddWithValue("@studName", studName.Text);
            cmdSql2.Parameters.AddWithValue("@yoj", yoj.Text);
            cmdSql2.Parameters.AddWithValue("@course", courseName.Text);
            cmdSql2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("INSERTED SUCCESFULLY");
          }
          catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Home c = new Home();
            c.Show();
            Hide();

        }

        private void Student_Load(object sender, EventArgs e)
        {
          try {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
            conn.Open();
            string s1 = "SELECT * FROM course";
            SqlCommand cmdSql1 = new SqlCommand(s1, conn);
            SqlDataReader rs; 
              rs = cmdSql1.ExecuteReader();
            while (rs.Read())
            {
                courseName.Items.Add(rs[1].ToString());
                courseName.SelectedItem = rs[1].ToString();
            }
            
            rs.Close();
            conn.Close();
          }
          catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
