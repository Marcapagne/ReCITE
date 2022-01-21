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
        private bool mouseDown;
        private Point lastLocation;

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

        // Remove Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparams = base.CreateParams;
                handleparams.ExStyle |= 0x02000000;
                return handleparams;
            }
        }

        // Minimize and Close Button
        #region Toolbar
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Movable Toolbar -------------------------- 
        private void Toolbar_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Toolbar_pnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Toolbar_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //--------------------------------------------------
        #endregion

        // Button Function to new forms...
        #region Buttons
        private void Start_btn_Click(object sender, EventArgs e)
        {
            Form gameMenu = new Game_Menu();
            gameMenu.Show();
            this.Hide();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Form addStudent = new addStudent();
            addStudent.ShowDialog();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form class_list = new Class_List();
            class_list.Show();
            this.Hide();
        }

        // Editing Class Name 
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            className_tb.ReadOnly = false;
            className_tb.Focus();
            className_tb.BackColor = Color.White;
            className_tb.ForeColor = Color.FromArgb(1, 88, 122);
            edit_btn.Hide();
            check_btn.Show();
        }
        #endregion

        // Updating Class Name
        private void Check_btn_Click(object sender, EventArgs e)
        {
            string message = "You're about to change the name of section. This will delete \"ALL\" the current data on table. Click \"YES\" if you understand and \"NO\" to abort the changes.";
            DialogResult dialogResult = MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (className_tb.Text.IndexOf(' ') >= 0 || className_tb.Text.IndexOf('-') >= 0)
                {
                    MessageBox.Show("Invalid character detected.\n Use \"_\" to instead if there is a space.");
                }
                else
                {
                    className_tb.BackColor = Color.White;
                    className_tb.ForeColor = Color.FromArgb(1, 88, 122);
                    className_tb.ReadOnly = true;
                    check_btn.Hide();
                    edit_btn.Show();

                    Database.Database databaseConnection = new Database.Database();
                    databaseConnection.UpdateTables(globalClass.classid.ToString(), className_tb.Text.ToString());

                    globalClass.classid = className_tb.Text;
                    webStudentList_pnl.Reload();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                className_tb.BackColor = Color.White;
                className_tb.ForeColor = Color.FromArgb(1, 88, 122);
                className_tb.ReadOnly = true;
                check_btn.Hide();
                edit_btn.Show();
                
                className_tb.Text = globalClass.classid;
            }
        }
    }
}
