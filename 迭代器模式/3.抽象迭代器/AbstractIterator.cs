using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式
{
    public interface AbstractIterator
    {
        /// <summary>
        /// 移动至下一个元素
        /// </summary>
        void MoveNext();

        /// <summary>
        /// 判断是否为最后一个元素
        /// </summary>
        /// <returns></returns>
        bool IsLast();

        /// <summary>
        /// 移动至上一个元素
        /// </summary>
        void MovePrevious();

        /// <summary>
        /// 判断是否为第一个元素
        /// </summary>
        /// <returns></returns>
        bool IsFirst();

        /// <summary>
        /// 获取下一个元素
        /// </summary>
        /// <returns></returns>
        object GetNextItem();

        /// <summary>
        /// 获取上一个元素
        /// </summary>
        /// <returns></returns>
        object GetPreviousItem();
    }
}