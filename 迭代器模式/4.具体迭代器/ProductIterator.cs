using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式
{
    public class ProductIterator : AbstractIterator
    {
        private ProductList productList;
        private IList<object> products;
        private int cursorAsc;     // 定义一个游标，用于记录正向遍历的位置
        private int cursorDesc;    // 定义一个游标，用于记录逆向遍历的位置

        public ProductIterator(ProductList productList)
        {
            this.productList = productList;
            this.products = productList.GetObjectList(); // 获取集合对象
            this.cursorAsc = 0;                          // 设置正向遍历游标的初始值
            this.cursorDesc = this.products.Count - 1;   // 设置逆向遍历游标的初始值
        }

        public void MoveNext()
        {
            if (cursorAsc < products.Count)
            {
                cursorAsc++;
            }
        }

        public bool IsLast()
        {
            return this.cursorAsc == products.Count;
        }

        public void MovePrevious()
        {
            if (cursorDesc > -1)
            {
                cursorDesc--;
            }
        }

        public bool IsFirst()
        {
            return cursorDesc == -1;
        }

        public object GetNextItem()
        {
            return products[cursorAsc];
        }

        public object GetPreviousItem()
        {
            return products[cursorDesc];
        }
    }
}