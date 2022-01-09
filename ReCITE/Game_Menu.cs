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
        public Game_Menu()
        {
            InitializeComponent();
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

        private void gamebtn_Click(object sender, EventArgs e)
        {
            Button btnTag = (Button)sender;
            var tag = btnTag.Tag;

            if (tag == "Lotto")
            {
                string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                string path = Path.Combine(directory, @"Web_Apps\LottoGame.html");
                globalClass.choosengame = path;

                Form game = new Game();
                game.Show();
                this.Hide();
            }

            if (tag == "Wheel of Names")
            {
                string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                string path = Path.Combine(directory, @"Web_Apps\LottoGame.html");
                globalClass.choosengame = path;

                Form game = new Game();
                game.Show();
                this.Hide();
            }

            if (tag == "Odd or Even")
            {
                string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                string path = Path.Combine(directory, @"Web_Apps\OddEvenGame.html");
                globalClass.choosengame = path;

                Form game = new Game();
                game.Show();
                this.Hide();
            }

            if (tag == "Defuse the bomb")
            {
                string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
                string path = Path.Combine(directory, @"Web_Apps\defuseTheBomb.html");
                globalClass.choosengame = path;

                Form game = new Game();
                game.Show();
                this.Hide();
            }
        }
    }
}
