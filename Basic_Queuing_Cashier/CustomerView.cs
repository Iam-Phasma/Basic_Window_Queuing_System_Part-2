using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Basic_Queuing_Cashier
{
    public partial class CustomerView : Form
    {


        Timer customerTimer = new Timer();
        CashierClass cashier;

        public CustomerView()
        {
            InitializeComponent();
            cashier = new CashierClass();
            customerTimer.Interval = 1000;
            customerTimer.Tick += new EventHandler(CustomerView_Load);
            customerTimer.Start();
        }


        public void displaycashierqueue(IEnumerable CashierList)
        {
            var enumerator = CashierList.GetEnumerator();
            if (enumerator.MoveNext())
            {
                lblPeek.Text = enumerator.Current.ToString();
            }
            else
            {
                lblPeek.Text = "No customers in queue";
            }
        }


        public void CustomerView_Load(object sender, EventArgs e)
        {
            displaycashierqueue(CashierClass.CashierQueue);
            customerTimer.Interval = 5000;
            customerTimer.Tick += new EventHandler(CustomerView_Load);
        }

        private void lblPeek_Click(object sender, EventArgs e)
        {

        }
    }
}
