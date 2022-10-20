using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Generics
{
    public static class Utils
    {
        public static T Reflect<T>(T value)
        {
            return value;
        }
    }
}
