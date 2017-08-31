using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    /// <summary>
    /// 审批者类：抽象处理者
    /// </summary>
    public abstract class Approver
    {
        // 定义后继对象
        protected Approver successor;

        // 审批者姓名
        protected string name;

        public Approver(string name)
        {
            this.name = name;
        }

        // 设置后继者
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        // 抽象请求处理方法
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}