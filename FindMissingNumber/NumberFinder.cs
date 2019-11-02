using System;

namespace FindMissingNumber
{
    class NumberFinder
    {
        public void FindNumber(int[] myArray)
        {
            int amountOfNumbers = myArray.Length;
            var total = (amountOfNumbers + 1) * (amountOfNumbers + 2) / 2;
            for (int i = 0; i < amountOfNumbers; i++)
                total -= myArray[i];

            Console.WriteLine(total);
        }
    }
}
