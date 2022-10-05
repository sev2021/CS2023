using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class MyFirstForm : Form  // /////////// MyFirstForm inheritates from Form class
    {
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Load");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //TxtUser.Text = "";
            //TxtPass.Clear();
            //Close();              // close this one form
            Application.Exit();     // close all application
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if(TxtUser.TextLength > 0 && TxtUser.TextLength > 0)
            {
                LabResult.Text = "Pass Coprrect";
            }
            else
            {
                LabResult.Text = "Missing Username or Password!\nTry Again!";
                MessageBox.Show("Missing Username or Password!\nTry Again!", 
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
