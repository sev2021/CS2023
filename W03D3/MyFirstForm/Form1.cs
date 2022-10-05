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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Load");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            TxtPass.Clear();

            //Close();
            C
        }
    }
}
