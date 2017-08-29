using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    public class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}