using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}