using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    /// <summary>
    /// 负责任又称为管理者，它负责保存备忘录，但是不能对备忘录的内容进行操作或检查
    /// 单次撤销版本
    /// </summary>
    public class MementoCaretaker
    {
        public ChessmanMemento Memento { get; set; }
    }
}