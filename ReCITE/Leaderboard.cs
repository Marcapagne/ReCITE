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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();

            //Initialize Class List
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path = Path.Combine(directory, @"Web_Apps\Leaderboard.html");
            webLeaderboard_pnl.Source = new Uri(path);
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

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            Form studentList = new Student_List();
            studentList.Show();
            this.Hide();
        }
    }
}
