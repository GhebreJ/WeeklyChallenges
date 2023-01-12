using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if(numbers.Length == 0 || numbers == null) return 0;
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x%2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return (new List<string> { str1, str2, str3,str4 }).Min(str => str.Length) ;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return (new List<int> {number1, number2, number3, number4}).Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var tri = new List<int> { sideLength1, sideLength2, sideLength3 }.OrderBy(x => x);
            return (tri.ElementAt(0) + tri.ElementAt(1) > tri.ElementAt(2));
        }

        public bool IsStringANumber(string input)
        {
            double num;
            return double.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs== null || objs.Length == 0) return false;
            return (objs.Where(o => o == null).Count() > objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Where(x => x % 2 == 0).Count() == 0) return 0;
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
           if(number == 0) return 1;
           return number * Factorial(number - 1);
        }

    }
}
