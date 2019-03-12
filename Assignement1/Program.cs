using System;
using System.Linq;

namespace Assignement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double result = getSeriesResult(n);
            Console.WriteLine("The result is " + result);
            Console.ReadLine();
            int[] a = new int[] { 1, 3, 5, 7, 9, 1, 2, 1 };
            computeFrequency(a);
            printPrimeNumbers(9, 37);
            printTriangle(7);
            Console.ReadLine();
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                //int[] frequency;
                int[] frequency = new int[a.Max() + 1];
                //frequency = new int[a.Max() + 1];

                for (int i = 0; i < frequency.Length; i++)
                {
                    frequency[i] = 0;
                }

                for (int i = 0; i < a.Length; i++)
                {
                    frequency[a[i]] = frequency[a[i]] + 1;
                }


                Console.WriteLine("Number	Frequency");
                for (int i = 0; i < frequency.Length; i++)
                {
                    if (frequency[i] > 0)
                    {
                        Console.WriteLine(i + "    	" + frequency[i]);
                    }
                }
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured while computing computeFrequency()" + ex.Message);

                Console.ReadLine();
            }

        }




        public static int getFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * getFactorial(n - 1);
            }
        }

        public static double getSeriesResult(int n)
        {
            double seriesResult = 0;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        double temp = (double)getFactorial(i) / (i + 1);
                        seriesResult -= Convert.ToDouble(temp.ToString("N3"));
                        //seriesResult = seriesResult - getFactorial(i) / (i + 1); ;
                    }
                    else
                    {
                        double temp = (double)getFactorial(i) / (i + 1);
                        seriesResult += Convert.ToDouble(temp.ToString("N3"));
                        //seriesResult += (double)getFactorial(i) / (i + 1);

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return seriesResult;
        }


        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {
                    if (!divisibleByOtherNumbers(i))
                    {
                        Console.Write(i);
                        if (y - i != 2 && y != i)
                        {
                            Console.Write(",");
                        }
                    }
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static bool divisibleByOtherNumbers(int number)
        {
            if (number == 0 || number == 1)
            {
                return true;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int counter = 0;
                for (int i = n; i <= n * 2 -1; i++)
                {
                    for (int y = 1; y <= i-(counter*2+1); y++)
                    {
                        Console.Write(" ");
                    }
                    for(int z =1;z<=counter*2+1;z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    counter++;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }




    }
}
