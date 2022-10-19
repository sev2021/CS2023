using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDB
{
    public partial class FormCars : Form
    {
        /// <summary>
        ///         Constructor, constructs instance of the form
        /// </summary>
        public FormCars()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = new CultureInfo("en-IE");
        }


        // INITIAL FORM LOAD METHOD

        /// <summary>
        ///         Method for Form_Load event, runs when form loads
        /// </summary>
        private void FrmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet1.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet1.tblCar);

            this.Text = "Task A Seweryn Sapinski " + DateTime.Now.ToShortDateString();
            this.Text = "Task A Seweryn Sapinski 21/10/2022";

            UpdateRecordCount();
        }


        //////////////////////////
        ////////////////////////// NAVIGATION BUTTONS EVENTS METHODS
        //////////////////////////

        /// <summary>
        ///     Method to navigate to the first record
        /// </summary>
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveFirst();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Method to navigate to the previious record
        /// </summary>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MovePrevious();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Method to navigate to the next record
        /// </summary>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveNext();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Method to navigate to the last record
        /// </summary>
        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveLast();
            UpdateRecordCount();
        }


        //////////////////////////////////////////
        ////////////////////////////////////////// DATA MODIFICATION BUTTONS
        //////////////////////////////////////////

        /// <summary>
        ///         Method to pupdate the record
        /// </summary>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.EndEdit();
            this.tblCarTableAdapter.Update(this.hireDataSet1.tblCar);
            MessageBox.Show("Updates applied");
        }


        /// <summary>
        ///         Method to add new record to Database
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string rateString = TxtRate.Text;
            decimal theRate = 0;
            if (Decimal.TryParse(rateString, out theRate))
            {
                this.tblCarTableAdapter.Insert(
                                            TxtRegNo.Text,
                                            TxtMake.Text,
                                            TxtEngine.Text,
                                            DateTime.Parse(TxtRegDate.Text),
                                            theRate,
                                            CbxAvailable.Checked
                                            );
                UpdateData();
                RefreshBiding();
            }
            else
            {
                MessageBox.Show("Rental per day must be a number.",
                                "Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                return;
            }

        }


        /// <summary>
        ///         Method to delete record from Database
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string rateString = TxtRate.Text;
            decimal theRate = 0;
            if (Decimal.TryParse(rateString, out theRate))
            {
                this.tblCarTableAdapter.Delete(
                                            TxtRegNo.Text,
                                            TxtMake.Text,
                                            TxtEngine.Text,
                                            DateTime.Parse(TxtRegDate.Text),
                                            theRate,
                                            CbxAvailable.Checked
                                            );
                UpdateData();
                RefreshBiding();
            }
        }


        //////////////////////////////////////////
        ////////////////////////////////////////// FORM CONTROL BUTTONS
        //////////////////////////////////////////

        /// <summary>
        ///         Method to open search form
        /// </summary>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Form formSearch = new FormSearch();
            formSearch.ShowDialog();
        }


        /// <summary>
        ///         Method to cancel +changes to data fields
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
        }


        /// <summary>
        ///         Method for the Exit button to terminate the program.
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Do you wish to exit?",
                                                "Warning",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Warning);

            if (exitResult == DialogResult.OK)
            {
                Application.Exit();
            }

        } // end of BtnExit_Click


        /////////////////////////////////////////// 
        /////////////////////////////////////////// HELPER METHODS
        /////////////////////////////////////////// 

        /// <summary>
        ///         Method to display the total record count 
        ///         and current record number each time one of 
        ///         the navigation buttons Is used.
        /// </summary>
        private void UpdateRecordCount()
        {
            int currentRecord = this.tblCarBindingSource.Position + 1;
            int numOfRecords = this.tblCarBindingSource.Count;

            TxtRecordNum.Text = $"{currentRecord} of {numOfRecords}";
        }


        /// <summary>
        ///         Method to update TableAdapter to most revent data
        ///         to be called after any insert, update or delete
        /// </summary>
        private void UpdateData()
        {
            this.tblCarBindingSource.MoveLast();
            this.tblCarTableAdapter.Fill(this.hireDataSet1.tblCar);
        }


        /// <summary>
        ///         Method to reset tblCarBindingSource bindings
        ///         to be called after any insert, update or delete
        /// </summary>
        private void RefreshBiding()
        {
            this.tblCarBindingSource.ResetBindings(false);
            UpdateRecordCount();
        }

    }
}
