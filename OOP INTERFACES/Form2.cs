using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OOP_INTERFACES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlConnection connection = db.getMyConnection();


            string connectionString = @"Server=localhost;Database=staf_uni;Uid=root;Pwd=root;";

            string query = "SELECT Student_ID FROM stundent WHERE Username = 'sahan'";

            MySqlConnection connect = new MySqlConnection(connectionString);


            MySqlCommand cmd = new MySqlCommand(query, connect);



            if ((cmbUserType.Text == "Student"))
            {

                //string query = "SELECT Count(*) FROM student where Username = @username";
                ////Create Mysql Command
                //MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add(new MySqlParameter("@username", txbUserName.Text));
                int count = 0;

                try
                {
                    //ExecuteScalar will return one value
                    if (cmd.ExecuteScalar() != null)
                    {
                        count = int.Parse(cmd.ExecuteScalar() + "");
                    }

                    //close Connection
                    db.CloseConnection();

                    if (count > 0)
                    {
                        Form3 frm = new Form3();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD! PLEASE CHECK AND RE-ENTER");
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Exception caught: {0}", e1);
                    MessageBox.Show("INVALID USERNAME OR PASSWORD! PLEASE CHECK AND RE-ENTER");
                }






            }

            else if ((cmbUserType.Text == "Lecturer") && (txbPassword.Text == "lecturer@1234"))
            {
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }

            else if ((cmbUserType.Text == "Registrar") && (txbPassword.Text == "registrar@1234"))
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Hide();
            }

            else
                MessageBox.Show("INVALID USERNAME OR PASSWORD! PLEASE CHECK AND RE-ENTER");
            
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLEASE CONTACT SYSTEM ADMINISTRATOR TO RESET YOUR PASSWORD, +94 7777 212 68");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

