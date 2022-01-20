using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace ReCITE
{
    public partial class Leaderboard : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        
        IFirebaseConfig firebase = new FirebaseConfig() 
        {
            AuthSecret = "cf5r8ujKHgNDlXCsRNLJq9aUDKSF4do8gU1kio50",
            BasePath = "https://curriculum-9f921-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        
        IFirebaseClient firebaseClient;
        
        public Leaderboard()
        {
            InitializeComponent();
            
            try 
            {
                firebaseClient = new FireSharp.FirebaseClient(firebase);
            } catch 
            {
                MessageBox.Show("error");
            }
            
            
            // globalClass global = new globalClass();
            className_tb.Text = globalClass.classid;

            //Initialize Class List
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\Leaderboard.html");
            webLeaderboard_pnl.Source = new Uri(path);
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

        private void Proceed_btn_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = firebaseClient.Delete("daily/BTVTEd/");

            Form studentList = new Student_List();
            studentList.Show();
            this.Hide();
        }
    }
}
