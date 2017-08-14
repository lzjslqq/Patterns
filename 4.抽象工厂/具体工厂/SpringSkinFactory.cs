﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}