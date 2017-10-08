using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式
{
    /// <summary>
    /// 抽象聚合类
    /// </summary>
    public abstract class AbstractObjectList
    {
        protected IList<object> objectList = new List<object>();

        public AbstractObjectList(IList<object> objectList)
        {
            this.objectList = objectList;
        }

        /// <summary>
        /// 增加项
        /// </summary>
        /// <param name="obj"></param>
        public void AddObject(object obj)
        {
            this.objectList.Add(obj);
        }

        /// <summary>
        /// 移除项
        /// </summary>
        /// <param name="obj"></param>

        public void RemoveObject(object obj)
        {
            this.objectList.Remove(obj);
        }

        public IList<object> GetObjectList()
        {
            return this.objectList;
        }

        /// <summary>
        /// 声明创建迭代器对象的抽象工厂方法
        /// </summary>
        /// <returns></returns>
        public abstract AbstractIterator CreateIterator();
    }
}