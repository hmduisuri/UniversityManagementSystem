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

namespace OOP_INTERFACES
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                string query = string.Empty;
                if (comboBox1.Text.Trim().Length > 0)
                {
                    try
                    {
                        query = "SELECT Duration FROM dbo.Course WHERE Course_Name='" + comboBox1.Text + "'";
                        SqlCommand cd = new SqlCommand(query, con);
                        SqlDataReader reader = cd.ExecuteReader();



                        while (reader.Read())
                        {
                            textBox2.Text = reader["Duration"].ToString();
                        }

                        reader.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR WHILE SEARCHING THE RECORDS");
                    }

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

