using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    public class IgoChessmanFactory
    {
        private static readonly IgoChessmanFactory instance = new IgoChessmanFactory(); // 使用单例模式实现享元
        private static Hashtable ht;    // 使用Hashtable来存储享元对象，充当享元池

        private IgoChessmanFactory()
        {
            ht = new Hashtable();
            IgoChessman blackChess = new BlackIgoChessman();
            ht.Add("black", blackChess);
            IgoChessman whiteChess = new WhiteIgoChessman();
            ht.Add("white", whiteChess);
        }

        public static IgoChessmanFactory GetInstance()
        {
            return instance;
        }

        public IgoChessman GetIgoChessman(string color)
        {
            IgoChessman chess = ht[color] as IgoChessman;
            return chess;
        }
    }
}