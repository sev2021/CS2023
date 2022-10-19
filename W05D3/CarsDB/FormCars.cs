using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
        }

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


        // Navigation buttons

        /// <summary>
        ///     Moethod to navigate to the first record
        /// </summary>
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveFirst();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Moethod to navigate to the previious record
        /// </summary>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MovePrevious();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Moethod to navigate to the next record
        /// </summary>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveNext();
            UpdateRecordCount();
        }

        /// <summary>
        ///     Moethod to navigate to the last record
        /// </summary>
        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.tblCarBindingSource.MoveLast();
            UpdateRecordCount();
        }

        private void UpdateRecordCount()
        {
            int currentRecord = this.tblCarBindingSource.Position + 1;
            int numOfRecords = this.tblCarBindingSource.Count;

            TxtRecordNum.Text = $"{ currentRecord } of { numOfRecords }";
        }
    }
}
