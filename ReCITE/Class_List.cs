using FireSharp.Config;
using FireSharp.Interfaces;
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
        private bool mouseDown;
        private Point lastLocation;

        //Firebase Variables
        readonly IFirebaseConfig firebase = new FirebaseConfig()
        {
            AuthSecret = "cf5r8ujKHgNDlXCsRNLJq9aUDKSF4do8gU1kio50",
            BasePath = "https://curriculum-9f921-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
#pragma warning disable IDE0052 // Remove unread private members
        private readonly IFirebaseClient firebaseClient;
#pragma warning restore IDE0052 // Remove unread private members

        public Class_List()
        {
            InitializeComponent();
          
            class1_btn.Text = Properties.Settings.Default.Class1;
            class2_btn.Text = Properties.Settings.Default.Class2;
            class3_btn.Text = Properties.Settings.Default.Class3;
            class4_btn.Text = Properties.Settings.Default.Class4;

            // Firebase Database
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(firebase);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        // Minimize and Close Button
        #region Toolbar
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        // Back button
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form back = new Home();
            back.Show();
            this.Hide();
        }

        // Select Class Button
        private void Class_btn_click(object sender, EventArgs e)
        {
            Button btnName = (Button)sender;
            var name = btnName.Text;
            var tag = btnName.Tag;

            globalClass.classid = name;
            Properties.Settings.Default.tag = tag.ToString();
            
            // Transfered on StudenList Form; Save for future reference
            //var firebaseWrite = firebaseClient.Set("key/classId", name);

            Form student_list = new Student_List();
            student_list.Show();
            this.Hide();
        }

    }
}
