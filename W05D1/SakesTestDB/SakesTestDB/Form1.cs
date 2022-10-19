using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakesTestDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nextForm = new Form2();
            nextForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

// Data Source = (LocalDB)\MSSQLLocalDB; 
// AttachDbFilename = C:\Users\user\source\repos\CS\W05D1\SakesTestDB\SakesTestDB\Database1.mdf; 
// Integrated Security = True