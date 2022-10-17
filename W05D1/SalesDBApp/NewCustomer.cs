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
        private int parsedCustId; // preset value for user input

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        // [Create Account] button click event
        //
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {   
            // Create connection to Database
            using(SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Create command with name "cmd"
                using (SqlCommand cmd = new SqlCommand("Sales.uspNewCustomer", conn))
                { 
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("CustomerID not returned, please check connnection to DB.");
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();  // close connectino to DB
                    }
                }

            } // end of Create connection to Database

        } // end of btnCreateAccount_Click() event


        //
        // [Place Order] button click event
        //
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Create connection to Database
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Create command with name "cmd"
                using (SqlCommand cmd = new SqlCommand("Sales.uspPlaceNewOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // add customerId input parameter
                    cmd.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                    cmd.Parameters["@CustomerID"].Value = parsedCustId;

                    // add order Date Ubput Parameter


                    // add Status Input Parameter


                    // add return value


                }
            } // end of Create connection to Database
        }// end of btnPlaceOrder_Click() event
    }
}
