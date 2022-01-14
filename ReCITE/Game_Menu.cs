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

        public Game_Menu()
        {
            InitializeComponent();
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

        // Select Game Buttons
        #region Selct Game Buttons
        private void Gamebtn_Click(object sender, EventArgs e)
        {
            Button btnTag = (Button)sender;
            string tag = btnTag.Tag.ToString();
            string directory;
            
            Form game;
            string path;
            switch (tag)
            {
                case "Lotto":
                    directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                    path = Path.Combine(directory, @"Web_Apps\LottoGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "Wheel of Names":
                    directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                    path = Path.Combine(directory, @"Web_Apps\LottoGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "Odd or Even":
                    directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                    path = Path.Combine(directory, @"Web_Apps\OddEvenGameStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                case "Defuse the bomb":
                    directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                    path = Path.Combine(directory, @"Web_Apps\defuseTheBombStart.html");
                    globalClass.choosengame = path;
                    game = new Game();
                    game.Show();
                    this.Hide();
                    break;

                default:
                    directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                    path = Path.Combine(directory, @"Web_Apps\LottoGameStart.html");
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
