using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.Drawing;
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

        private void MyFirstForm_Load(object sender, EventArgs e) // load event action
        {
        }

        private void BtnClose_Click(object sender, EventArgs e) // [ Close ]  button action
        {
            //TxtUser.Text = "";
            //TxtPass.Clear();
            //Close();              // close this one form
            Application.Exit();     // close all application
        }

        private void BtnClose_Hover(object sender, EventArgs e) // [ Close ]  button action
        {
            BtnClose.BackColor = System.Drawing.Color.DarkRed;
        }

        private void BtnClose_Leave(object sender, EventArgs e) // [ Close ]  button action
        {
            BtnClose.BackColor = System.Drawing.Color.Red;
        }


        private void BtnGo_Click(object sender, EventArgs e)    // [ Go ]  button action
        {
            if(TxtUser.TextLength > 0 && TxtUser.TextLength > 0)
            {
                string inputUser = TxtUser.Text;    // variable
                string inputPass = TxtPass.Text;    // variable

                if (inputUser == Username && inputPass == Password)
                {
                    LabResult.ForeColor = System.Drawing.Color.Green;
                    LabResult.Text = "Login Successfull!";
                    LoginScreen();
                }
                else
                {
                    LabResult.ForeColor = System.Drawing.Color.Red;
                    LabResult.Text = $"Wrong Username or Password!\nTry Again!";
  
                }
            }
            else
            {
                LabResult.ForeColor = System.Drawing.Color.Red;
                LabResult.Text = "Missing Username or Password!\nTry Again!";
                MessageBox.Show("Missing Username or Password!\nTry Again!", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end BtnGo_Click

        public void LoginScreen()       // hide credential input elements
        {
            LabName.Visible = false;
            LabPass.Visible = false;
            TxtUser.Visible = false;
            TxtPass.Visible = false;
        }

    }
}
