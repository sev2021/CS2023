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

namespace SalesDBApp
{
    public partial class NewCustomer : Form
    {
        //declare variables
        private int parsedCustId = 0;   // preset value for user input
        private int orderID;        // preset value for user input

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///              [Create Account] button click event
        /// </summary>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {


            /// <summary>
            /// Validate Input
            /// </summary>

            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name invalid", 
                    "Warning", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // Create connection to Database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
            // Create command with name "cmd"
            SqlCommand cmd = new SqlCommand("Sales.uspNewCustomer", conn);


            cmd.CommandType = CommandType.StoredProcedure;


            // input parameter, takes value from client
            cmd.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
            cmd.Parameters["@CustomerName"].Value = txtCustomerName.Text;

            // ouput parameter
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
            cmd.Parameters["@CustomerID"].Direction = ParameterDirection.Output;


            try
            {

                conn.Open(); // open connection to DB
                cmd.ExecuteNonQuery();
                parsedCustId = (int)cmd.Parameters["@CustomerID"].Value;

                txtCustomerID.Text = Convert.ToString(parsedCustId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CustomerID not returned, please check connnection to DB.");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();  // close connectino to DB
            }



        } // end of btnCreateAccount_Click() event


        /// <summary>
        ///            [Place Order] button click event
        /// </summary>
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            /// <summary>
            /// Validate Input
            /// </summary>

            if (txtCustomerID.Text.Trim() == "")
            {
                MessageBox.Show("Customer Account must be created before placing the order",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (numOrderAmount.Value == 0)
            {
                MessageBox.Show("Order Amount must be greater than 1",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // Create connection to Database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);

            // Create command with name "cmd"
            SqlCommand cmd = new SqlCommand("Sales.uspPlaceNewOrder", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            // add customerId input parameter
            cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
            cmd.Parameters["@CustomerID"].Value = parsedCustId;

            // add order Amount input Parameter
            cmd.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            cmd.Parameters["@Amount"].Value = numOrderAmount.Value;

            // add order Date input Parameter
            cmd.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
            cmd.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

            // add Status Input Parameter
            cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
            cmd.Parameters["@Status"].Value = "O";

            // add return value parameter
            cmd.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
            cmd.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

            try
            {

                conn.Open(); // open connection to DB
                cmd.ExecuteNonQuery();
                orderID = (int)cmd.Parameters["@RC"].Value;

                MessageBox.Show("Order nummber " + orderID + " has been submitted.");

                txtCustomerID.Text = Convert.ToString(parsedCustId);
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


        }// end of btnPlaceOrder_Click() event


        /// <summary>
        ///           [Add Another Account] button click event
        /// </summary>
        private void btnAddAnotherAccount_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        /// <summary>
        ///         clear form method
        /// </summary>
        private void ClearForm()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            numOrderAmount.Value = 0;
            dtpOrderDate.Value = DateTime.Now;
            parsedCustId = 0;
            orderID = 0;
        }
    }
}
