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
        public Game()
        {
            InitializeComponent();

            //Initialize Class List
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\miniLeaderboard.html");
            WebLeaderboard_pnl.Source = new Uri(path);

            webGame_pnl.Source = new Uri(globalClass.choosengame);
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

        private void end_btn_Click(object sender, EventArgs e)
        {
            Form leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Hide();
        }

        private void LN_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\LottoGame.html");
            webGame_pnl.Source = new Uri(path);
        }

        private void OOE_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\OddEvenGame.html");
            webGame_pnl.Source = new Uri(path);
        }

        private void DTB_game_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\defuseTheBomb.html");
            webGame_pnl.Source = new Uri(path);
        }
    }
}
