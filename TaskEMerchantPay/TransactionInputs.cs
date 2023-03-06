using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEMerchantPay
{
    public class TransactionInputs
    {
        public long CardNumer { get; set; }
        public int Cvv { get; set; }
        public string ExpDate { get; set; }
        public int Amount { get; set; }
        public string Usage { get; set; }
        public string TransactionType { get; set; }
        public string CardHolder { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
