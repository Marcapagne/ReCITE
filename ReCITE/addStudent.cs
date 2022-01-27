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
            AuthSecret = "o2qaPcXL4Ph4BXt6QlYSa50IZmpkqLRd6Xeusrup",
            BasePath = "https://recite-2f22b-default-rtdb.asia-southeast1.firebasedatabase.app/"
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
            StudentClass student = new StudentClass() { name = studentName_tb.Text, score = 0 };
            var firebaseWrite = firebaseClient.Set("classList/"+ globalClass.classid +"/" + studentName_tb.Text, student);
            
            //Clear textbox
            studentName_tb.Text = "";
        }
    }
}
