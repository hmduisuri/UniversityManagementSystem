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
    public partial class Form11 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AlthafAli;Initial Catalog=STAFFORD UNIVERSITY;Integrated Security=True");

        public Form11()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALL RECORDS SAVED SUCCESSFULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into dbo.Billing values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("PLEASE CLICK ON SAVE, TO INSERT THE RECORDS");  //just modification

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Select();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR WHILE INSERTING");
                }
                finally
                {
                    con.Close();

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }
    }
}
