using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    /// <summary>
    /// 具体访问者：HR部门
    /// </summary>
    public class HRDepartment : Department
    {
        /// <summary>
        /// 实现人力资源部对全职员工数据的访问
        /// </summary>
        /// <param name="employee"></param>
        public override void Visit(FullTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            Console.WriteLine("正式员工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);

            if (workTime > 40)
            {
                Console.WriteLine("正式员工 {0} 加班时间为：{1} 小时", employee.Name, workTime - 40);
            }
            else if (workTime < 40)
            {
                Console.WriteLine("正式员工 {0} 请假时间为：{1} 小时", employee.Name, 40 - workTime);
            }
        }

        /// <summary>
        /// 实现人力资源部对兼职员工数据的访问
        /// </summary>
        /// <param name="employee"></param>
        public override void Visit(PartTimeEmployee employee)
        {
            int workTime = employee.WorkTime;
            Console.WriteLine("临时工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);
        }
    }
}