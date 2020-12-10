using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindApp
{
    class Program
    {
        public static void Main()
        {
            RandomNumbers r = new RandomNumbers();
            CheckNumbers checkNumbers = new CheckNumbers();
            string testRandomNumber = r.GetRandomNumber();
            Console.WriteLine(testRandomNumber);
            Console.WriteLine("Welcom to the game. A random 4 digit number has been generated. The digits are only 1-6. Please guess the number:");
            string input = Console.ReadLine();
            string result = checkNumbers.CombineChecksToPrintValidPlusAndMinus(testRandomNumber, input);
            Console.WriteLine($"{result}");
        }
    }
}
