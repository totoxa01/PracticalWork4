using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4.Folder
{
    class ClassTaskFour
    {
        public static ulong Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
