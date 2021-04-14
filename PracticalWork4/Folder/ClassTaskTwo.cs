using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4.Folder
{
    class ClassTaskTwo
    {
        public static int SumOfNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
