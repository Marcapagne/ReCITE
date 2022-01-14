﻿using System;
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

            //string[] classname = new string[] { databaseConnection.LoadTableName().ToArray() };


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

        //Back button
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
