using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            int sum = 0;
            if (numbers.Length == 0)
                return 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                    sum += num;
                else
                    sum -= num;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            int length = str1.Length;
            if (str2.Length < length)
                length = str2.Length;
            if (str3.Length < length)
                length = str3.Length;
            if (str4.Length < length)
                length = str4.Length;

            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();
            int shortest = number1;

            if (number2 < shortest)
                shortest = number2;
            if (number3 < shortest)
                shortest = number3;
            if (number4 < shortest)
                shortest = number4;

            return shortest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
                return false;
            return true;
        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            if (string.IsNullOrEmpty(input))
                return false;
            return Double.TryParse(input, out var result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();
            int nullVals = 0;
            int filledVals = 0;

            foreach(var ob in objs)
            {
                if (ob == null)
                    nullVals++;
                else
                    filledVals++;
            }

            if (nullVals > filledVals)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();
            double evenAverage = 0;
            int evens = 0;

            if (numbers == null)
                return 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenAverage += numbers[i];
                    evens++;
                }
            }

            if (evens != 0)
                return evenAverage / evens;
            return 0;
        }

        public int Factorial(int number)
        {
            if (number<0)
                throw new ArgumentOutOfRangeException();
            
            int factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial = factorial * i;
            return factorial;
        }
    }
}
