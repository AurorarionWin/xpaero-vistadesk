using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Drawing2D;


namespace desk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "desk.cpl,,2");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "desk.cpl,,@themes");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("control", "desk.cpl,,@themes");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "desk.cpl,,@desktop");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("control", "desk.cpl,,@desktop");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("control", "desk.cpl,,2");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "desk.cpl,,1");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("control", "desk.cpl,,1");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start("control", "main.cpl,,1");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "main.cpl,,1");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("control", "mmsys.cpl,,1");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "mmsys.cpl,,1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("control", "desk.cpl,,3");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "desk.cpl,,3");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "cttune.cpl");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("accwiz");
        }

        private void linkLabel8_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("rundll32.exe", "shell32.dll,Options_RunDLL 1");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("control", "access.cpl");
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("rundll32.exe", "shell32.dll,Options_RunDLL");
        }

    }
}

