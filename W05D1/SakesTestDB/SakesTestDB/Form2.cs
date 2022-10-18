using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SakesTestDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            SqlCommand cmd = new SqlCommand("Sales.uspNewCustomer", conn);


            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
            cmd.Parameters["@CustomerName"].Value = textBox1.Text;

            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
            cmd.Parameters["@CustomerID"].Direction = ParameterDirection.Output;


            conn.Open();
            cmd.ExecuteNonQuery();
            textBox2.Text = Convert.ToString(cmd.Parameters["@CustomerID"].Value);
            conn.Close();
            
        }
    }
}
