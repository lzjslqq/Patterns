﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.抽象工厂
{
    public class AppConfigHelper
    {
        public static string GetSkinFactoryName()
        {
            string factoryName = null;
            try
            {
                factoryName = System.Configuration.ConfigurationManager.AppSettings["SkinFactory"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factoryName;
        }

        public static object GetSkinFactoryInstance()
        {
            string assemblyName = AppConfigHelper.GetSkinFactoryName();
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}