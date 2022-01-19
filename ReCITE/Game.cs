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

        public Game()
        {
            InitializeComponent();

            //Initialize Class List
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\miniLeaderboard.html");
            WebLeaderboard_pnl.Source = new Uri(path);

            //Load Selected Game
            webGame_pnl.Source = new Uri(globalClass.choosengame);

            addPoint_btn.Visible = false;
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
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\LottoGameStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = false;
            OOE_game.Enabled = true;
            DTB_game.Enabled = true;
            WON_game.Enabled = true;
        }

        //Odd or Even Game
        private void OOE_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\OddEvenGameStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = false;
            DTB_game.Enabled = true;
            WON_game.Enabled = true;
        }

        //Defuse the Bomb Game 
        private void DTB_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\defuseTheBombStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = true;
            DTB_game.Enabled = false;
            WON_game.Enabled = true;
        }

        //Wheel of Names
        private void WON_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\wheelOfNamesStart.html");
            webGame_pnl.Source = new Uri(path);

            LN_game.Enabled = true;
            OOE_game.Enabled = true;
            DTB_game.Enabled = true;
            WON_game.Enabled = false;
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

        //Web App Panel
        private void WebGame_pnl_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            var lotto = new Uri (Path.Combine(directory, @"Web_Apps\LottoGame.html"));
            var oddeven = new Uri(Path.Combine(directory, @"Web_Apps\OddEvenGame.html"));
            var bomb = new Uri(Path.Combine(directory, @"Web_Apps\defuseTheBomb.html"));
            var wheelofNames = new Uri(Path.Combine(directory, @"Web_Apps\wheelOfNames.html"));

            if (webGame_pnl.Source == lotto || webGame_pnl.Source == oddeven || webGame_pnl.Source == bomb || webGame_pnl.Source == wheelofNames)
            {
                addPoint_btn.Visible = true;
            } else
                addPoint_btn.Visible = false;

        }
    }
}
