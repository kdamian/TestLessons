using System;

namespace CodingQuizDK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int cntOfInvalidEntries = 0;
            int noOutsiderange = 0;

            PrimeArray(entries);
        }

        public static void PrimeArray(int[] entries)
        {
            for (int i = 0; i < 11; i++)
            {
                entries[i] = 1;
            }
        }

        public static int GetValue(int[] entries, ref int noOutsideRange)
        {
            int inValue;
            string outPut;
            bool moreInput = true;
            int cntOfInvalidEntries;

            Console.Clear();

            while (true)
            {

            }
        }
    }
}
