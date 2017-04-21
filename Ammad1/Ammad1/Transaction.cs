using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammad1
{
    public class Transaction
    {
        int id;
        DateTime transactionDate;
        int salesPrice;
        int commission;

        public int Id { get => id; set => id = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public int SalesPrice { get => salesPrice; set => salesPrice = value; }
        public int Commission { get => commission; set => commission = value; }
    }
}
