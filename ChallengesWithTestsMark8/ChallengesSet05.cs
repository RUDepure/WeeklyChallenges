using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //throw new NotImplementedException();

            return startNumber + (n - (startNumber % n));
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();

            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                    businesses[i].Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();
            int sumNumbers = 0;

            if (numbers == null)
                return 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i != numbers.Length-1)
                {
                    sumNumbers += numbers[i + 1];
                }
            }

            return sumNumbers;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();
            string sentence = "";

            foreach (var word in words)
                sentence = sentence + " " + word;

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
