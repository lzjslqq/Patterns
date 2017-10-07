using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    internal class Program
    {
        /// <summary>
        ///     命令模式：将请求封装为一个对象，从而可以用不同的请求对客户端进行参数化；对请求排队或者记录日志，以及撤销等操作。
        /// 命令模式是一种行为型模式，其别名为动作模式或事务模式。
        ///     命令模式的本质在于：对请求进行封装，一个请求对应一个命令，将发出命令的责任和执行命令的责任分割开，使得请求的一
        /// 方不必了解接收请求的一方的接口，更不必知道请求如何被接收、操作是否被执行、何时被执行，以及是怎么被执行的。
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // Step1.模拟显示功能键设置窗口
            FBSettingWindow window = new FBSettingWindow("功能键设置窗口");

            // Step2.假如目前要设置两个功能键
            FunctionButton buttonA = new FunctionButton("功能键A");
            FunctionButton buttonB = new FunctionButton("功能键B");

            // Step3.读取配置文件和反射生成具体命令对象
            Command commandA = Utility.AppConfigHelper.CreateInstance("HelpCommand") as Command;
            Command commandB = Utility.AppConfigHelper.CreateInstance("MiniCommand") as Command;

            // Step4.将命令注入功能键
            buttonA.SetCommand(commandA);
            buttonB.SetCommand(commandB);
            window.AddButton(buttonA);
            window.AddButton(buttonB);
            window.Display();

            // Step5.调用功能键的业务方法
            buttonA.OnClick();
            buttonB.OnClick();

            Console.ReadKey();
        }
    }
}