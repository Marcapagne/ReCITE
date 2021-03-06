using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class Game : Form
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
        private FireSharp.Response.SetResponse firebaseWrite;
        #pragma warning restore IDE0052 // Remove unread private members

        public Game()
        {
            InitializeComponent();

            //Initialize Class List
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\classList.html");
            WebLeaderboard_pnl.Source = new Uri(path);

            //Load Selected Game
            webGame_pnl.Source = new Uri(globalClass.choosengame);

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

        // Minimize and Close Button & Movable Toolbar
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

        // Select Game Buttons
        #region Selct Game Buttons

        //Lotto Game
        private void LN_game_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\LottoGameStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = false;
            OOE_game.Enabled = true;
            DTB_game.Enabled = true;
            WON_game.Enabled = true;

            firebaseWrite = firebaseClient.Set("game/type", LN_game.Tag);
            WebLeaderboard_pnl.Reload();
        }

        //Odd or Even Game
        private void OOE_game_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\OddEvenGameStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = false;
            DTB_game.Enabled = true;
            WON_game.Enabled = true;

            firebaseWrite = firebaseClient.Set("game/type", OOE_game.Tag);
            WebLeaderboard_pnl.Reload();
        }

        //Defuse the Bomb Game 
        private void DTB_game_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\defuseTheBombStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = true;
            DTB_game.Enabled = false;
            WON_game.Enabled = true;

            firebaseWrite = firebaseClient.Set("game/type", DTB_game.Tag);
            WebLeaderboard_pnl.Reload();
        }

        //Wheel of Names
        private void WON_game_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(projectDirectory, @"Web_Apps\wheelOfNamesStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = true;
            DTB_game.Enabled = true;
            WON_game.Enabled = false;

            firebaseWrite = firebaseClient.Set("game/type", WON_game.Tag);
            WebLeaderboard_pnl.Reload();
        }

        //Aesthetic 
        private void Hover(object sender, EventArgs e)
        {
            Button btnFontColor = (Button)sender;
            btnFontColor.ForeColor = Color.FromArgb(1, 88, 122);
        }

        private void Btn_Leave(object sender, EventArgs e)
        {
            Button btnFontColor = (Button)sender;
            btnFontColor.ForeColor = Color.White;
        }

        private void LN_game_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled == false)
            {
                btn.ForeColor = Color.Transparent;
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.White;
            }

        }

        // End of Aesthetic 
        #endregion

        //End Button.. Proceed to Overall Leaderboards
        private void End_btn_Click(object sender, EventArgs e)
        {
            Form leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Hide();
        }
    }
}
