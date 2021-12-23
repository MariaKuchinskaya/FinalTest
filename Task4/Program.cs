using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var someClass = new SomeClass();
            someClass.Notify += DisplayMessage;

            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
            someClass.SomePublicMethod();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
