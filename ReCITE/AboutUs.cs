using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ReCITE
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();

            //Initialize Instruction
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\AboutUs.html");
            webView_AboutUs.Source = new Uri(path);
        }




        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form back = new Home();
            back.Show();
            this.Hide();
        }
    }
}
