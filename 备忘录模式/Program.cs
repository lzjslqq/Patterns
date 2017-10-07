using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    /// <summary>
    /// 实现悔棋功能：备忘录模式提供了一种状态恢复的机制，使得用户可以方便地回到一个特定的历史步骤，当新的状态无效或者存在问题时，
    /// 可以使用暂存的备忘录将状态恢复。
    /// </summary>
    internal class Program
    {
        private static int index = -1;
        private static NewMementoCaretaker mementoCaretaker = new NewMementoCaretaker();

        /// <summary>
        /// 备忘录模式：在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，方便以后恢复到原先保存的状态。
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            MementoCaretaker mc = new MementoCaretaker();
            Chessman chess = new Chessman("车", 1, 1);
            Display(chess);

            // 保存状态1
            mc.Memento = chess.Save();
            chess.Y = 5;
            Display(chess);
            // 保存状态2
            mc.Memento = chess.Save();
            Display(chess);
            chess.X = 8;
            Display(chess);

            Console.WriteLine("---------- Sorry，俺悔棋了 ---------");
            chess.Recover(mc.Memento);
            Display(chess);

            // 多次撤销操作
            Chessman newChess = new Chessman("车", 1, 1);
            Play(newChess);
            newChess.Y = 4;
            Play(newChess);
            newChess.X = 5;
            Play(newChess);

            Undo(newChess, index);
            Undo(newChess, index);
            Redo(newChess, index);
            Redo(newChess, index);

            Console.Read();
        }

        public static void Display(Chessman chess)
        {
            Console.WriteLine("棋子 {0} 当前位置为：第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }

        // 下棋
        public static void Play(Chessman chess)
        {
            // 保存备忘录
            mementoCaretaker.SetMemento(chess.Save());
            index++;

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }

        // 悔棋
        public static void Undo(Chessman chess, int i)
        {
            Console.WriteLine("---------- Sorry，俺悔棋了 ---------");
            index--;
            // 撤销到上一个备忘录
            chess.Recover(mementoCaretaker.GetMemento(i - 1));

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }

        // 撤销悔棋
        public static void Redo(Chessman chess, int i)
        {
            Console.WriteLine("---------- Sorry，撤销悔棋 ---------");
            index++;
            // 恢复到下一个备忘录
            chess.Recover(mementoCaretaker.GetMemento(i + 1));

            Console.WriteLine("棋子 {0} 当前位置为 第 {1} 行 第 {2} 列", chess.Label, chess.X, chess.Y);
        }
    }
}