using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    public class BlackIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "黑色";
        }
    }
}