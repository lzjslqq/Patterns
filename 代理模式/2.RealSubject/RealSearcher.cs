using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 真实主题类--具体查询接口
    /// </summary>
    public class RealSearcher : ISearcher
    {
        /// <summary>
        /// 模拟查询
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public string DoSearch(string userId, string keyword)
        {
            Console.WriteLine("{0} 使用关键词 {1}", userId, keyword);
            return "返回查询结果";
        }
    }
}