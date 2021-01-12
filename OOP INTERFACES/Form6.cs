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
using MySql.Data.MySqlClient;

namespace OOP_INTERFACES
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //try 
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "insert into dbo.student values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "', '" + textBox11.Text + "', '" + textBox12.Text + "')";
            //    cmd.ExecuteNonQuery();

            //    MessageBox.Show("RECORDS INSERTED SUCCESSFULLY");

            //    textBox1.Clear();
            //    textBox2.Clear();
            //    textBox3.Clear();
            //    textBox4.Clear();
            //    textBox5.Clear();
            //    textBox6.Clear();
            //    textBox7.Clear();
            //    textBox8.Clear();
            //    textBox9.Clear();
            //    textBox10.Clear();
            //    textBox11.Clear();
            //    textBox12.Clear();

            //}
            //    catch (Exception ex)
            //{
            //        MessageBox.Show("ERROR WHILE INSERTING RECORDS");
            //}

            //    finally
            //{
            //    con.Close();
            //}

            //try
            //{
            //    //This is my connection string i have assigned the database file address path  
            //    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            //    //This is my insert query in which i am taking input from the user through windows forms  
            //    string Query = "insert into staf_uni.student(idStudent,Name,Father_Name,Age,Semester) values('" + this.IdTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.FnameTextBox.Text + "','" + this.AgeTextBox.Text + "','" + this.SemesterTextBox.Text + "');";
            //    //This is  MySqlConnection here i have created the object and pass my connection string.  
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    //This is command class which will handle the query and connection object.  
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            //    MessageBox.Show("Save Data");
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
