using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class MyFirstForm : Form  // /////////// MyFirstForm inheritates from Form class
    {

        public string Username = "Alan";    // fields
        public string Password = "Pass";    // fields

        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // load event action
        {
            Console.WriteLine("Form Load");
        }

        private void BtnClose_Click(object sender, EventArgs e) // [ Close ]  button action
        {
            //TxtUser.Text = "";
            //TxtPass.Clear();
            //Close();              // close this one form
            Application.Exit();     // close all application
        }

        private void BtnGo_Click(object sender, EventArgs e)    // [ Go ]  button action
        {
            if(TxtUser.TextLength > 0 && TxtUser.TextLength > 0)
            {
                string inputUser = TxtUser.Text;    // variable
                string inputPass = TxtPass.Text;    // variable

                if (inputUser == Username && inputPass == Password)
                {
                    LabResult.ForeColor = Color.Green;
                    LabResult.Text = "Login Successfull!";
                    loginScreen();
                }
                else
                {
                    LabResult.ForeColor = Color.Red;
                    LabResult.Text = $"Wrong Username or Password!\nTry Again!";
  
                }
            }
            else
            {
                LabResult.ForeColor = Color.Red;
                LabResult.Text = "Missing Username or Password!\nTry Again!";
                MessageBox.Show("Missing Username or Password!\nTry Again!", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end BtnGo_Click

        public void loginScreen()       // hide credential input elements
        {
            LabName.Visible = false;
            LabPass.Visible = false;
            TxtUser.Visible = false;
            TxtPass.Visible = false;
        }

    }
}
