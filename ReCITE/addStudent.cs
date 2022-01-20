using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace ReCITE
{
    public partial class addStudent : Form
    {
        IFirebaseConfig firebase = new FirebaseConfig() 
        {
            AuthSecret = "cf5r8ujKHgNDlXCsRNLJq9aUDKSF4do8gU1kio50",
            BasePath = "https://curriculum-9f921-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        
        IFirebaseClient firebaseClient;
        
        public addStudent()
        {
            InitializeComponent();
            
            try 
            {
                firebaseClient = new FireSharp.FirebaseClient(firebase);
            } catch 
            {
                MessageBox.Show("error");
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //add student function to database
            Database.Database databaseConnection = new Database.Database();
            databaseConnection.AddStudent(studentName_tb.Text, globalClass.classid);
            var firebaseWrite = firebaseClient.Set("classList/Class1/", studentName_tb.Text);
            //Clear textbox
            studentName_tb.Text = "";
        }
    }
}
