using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    public class PurchaseRequest
    {
        // 采购金额
        public double Amount { get; set; }

        // 采购单编号
        public string Number { get; set; }

        // 采购目的
        public string Purpose { get; set; }

        public PurchaseRequest(double amount, string number, string purpose)
        {
            this.Amount = amount;
            this.Number = number;
            this.Purpose = purpose;
        }
    }
}