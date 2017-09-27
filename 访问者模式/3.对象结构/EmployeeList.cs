using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 对象结构类
    /// </summary>
    public class EmployeeList
    {
        private IList<IEmployee> employeeList = new List<IEmployee>();

        public void AddEmployee(IEmployee emp)
        {
            this.employeeList.Add(emp);
        }

        public void Accept(Department handler)
        {
            foreach (var emp in employeeList)
            {
                emp.Accept(handler);
            }
        }
    }
}