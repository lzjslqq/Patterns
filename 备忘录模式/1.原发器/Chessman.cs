using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    /// <summary>
    /// 原发器是一个普通类，可以创建一个备忘录，并存储其当前内部状态，也可以使用备忘录来恢复其内部状态，
    /// 一般需要保存内部状态的类设计为原发器
    /// </summary>
    public class Chessman
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Chessman(string label, int x, int y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 保存状态
        /// </summary>
        /// <returns></returns>
        public ChessmanMemento Save()
        {
            return new ChessmanMemento(Label, X, Y);
        }

        /// <summary>
        /// 恢复状态
        /// </summary>
        /// <param name="memento"></param>
        public void Recover(ChessmanMemento memento)
        {
            Label = memento.Label;
            X = memento.X;
            Y = memento.Y;
        }
    }
}