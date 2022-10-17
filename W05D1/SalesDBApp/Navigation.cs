using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDBApp
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Method to create an instance ofthe NewCustomer() form
        ///     Show() opens the NewCustomer form while allowing
        ///     access to Navigation() form
        /// </summary>

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form myNewCustomer = new NewCustomer();
            //myNewCustomer.ShowDialog(this);
            myNewCustomer.Show();

        }

        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form myFillOrCancel = new FillOrCancel();
            myFillOrCancel.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
