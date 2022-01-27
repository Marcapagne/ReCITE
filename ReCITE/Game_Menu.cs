using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Game_Menu : Form
    {
        //For Movable Toolbar
        private bool mouseDown;
        private Point lastLocation;
        readonly IFirebaseConfig firebase = new FirebaseConfig()
        {
            AuthSecret = "o2qaPcXL4Ph4BXt6QlYSa50IZmpkqLRd6Xeusrup",
            BasePath = "https://recite-2f22b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        readonly IFirebaseClient firebaseClient;
        #pragma warning disable IDE0052 // Remove unread private members
        private SetResponse firebaseWrite;
        #pragma warning restore IDE0052 // Remove unread private members

        public Game_Menu()
        {
            InitializeComponent();

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

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form back = new Student_List();
            back.Show();
            this.Hide();
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

        // Select Game Buttons
        #region Selct Game Buttons
        private void Gamebtn_Click(object sender, EventArgs e)
        {
            Button btnTag = (Button)sender;
            string tag = btnTag.Tag.ToString();
            string projectDirectory;

            firebaseWrite = firebaseClient.Set("game/type", tag);

            Form game;
            string path;
            switch (tag)
            {
                case "lotto_name":
                    projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(projectDirectory, @"Web_Apps\LottoGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "wheel_of_names":
                    projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(projectDirectory, @"Web_Apps\wheelOfNamesStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "odd_or_even":
                    projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(projectDirectory, @"Web_Apps\OddEvenGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "defuse_the_bomb":
                    projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(projectDirectory, @"Web_Apps\defuseTheBombStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                default:
                    projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(projectDirectory, @"Web_Apps\LottoGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;
            }
        }
        #endregion

    }
}
