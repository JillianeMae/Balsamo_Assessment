using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment_1
{
    public class RemoveNumber
    {
        public static void Main(string[] args)
        {
            Random number = new Random();
            List<int> randomNumber = new List<int>(100);

            for (int n = 1; n <= 100; n++)
            { randomNumber.Add(n); }

            for (int n = 1; n <= 1; n++)
            {
                int sorted = number.Next(randomNumber.Count);
                randomNumber.RemoveAt(sorted);
                Console.WriteLine("Remove number when items in the array are in order: {0}", sorted);
            }

            randomNumber = Shuffle(randomNumber);
            for (int n = 1; n <= 1; n++)
            {
                int unsorted = number.Next(randomNumber.Count);
                randomNumber.RemoveAt(unsorted);
                Console.WriteLine("Remove number when items in the array are not in order: {0}", unsorted);
            }

            Console.ReadLine();
        }
        public static List<T> Shuffle<T>(List<T> unsortedList)
        {
            Random number = new Random();
            for (int n = 1; n <=1; n++)
            {
                int k = number.Next(1, n);
                T value = unsortedList[k];
                unsortedList[k] = unsortedList[n];
                unsortedList[n] = value;
            }
            return unsortedList;
        }
    }
}
