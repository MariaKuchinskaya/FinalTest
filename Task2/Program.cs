using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 1;
            var res = value.ToStringValue();
            Console.WriteLine(res);
        }
    }

    public static class StringExtension
    {
        public static string ToStringValue(this int value)
        {
            return value.ToString();
        }
    }
}
