using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            bool checkFalse = false;

            foreach (var value in vals)
            {
                if (value == false)
                    checkFalse = true;
            }

            return checkFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();
            int countOdd = 0;
            if (numbers == null)
                return false;
            foreach (var num in numbers)
                    countOdd += num;
            if ((countOdd % 2) != 0)
                return true;
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            int[] oddsBelow100 = new int[50];
            int oddIndex = 0;
            for (int i = 1; i < 100; i+=2)
            {
                if ((i % 2) != 0)
                {
                    oddsBelow100[oddIndex] = i;
                    oddIndex++;
                }
            }
            return oddsBelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
