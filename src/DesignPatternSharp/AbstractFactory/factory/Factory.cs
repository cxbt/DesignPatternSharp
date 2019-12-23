using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPatternSharp.AbstractFactory.factory
{
    public abstract class Factory
    {
        public static Factory getFactory(string classname)
        {
            Factory factory = null;
            try
            {
                factory = Activator.CreateInstance(Type.GetType(classname)) as Factory;
            }
            catch (System.IO.FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return factory;
        }

        public abstract Link createLink(string caption, string url);
        public abstract Tray createTray(string caption);
        public abstract Page createPage(string title, string author);
    }
}
