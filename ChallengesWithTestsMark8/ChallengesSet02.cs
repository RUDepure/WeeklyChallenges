using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            return vals.Count() % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();
            if (numbers.Any() == false || numbers == null)
                return 0;
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            if (str1.Length > str2.Length)
                return str2.Length;
            else
                return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
                return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
                return 0;
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
            if (number <= 0)
                return 0;
            else
                return number / 2;
        }
    }
}
