using System;
using System.Collections.Generic;
using System.Globalization;

namespace FindingPrimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int m = 0, n = 0, T, valueFlag = 1, primeAmount = 0;
            List<int> primeList = new List<int>();
            string numberInput;

            Console.WriteLine("Provide a number of intervals that you would like to check for prime numbers:");
            numberInput = Console.ReadLine();
            T = ToInt32(numberInput);

            for (int a = 0; a < T; a++)
            {
                primeAmount = 0;
                Console.WriteLine("Please provide m:");
                numberInput = Console.ReadLine();
                m = ToInt32(numberInput);

                Console.WriteLine("Please provide n:");
                numberInput = Console.ReadLine();
                n = ToInt32(numberInput);

                if (1 <= m && m <= n && n <= 1000000000 && n - m <= 100000)
                {
                    for (int i = m; i < n; i++)
                    {
                        valueFlag = 1;
                        if (i > 1)
                        {
                            for (int j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    valueFlag = 0;
                                    break;
                                }
                            }
                            if (valueFlag == 1)
                            {
                                primeAmount++;
                            }
                        }
                    }
                    primeList.Add(primeAmount);
                }
                else
                {
                    Console.WriteLine("Incorrect data.");
                }
            }

            foreach (object o in primeList)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }

        // Method which turns string into an int32 variable.
        private static int ToInt32(string value)
        {
            if (value == null)
                return 0;
            return Int32.Parse(value, CultureInfo.CurrentCulture);
        }
    }
}

