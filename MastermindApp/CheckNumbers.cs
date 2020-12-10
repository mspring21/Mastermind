using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindApp
{
    public class CheckNumbers
    {
        // I know I will be given a random number as type string (4) and a user input of type string that is 4 digits long.

        public bool IsUserInputValid(string userInput)
        {
            if(userInput.Length > 4)
            {
                return false;
            }
            for(int i = 0; i < userInput.Length; i++)
            {
                if(Char.GetNumericValue(userInput[i]) > 6)
                {
                    return false;
                }
            }
            return true;
        }


        public string CheckInputForCorrectDigitCorrectPosition(string randomNumber, string userInput)
        {
            string occurancesOfCorrectDigitCorrectPosition = "";
            // This should check for (+) scenario
            for (int i = 0; i < 4; i++)
            {
                if (randomNumber[i] == userInput[i])
                {
                    occurancesOfCorrectDigitCorrectPosition += "+";
                }
            }
            return occurancesOfCorrectDigitCorrectPosition;
        }
        public string CheckInputForCorrectDigitIncorrectPosition(string randomNumber, string userInput)
        {
            // This should check for (-) scenario
            string occuranceOfCorrectDigitIncorrectPosition = "";
            for (int i = 0; i < 4; i++)
            {
                if (randomNumber.Contains(userInput[i]) && randomNumber[i] != userInput[i])
                {
                    occuranceOfCorrectDigitIncorrectPosition += "-";
                }
            }
            return occuranceOfCorrectDigitIncorrectPosition;
        }
        public string CombineChecksToPrintValidPlusAndMinus(string randomNumber, string userInput)
        {
            // This should combine the methods above to generate the (++--) strings to let a user know what they got right or wrong. (+) first (-) second nothing if it doesn't meet either.
            if(IsUserInputValid(userInput) == true)
            {
                string plusSigns = CheckInputForCorrectDigitCorrectPosition(randomNumber, userInput);
                string minusSigns = CheckInputForCorrectDigitIncorrectPosition(randomNumber, userInput);
                string combinedValidPlusAndMinusSigns = plusSigns + minusSigns;
                return combinedValidPlusAndMinusSigns;
            }
            else
            {
                return "Sorry this input is invalid";
            }
        }
    }
}
