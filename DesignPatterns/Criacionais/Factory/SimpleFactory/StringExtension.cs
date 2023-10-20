using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class StringExtension
    {
        public static bool IsEnum<T>(this string value)
        {
            try
            {
                var via = (T)Enum.Parse(typeof(T), value, true);
                return true;
            }
            catch { }

            return false;
        }

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        
    }
}