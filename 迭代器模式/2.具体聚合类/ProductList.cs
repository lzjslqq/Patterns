using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式
{
    public class ProductList : AbstractObjectList
    {
        public ProductList(IList<object> objectList)
            : base(objectList)
        {
        }

        public override AbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}