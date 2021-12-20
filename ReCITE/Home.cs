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

    }
}
