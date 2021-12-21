using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReCITE
{
    public partial class Class_List : Form
    {
        public Class_List()
        {
            InitializeComponent();
        }

        // Minimize and Close Button
        #region Toolbar
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Back button
        private void back_btn_Click(object sender, EventArgs e)
        {
            Form back = new Home();
            back.Show();
            this.Hide();
        }

        // Select Class Button
        private void class_btn_click(object sender, EventArgs e)
        {
            Button btnName = (Button)sender;
            var name = btnName.Text;

            globalClass.classid = name;
            Form student_list = new Student_List();
            student_list.Show();
            this.Hide();
        }

        
    }
}
