using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_INTERFACES
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            {
                this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
                this.Update();
                InitializeComponent();
                Form1 frm = new Form1();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                timer1.Start();
                this.Close();
            }
        }
    }
}
