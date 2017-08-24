using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    /*     M公司开发部想要开发一个杀毒软件，该软件既可以针对某个文件夹杀毒，也可以针对某个指定的文件进行杀毒。
     * 该杀毒软件还可以根据各类文件的特点，为不同类型的文件提供不同的杀毒方式，例如图像文件（ImageFile）和
     * 文本文件（TextFile）的杀毒方式就有所差异。现需要提供该杀毒软件的整体框架设计方案。
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractFile folder1 = new Folder("lqq个人文件夹");
            AbstractFile folder2 = new Folder("图像文件夹");
            AbstractFile folder3 = new Folder("文本文件夹");
            AbstractFile folder4 = new Folder("视频文件夹");

            AbstractFile image1 = new ImageFile("小龙女.jpg");
            AbstractFile image2 = new ImageFile("杨过.jpg");

            AbstractFile text1 = new TextFile("我的文件1.txt");
            AbstractFile text2 = new TextFile("我的文件2.doc");

            AbstractFile video1 = new VideoFile("七龙珠.rmvb");
            AbstractFile video2 = new VideoFile("哆啦A梦.mp4");

            folder2.Add(image1);
            folder2.Add(image2);

            folder3.Add(text1);
            folder3.Add(text2);

            folder4.Add(video1);
            folder4.Add(video2);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            folder1.KillVirus();

            Console.ReadKey();
        }
    }
}