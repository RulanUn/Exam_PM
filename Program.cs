using System;

namespace Exam_PM
{
    class Program
    {
        static public void RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next();
            Console.WriteLine("Random number is "+randomNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            RandomNumber();
        }
    }
}
