using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    public class ProxySearcher : ISearcher
    {
        private RealSearcher realSearcher;
        private AccessValidator validator;
        private Logger logger;

        public ProxySearcher()
        {
            realSearcher = new RealSearcher();
        }

        public string DoSearch(string userId, string keyword)
        {
            if (Validate(userId))
            {
                string result = realSearcher.DoSearch(userId, keyword);
                this.Log(userId);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 创建访问验证对象并调用其Validate()方法进行身份验证
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Validate(string userId)
        {
            validator = new AccessValidator();
            return validator.Validate(userId);
        }

        public void Log(string userId)
        {
            logger = new Logger();
            logger.Log(userId);
        }
    }
}