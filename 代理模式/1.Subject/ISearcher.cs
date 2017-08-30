using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 抽象主题角色--抽象查询接口
    /// </summary>
    public interface ISearcher
    {
        string DoSearch(string userId, string keyword);
    }
}