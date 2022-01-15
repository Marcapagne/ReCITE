using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReCITE
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //add student function to database
            Database.Database databaseConnection = new Database.Database();
            databaseConnection.AddStudent(studentName_tb.Text, globalClass.classid);

            //Clear textbox
            studentName_tb.Text = "";
        }
    }
}
