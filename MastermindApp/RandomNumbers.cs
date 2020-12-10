using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindApp
{
    public class RandomNumbers
    {
        public string GetRandomNumber()
        {
            Random randomNumber = new Random();
            string randomNumberAsString = "";
            for (int i = 1; i <= 4; i++)
            {
                randomNumberAsString += (randomNumber.Next(1, 7).ToString());
            }
            return randomNumberAsString;
        }
    }
}
