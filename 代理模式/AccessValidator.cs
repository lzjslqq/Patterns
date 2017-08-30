using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 业务类：身份验证类
    /// </summary>
    public class AccessValidator
    {
        /// <summary>
        /// 模拟实现登录验证
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Validate(string userId)
        {
            Console.WriteLine("在数据库中验证用户 {0} 是否是合法用户?", userId);
            if (userId.Equals("lqq", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("{0} 登录成功!", userId);
                return true;
            }
            else
            {
                Console.WriteLine("{0} 登录失败!", userId);
                return false;
            }
        }
    }
}