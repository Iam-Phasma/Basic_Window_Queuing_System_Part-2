using System;
using System.Windows.Forms;

namespace Basic_Queuing_Cashier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowAllWindows(new CashierWindowQueueForm(), new QueuingForm(), new CustomerView()));
        }
    }
}
