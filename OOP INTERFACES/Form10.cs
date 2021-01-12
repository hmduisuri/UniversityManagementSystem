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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");

        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into dbo.Catalog values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("ASSIGNED SUCCESSFULLY");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Select();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR WHILE ASSIGNING COURSES");
                }
                finally
                {
                    con.Close();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {      {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update dbo.Catalog SET Semester = '"+ textBox2.Text +"', Subject = '"+ textBox3.Text +"' WHERE Course_Name = '"+ textBox1.Text +"'  ";
                cmd.ExecuteNonQuery();


                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Select();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR WHILE UPDATING");

            }

            finally
            {
                con.Close();

            }

        }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from dbo.Catalog WHERE Course_Name='" + textBox1.Text + "'";
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}