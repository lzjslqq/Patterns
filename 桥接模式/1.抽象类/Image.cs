using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    /// <summary>
    /// 抽象类——抽象图像类
    /// </summary>
    public abstract class Image
    {
        protected ImageImplementor imageImpl;

        public void SetImageImplementor(ImageImplementor imageImpl)
        {
            this.imageImpl = imageImpl;
        }

        public abstract void ParstFile(string fileName);
    }
}