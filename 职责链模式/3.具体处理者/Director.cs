using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    /// <summary>
    /// 具体处理者--主管
    /// </summary>
    public class Director : Approver
    {
        public Director(string name)
            : base(name)
        {
        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 50000)
            {
                //处理请求
                Console.WriteLine("主管 {0} 审批了采购单：{1}，金额：{2} 元，采购目的：{3}。",
                     this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                // 如果处理不了，转发请求给更高层领导
                this.successor.ProcessRequest(request);
            }
        }
    }
}