using System;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.The array of numbers is unsorted. Only one number is missing");

            int[] numberArray_1 = new int[9] { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            int[] numberArray_2 = new int[9] { 7, 2, 3, 6, 5, 9, 1, 4, 8 };
            int[] numberArray_3 = new int[9] { 10, 5, 1, 2, 4, 6, 8, 3, 9 };

            var missingNumber = new NumberFinder();
            missingNumber.FindNumber(numberArray_1);
            missingNumber.FindNumber(numberArray_2);
            missingNumber.FindNumber(numberArray_3);

            Console.ReadKey();
        }
    }
}
