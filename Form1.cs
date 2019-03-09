using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringemail = textBox1.Text;

            int result = stringemail.IndexOf("@");

            if (result == -1)
            {
                MessageBox.Show("Invalid Email Address!");
            }

            else
            {
                MessageBox.Show("Email address valid");
                MessageBox.Show("@ found at position " + result.ToString());
            }
            
            }
    }
}
