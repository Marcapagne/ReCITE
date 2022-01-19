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
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\AboutUs.html");
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
