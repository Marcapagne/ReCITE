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
        public Home()
        {
            InitializeComponent();

            Database.Database databaseConnection = new Database.Database();

            List<List<string>> StudentRecords = new List<List<string>>();
            StudentRecords = databaseConnection.getStudents("Class1"); // STUDENT LIST AND SCORE
        }

        #region Toolbar
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form class_list = new Class_List();
            class_list.Show();
            this.Hide();
            //this.Dispose();
        }



    }
}
