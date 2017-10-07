using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    /// <summary>
    /// 存储原发器的状态，根据原发器来决定保存哪些内部状态
    /// </summary>
    public class ChessmanMemento
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public ChessmanMemento(string label, int x, int y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }
    }
}