using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_Hotspot
{
    public partial class LogIn : Form
    {
        string s="";
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Shivani" && textBox2.Text == "shivani123")
            {
                s="ad";
              
                Form1 ob=new Form1(s);
                ob.Show();
                

             }
            else
                MessageBox.Show("Invalid Username or Password. \n Try again or Login as Guest");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj=new Form1(s);
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
