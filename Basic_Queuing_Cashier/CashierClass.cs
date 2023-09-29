using System.Collections.Generic;

namespace Basic_Queuing_Cashier
{
    class CashierClass
    {

        public static int x;
        public static bool refreshNow = false;
        public static string getNumberInQueue = " ";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }


    }
}
