﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮...");
        }
    }
}