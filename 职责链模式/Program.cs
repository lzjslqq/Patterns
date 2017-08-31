using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    /*    M公司承接了某企业SCM（Supply Chain Management,供应链管理）系统的开发任务，其中包含一个采购审批子系统。
     * 该企业的采购审批是分级进行的，即根据采购金额的不同由不同层次的主管人员来审批：主任可以审批5万元以下（不包括5万）的采购单，
     * 副董事长可以审批5万~10万（不包括10万）的采购单，50万元以及以上的采购单就需要开董事会讨论决定.*/

    internal class Program
    {
        /// <summary>
        /// 职责链（Chain of Responsibility）模式：避免将请求发送者与接受者耦合在一起，让多个对象都有机会接受请求，将这些对象连成一条链，并且沿着这条链传递请求，直到有对象处理它为止。职责链模式是一种对象行为型模式。　　
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // 创建职责链
            Approver director = new Director("Andy");
            Approver vicePresident = new VicePresident("Jack");
            Approver president = new President("Nacy");
            Approver congress = new Congress("Congress");

            // 置继任者
            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);
            president.SetSuccessor(congress);

            // 构造采购请求单并发送审批请求
            PurchaseRequest request1 = new PurchaseRequest(45000.00, "MANULIFE201706001", "购买PC和显示器");
            director.ProcessRequest(request1);

            PurchaseRequest request2 = new PurchaseRequest(60000.00, "MANULIFE201706002", "2017开发团队活动");
            director.ProcessRequest(request2);

            PurchaseRequest request3 = new PurchaseRequest(160000.00, "MANULIFE201706003", "2017公司年度旅游");
            director.ProcessRequest(request3);

            PurchaseRequest request4 = new PurchaseRequest(800000.00, "MANULIFE201706004", "租用新临时办公楼");
            director.ProcessRequest(request4);

            Console.Read();
        }
    }
}