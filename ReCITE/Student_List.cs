using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

        // Firebase Variables
        readonly IFirebaseConfig firebase = new FirebaseConfig()
        {
            AuthSecret = "o2qaPcXL4Ph4BXt6QlYSa50IZmpkqLRd6Xeusrup",
            BasePath = "https://recite-2f22b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        readonly IFirebaseClient firebaseClient;
        #pragma warning disable IDE0052 // Remove unread private members
        private readonly SetResponse firebaseWrite;
        #pragma warning restore IDE0052 // Remove unread private members

        public Student_List()
        {
            InitializeComponent();
            className_tb.Text = globalClass.classid;

            //Initialize Class List
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\classList.html");
            webStudentList_pnl.Source = new Uri(path);

            // Firebase Database
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(firebase);
            }
            catch
            {
                MessageBox.Show("error");
            }

            firebaseWrite = firebaseClient.Set("key/classId", globalClass.classid);
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

                    globalClass.classid = className_tb.Text;
                    var tag = Properties.Settings.Default.tag;

                    switch (tag)
                    {
                        case "Class1":
                            Properties.Settings.Default.Class1 = className_tb.Text;
                            break;

                        case "Class2":
                            Properties.Settings.Default.Class2 = className_tb.Text;
                            break;

                        case "Class3":
                            Properties.Settings.Default.Class3 = className_tb.Text;
                            break;

                        case "Class4":
                            Properties.Settings.Default.Class4 = className_tb.Text;
                            break;

                        default:
                            Properties.Settings.Default.Class1 = className_tb.Text;
                            break;
                    }

                    className_tb.BackColor = Color.White;
                    className_tb.ForeColor = Color.FromArgb(1, 88, 122);
                    className_tb.ReadOnly = true;
                    check_btn.Hide();
                    edit_btn.Show();

                    Form reload = new Student_List();
                    reload.Show();
                    this.Hide();

                    Properties.Settings.Default.Save();
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
