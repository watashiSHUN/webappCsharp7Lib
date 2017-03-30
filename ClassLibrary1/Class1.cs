using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string returnStr()
        {
            setStr(out string x);
            return x;
        }

        private static void setStr(out string x)
        {
            x = "shun";
        }
    }
}
