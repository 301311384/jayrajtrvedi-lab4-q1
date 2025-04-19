using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jayrajtrvedi_lab4_q1
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            return char.IsUpper(str[0]);
        }
    }
}
