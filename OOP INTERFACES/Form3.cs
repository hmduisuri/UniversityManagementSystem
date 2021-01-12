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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");


        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = string.Empty;
            if (textBox1.Text.Trim().Length > 0)
            {
                try
                {
                    query = "SELECT First_Name,Course FROM dbo.student WHERE Student_ID='" + textBox1.Text + "'";


                    SqlCommand cd = new SqlCommand(query, con);
                    SqlDataReader reader = cd.ExecuteReader();



                    while (reader.Read())
                    {
                        textBox2.Text = reader["First_Name"].ToString();
                        textBox3.Text = reader["Course"].ToString();

                    }

                    reader.Close();
                    con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error While Searching");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
                {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update dbo.student SET Course = '" + "' WHERE Student_ID= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORDS DELETED SUCCESSFULLY");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();

                }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR WHILE DELETING RECORDS");
            }

            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update dbo.student SET Course = '" + textBox3.Text + "'  WHERE Student_ID= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORDS INSERTED SUCCESSFULLY");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Select();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR WHILE INSERTING RECORDS");
            }

            finally
            {
                con.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
