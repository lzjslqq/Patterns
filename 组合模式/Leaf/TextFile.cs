using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    public class TextFile : AbstractFile
    {
        private string name;

        public TextFile(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法");
        }

        public override AbstractFile GetChild(int index)
        {
            Console.WriteLine("对不起，不支持该方法");
            return null;
        }

        public override void KillVirus()
        {
            //模拟杀毒方法
            Console.WriteLine("对图像文件“{0}”进行杀毒！", name);
        }
    }
}