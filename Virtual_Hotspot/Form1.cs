using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;

namespace Virtual_Hotspot
{
    public partial class Form1 : Form
    {
        string a;
        short hours, mins, secs;
        Process newprocess = new Process();
        public Form1(string s)
        {
            a = s;
            newprocess.StartInfo.UseShellExecute = false;
            newprocess.StartInfo.CreateNoWindow=true;
            newprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            InitializeComponent();
        }
        public bool isUserAdmin()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity User = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(User);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public void process_Start1()
        {
            process_ProgressB1.Increment(25);
            newprocess.StartInfo.FileName="netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                using (Process Execute = Process.Start(newprocess.StartInfo))
                {
                    Execute.WaitForExit();
                    process_ProgressB1.Increment(25);
                    process_Start2();
                }
            }
            catch
            {
            }
        }
        public void process_Start2()
        {
            newprocess.StartInfo.FileName="netsh";
            newprocess.StartInfo.Arguments = "wlan set hostednetwork mode=allow ssid="+SSID_tb1.Text+" key="+Pass_tb2.Text;
            try
            {
                using (Process Execute = Process.Start(newprocess.StartInfo))
                {
                    Execute.WaitForExit();
                    process_ProgressB1.Increment(25);
                    process_Start3();
                }
            }
            catch
            {
            }
        }
        public void process_Start3()
        {
            timer1.Enabled = true;
            hours=0;
            mins=0;
            secs=0;
            showTime();
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan start hostednetwork";
            try
            {
                using (Process Execute = Process.Start(newprocess.StartInfo))
                {
                    Execute.WaitForExit();
                    process_ProgressB1.Increment(25);
                    panel1.Visible = true;
                    Play_Stop_b1.Text = "Stop";
                    SSID_tb1.Enabled = false;
                    Pass_tb2.Enabled = false;

                }
            }
            catch
            {
            }
        }
        private void showTime()
        {
            hours_lbl1.Text = hours.ToString("00");
            mins_lbl2.Text = mins.ToString("00");
            secs_lbl3.Text = secs.ToString("00");


        }
        public void process_Stop()
        {
            timer1.Enabled = false;
            newprocess.StartInfo.FileName = "netsh";
            newprocess.StartInfo.Arguments = "wlan stop hostednetwork";
            try
            {
                process_ProgressB1.Increment(50);
                using (Process Execute = Process.Start(newprocess.StartInfo))
                {
                    Execute.WaitForExit();
                    process_ProgressB1.Increment(50);
                    panel1.Visible = true;
                    Play_Stop_b1.Text = "Start";
                    SSID_tb1.Enabled = true;
                    Pass_tb2.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void Play_Stop_b1_Click(object sender, EventArgs e)
        {
           
            if (Play_Stop_b1.Text == "Start")
            {
                if (SSID_tb1.TextLength < 1)
                {
                    MessageBox.Show("The name should be of more than 1 letter","SSID Error");
                }
                else if (Pass_tb2.TextLength < 8)
                {
                    MessageBox.Show("The name must be atleast 8 letters", "Password Error");
                }
                else
                {
                    panel1.Visible = false;
                    process_Start1();
                }
            }
            else
            {
                panel1.Visible = false;
                process_Stop();
            }

        }
        private void IncreaseSecs()
        {
            if (secs == 59)
            {
                secs = 0;
                IncreaseMins();
            }
            else
                secs++;
        }

        private void IncreaseMins()
        {
            if (mins == 59)
            {
                mins = 0;
                IncreaseHours();

            }
            else
                mins++;
        }
        private void IncreaseHours()
        {
            hours++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IncreaseSecs();
            showTime();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\Users\USER\Documents\Visual Studio 2010\Projects\Virtual_Hotspot\Virtual_Hotspot\Help.txt"); 
        }

        private void Pass_tb2_TextChanged(object sender, EventArgs e)
        {
            this.Pass_tb2.PasswordChar = '•';
            if (a == "ad")
            {
                checkBox1.Visible = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                Pass_tb2.PasswordChar = '\0';
            else if (checkBox1.Checked == false)
                this.Pass_tb2.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
