using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    // this is a hard requirement that you should have to define static class
    // when you define static method
   public static class ExtensionMethodClass
    {
        // this mean injecting the current Div method inside Calculator Class
        public static double Div(this Calculator cal, int a, int b)
        {
            return (double)a/b;
        }
    }
}
