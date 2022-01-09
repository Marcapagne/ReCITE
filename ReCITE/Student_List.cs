using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
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

            //Initialize Class List
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\classList.html");
            webStudentList_pnl.Source = new Uri(path);
        }

        // Minimize and Close Button
        #region Toolbar
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // Button Function to new forms...
        #region Buttons
        private void start_btn_Click(object sender, EventArgs e)
        {
            Form gameMenu = new Game_Menu();
            gameMenu.Show();
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Form addStudent = new addStudent();
            addStudent.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form class_list = new Class_List();
            class_list.Show();
            this.Hide();
        }

        // Editing Class Name 
        private void edit_btn_Click(object sender, EventArgs e)
        {
            className_tb.Enabled = true;
            className_tb.Focus();
            className_tb.BackColor = Color.White;
            edit_btn.Hide();
            check_btn.Show();
        }
        #endregion

        // Updating Class Name
        private void check_btn_Click(object sender, EventArgs e)
        {
            className_tb.Enabled = false;
            //className_tb.Focus();
            className_tb.BackColor = default;
            check_btn.Hide();
            edit_btn.Show();
        }
    }
}
