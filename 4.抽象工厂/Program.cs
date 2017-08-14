using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    /*
     *     M公司IT开发部接到一个开发任务，想要对以前的一个系统开发一套界面皮肤库，可以对该桌面系统软件进行界面美化。
     * 这样，用户就可以在使用时通过菜单来选择皮肤，不同的皮肤将提供视觉效果不同的按钮、文本框以及组合框等界面元素
     * 即生产不同产品等级结构、属于不同类型的具体产品
     *
     *     抽象工厂与工厂方法最大的区别就在于，工厂方法模式针对的是一个产品等级结构，而抽象工厂模式需要面对多个产品等级结构，
     * 一个工厂等级结构可以负责多个不同产品等级中的产品对象的创建（产品族）。
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            ISkinFactory skinFactory = (ISkinFactory)AppConfigHelper.GetSkinFactoryInstance();
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }

            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}