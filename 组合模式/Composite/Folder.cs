using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    public class Folder : AbstractFile
    {
        private string name;
        private IList<AbstractFile> fileList = new List<AbstractFile>();

        public Folder(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            fileList.Add(file);
        }

        public override void Remove(AbstractFile file)
        {
            fileList.Remove(file);
        }

        public override AbstractFile GetChild(int index)
        {
            return fileList[index];
        }

        public override void KillVirus()
        {
            //模拟杀毒操作
            Console.WriteLine("正在对文件夹“{0}”进行杀毒", name);
            foreach (var item in fileList)
            {
                item.KillVirus();
            }
        }
    }
}