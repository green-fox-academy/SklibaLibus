using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SumTestProject1
{
    public class Sum
    {
        public int SumArray(List<int> numbers)
        {
            if (numbers == null) return 0;
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
            /* 
             using forloop
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
            */
        }
    }
}
