using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReCITE
{
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
           // globalClass global = new globalClass();
           className_tb.Text = globalClass.classid;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form game = new Game();
            game.Show();
            this.Hide();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            className_tb.Enabled = true;
            className_tb.Focus();
            className_tb.BackColor = Color.White;
        }
    }
}
