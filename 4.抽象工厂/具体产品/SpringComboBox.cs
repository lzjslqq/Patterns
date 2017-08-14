using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框下拉框...");
        }
    }
}