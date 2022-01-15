using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCITE
{

    public partial class Home : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Home()
        {
            InitializeComponent();

           // Database.Database databaseConnection = new Database.Database();
            //databaseConnection.CreateTables();

            //List<List<string>> StudentRecords = new List<List<string>>();
            //StudentRecords = databaseConnection.getStudents("Class1"); // STUDENT LIST AND SCORE
        }

        // Minimize and Close Button & Movable Toolbar
        #region Toolbar
        //Close Button
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize Button
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Movable Toolbar
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

        #endregion

        // Button Function to new forms...
        #region Buttons
        private void Start_btn_Click(object sender, EventArgs e)
        {
            Form class_list = new Class_List();
            class_list.Show();
            this.Hide();
            //this.Dispose();
        }

        private void Instruction_btn_Click(object sender, EventArgs e)
        {
            Form instruction = new Instruction();
            instruction.Show();
            this.Hide();
        }
        #endregion

    }
}
