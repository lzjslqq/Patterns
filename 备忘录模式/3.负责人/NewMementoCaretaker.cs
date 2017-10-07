using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    /// <summary>
    /// 支持多次撤销版本
    /// </summary>
    public class NewMementoCaretaker
    {
        private IList<ChessmanMemento> Memento = new List<ChessmanMemento>();

        public ChessmanMemento GetMemento(int i)
        {
            return Memento[i];
        }

        public void SetMemento(ChessmanMemento memento)
        {
            Memento.Add(memento);
        }
    }
}