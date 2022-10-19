using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDBApp
{
    public partial class FillOrCancel : Form
    {
        //declare variables
        private int parsedOrderID;   // preset value for user input
        private bool orderFound = false;        // preset value for user input

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
            if (txtOrderID.Text.Length == 0) return;
            string sqlString = "SELECT * FROM Sales.Orders WHERE orderID = " + txtOrderID.Text + ";";


            // Create connection to Database
            // using(expression){code block} is used to clear all data after block execution end
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
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

                    /////////// SQL injecion: 4; CREATE TABLE sales.tt(x int)  ///////////////

                    orderFound = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("OlderID not placed, please check connnection to DB.");
                    MessageBox.Show(ex.ToString());
                    orderFound = false;
                }
                finally
                {
                    conn.Close();  // close connectino to DB
                }

            } // end of "using" expression
        }



        /// <summary>
        ///             [Cancel Order] button click event
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Create connection to Database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            // Create command with name "cmd"
            SqlCommand cmd = new SqlCommand("Sales.uspCancelOrder", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
            cmd.Parameters["@OrderID"].Value = parsedOrderID;


            try
            {
                conn.Open(); // open connection to DB
                cmd.ExecuteNonQuery();  // runs Stored Procedures 
            }

            catch (Exception ex)
            {
                MessageBox.Show("The order was not canceled.");
                MessageBox.Show(ex.ToString());
                orderFound = false;
            }
            finally
            {
                conn.Close();  // close connectino to DB
            }

        }



        /// <summary>
        ///             [Fill Order] button click event
        /// </summary>
        private void btnFillOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Create connection to Database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            // Create command with name "cmd"
            SqlCommand cmd = new SqlCommand("Sales.uspFillOrder", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
            cmd.Parameters["@OrderID"].Value = parsedOrderID;

            cmd.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
            cmd.Parameters["@FilledDate"].Value = dtpFillDate.Value;


            try
            {
                conn.Open(); // open connection to DB
                cmd.ExecuteNonQuery();  // runs Stored Procedures 
            }

            catch (Exception ex)
            {
                MessageBox.Show("The order was not filled.");
                MessageBox.Show(ex.ToString());
                orderFound = false;
            }
            finally
            {
                conn.Close();  // close connectino to DB
            }

        }

        /// <summary>
        ///             Validate Input METHOD
        /// </summary>
        private bool ValidateForm()
        {
            if (!orderFound)
            {
                MessageBox.Show("Order ID not selected!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (Regex.IsMatch(txtOrderID.Text, @"\D"))
            {
                MessageBox.Show("Order ID must be letters only!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            parsedOrderID = Int32.Parse(txtOrderID.Text);
            return true;
        }
    }
}
