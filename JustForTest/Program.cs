using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForTest
{
    public class Program
    {
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }

        public static bool IsTrue(int a, int b)
        {
            if(a + b < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static object IsNull(int a, int b)
        {
            if (a + b < 0)
            {
                object h = null;
                return h;
            }
            else
            {
                return false;
            }
        }


        public static void Main(string[] args)
        {
            
        }
        
    }
}
