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

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            NewCustomer myNewCustomer = new NewCustomer();
            myNewCustomer.ShowDialog(this);

        }

        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            FillOrCancel myFillOrCancel = new FillOrCancel();
            myFillOrCancel.ShowDialog(this);
        }
    }
}
