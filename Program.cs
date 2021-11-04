using System;

namespace IfStatementsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTall = true;
            bool isMale = false;

            if (isTall && isMale)
            {
                Console.WriteLine("You are tall and male");
            }
            else if (isTall && !isMale)
            {
                Console.WriteLine("Is tall and not male");
            }
            else
            {
                Console.WriteLine("You are not tall");
            }

            Console.ReadLine();







        }
    }
}
