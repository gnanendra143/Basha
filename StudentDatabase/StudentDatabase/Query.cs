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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
                conn.Open();
                string s1 = "SELECT * FROM student WHERE courseName='"+comboBox1.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(s1, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
               // table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                da.Fill(table);
                dataGridView1.DataSource = table;
                //dataGridView1.ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
                conn.Open();
                string s1 = "SELECT * FROM student WHERE joiningYear="+comboBox2.Text;
                SqlDataAdapter da = new SqlDataAdapter(s1, conn);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataTable table = new DataTable();
                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                da.Fill(table);
                dataGridView1.DataSource = table;
                //dataGridView1.ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Query_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\gnane\Documents\Visual Studio 2013\Projects\StudentDatabase\StudentDatabase\StudentDatabase.mdf';Integrated Security=True");
                string str1 = "SELECT courseName FROM course";
                string str2 = "SELECT distinct joiningYear FROM student";
                conn.Open();
                SqlCommand cmdSql1 = new SqlCommand(str1, conn);
                SqlCommand cmdSql2 = new SqlCommand(str2, conn);
                SqlDataReader rs1;
                rs1 = cmdSql1.ExecuteReader();
                while (rs1.Read())
                {
                    comboBox1.Items.Add(rs1[0]);
                    comboBox1.SelectedItem = rs1[0];
                }
                rs1.Close();

                SqlDataReader rs2;
                rs2 = cmdSql2.ExecuteReader();
                while (rs2.Read())
                {
                    comboBox2.Items.Add(rs2[0]);
                    comboBox2.SelectedItem = rs2[0];
                }
                rs2.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
