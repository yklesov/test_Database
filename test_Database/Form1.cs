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

namespace test_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-I0PGRBS;Initial Catalog=test;Integrated Security=True");
        
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Personnel",con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }        
        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Customer (Customer, Address, Phone_number,Email)VALUES ('" + textBox6.Text + "','" + textBox7.Text + "','" + int.Parse(textBox8.Text) + "','" + textBox9.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindData();
            con.Open();
            SqlCommand command = new SqlCommand("insert into Personnel (CustomerName,FirstName,LastName,Address,City)VALUES ('" + textBox14.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            con.Close();
            
        }
    }
}
