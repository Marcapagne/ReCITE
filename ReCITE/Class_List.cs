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

        public Class_List()
        {
            InitializeComponent();
            Database.Database databaseConnection = new Database.Database();
            List<string> className = databaseConnection.LoadTableName();

            //label1.Text = sample[0].ToString();

            class1_btn.Text = className[0].ToString();
            class2_btn.Text = className[1].ToString();
            class3_btn.Text = className[2].ToString();
            class4_btn.Text = className[3].ToString();
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

            globalClass.classid = name;
            Form student_list = new Student_List();
            student_list.Show();
            this.Hide();
        }

    }
}
