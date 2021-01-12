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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");

        public Form9()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into dbo.Lecturer values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete dbo.Lecturer WHERE Lecturer_ID= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORDS DELETED SUCCESSFULLY");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Select();

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update dbo.Lecturer SET Lecturer_Name= '" + textBox2.Text + "', Contact_No.= '"+ textBox3.Text +"'  WHERE Course_ID='"+textBox1.Text+"'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Select();


            }
            catch 
            {
                MessageBox.Show("ERROR WHILE UPDATING RECORDS");
            }

            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }
    }
}

