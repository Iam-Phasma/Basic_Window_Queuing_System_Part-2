using System;
using System.Windows.Forms;

namespace Basic_Queuing_Cashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;

        public QueuingForm()
        {
            cashier = new CashierClass();
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            CashierClass.refreshNow = true;

        }

    }
}
