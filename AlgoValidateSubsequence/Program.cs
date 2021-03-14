using System;
using System.Collections.Generic;

namespace AlgoValidateSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int> { 22, 25, 6 };

            bool result = IsValidSubSequence(array, sequence);
            if (result)
                Console.WriteLine("Sequence is a subsequence of array");
            else
                Console.WriteLine("Sequence is NOT a subsequence of array");
        }

        public static bool IsValidSubSequence(List<int> array, List<int> sequence)
        {
            int index = 0;

            foreach(int num in array)
            {
                if (num == sequence[index])
                    index++;

                if (index == sequence.Count)
                    return true;
            }

            return false;
        }
    }
}
