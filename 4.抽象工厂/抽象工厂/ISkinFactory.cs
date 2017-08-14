using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public interface ISkinFactory
    {
        IButton CreateButton();

        ITextField CreateTextField();

        IComboBox CreateComboBox();
    }
}