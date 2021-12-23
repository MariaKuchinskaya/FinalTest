using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mas1 = new List<int>();
            mas1.Add(14);
            mas1.Add(5);
            mas1.Add(1923);

            var orderedNumbers = (from item in mas1
                                 orderby item
                                 select item).ToArray();

            var middleIndex = Math.Ceiling((double)orderedNumbers.Length / 2) - 1;

            var result = new List<int>();

            for (int i = orderedNumbers.Length - 1; i >= middleIndex; i--)
            {
                result.Add(orderedNumbers[i] * orderedNumbers[i]);
            }



        }
    }
}
