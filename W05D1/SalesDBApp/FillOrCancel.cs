using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDBApp
{
    public partial class FillOrCancel : Form
    {
        public FillOrCancel()
        {
            InitializeComponent();
        }

        private void btnFinishUpdates_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///             [Find Order] button click event
        ///             To find is order exist by execute t-sql statement
        /// </summary>
        
        private void btnFindByOrderID_Click(object sender, EventArgs e)
        {

            string sqlString = "SELECT * FROM Sales.Orders WHERE orderID = " + txtOrderID.Text + ";";
            
            // Create connection to Database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);

            // Create command with name "cmd"
            // SqlCommand cmd = new SqlCommand("Sales.uspNewCustomer", conn);
            SqlCommand cmd = new SqlCommand(sqlString, conn);



            try
            {
                conn.Open(); // open connection to DB
                // create data-reader to read throu dataset from SqlCommand
                SqlDataReader reader = cmd.ExecuteReader();  // execute the "cmd" query to reader
                DataTable dt = new DataTable();  // data-table is container to store returned data
                dt.Load(reader);                // loaad data to data-table
                dgvCustomersOrders.DataSource = dt; // display data-table content to Data Grid View
                reader.Close();                 // data-reader must close

                // DONT RUN: 4; CREATE TABLE sales.tt(x int)
            }

            catch (Exception ex)
            {
                MessageBox.Show("OlderID not placed, please check connnection to DB.");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();  // close connectino to DB
            }

        }

        /// <summary>
        ///             [Cancel Order] button click event
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///             [Fill Order] button click event
        /// </summary>
        private void btnFillOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
