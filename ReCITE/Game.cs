using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReCITE
{
    public partial class Game : Form
    {
        public Game()
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

        private void end_btn_Click(object sender, EventArgs e)
        {
            Form leaderboard = new Leaderboard();
            leaderboard.Show();
            this.Hide();
        }
    }
}
