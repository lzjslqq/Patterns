using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    /// <summary>
    /// 董事会：具体处理者
    /// </summary>
    public class Congress : Approver
    {
        public Congress(string name)
            : base(name)
        {
        }

        // 具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            // 处理请求
            Console.WriteLine("董事会 {0} 审批了采购单：{1}，金额：{2} 元，采购目的：{3}。",
                this.name, request.Number, request.Amount, request.Purpose);
        }
    }
}