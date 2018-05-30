using System;

namespace cSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stockPricesYesterday = { 10, 7, 5, 8, 11, 9 };

            // Returns 6 (buying for $5 and selling for $11)
            
            Console.WriteLine(GetMaxProfit(stockPricesYesterday));

        }

        static int GetMaxProfit(int[] priceArray)
        {
            int lowest = priceArray[0];
            int highest = priceArray[0];

            for (int i =0; i < priceArray.Length; i++)
            {
                if (priceArray[i] < lowest)
                {
                    lowest = priceArray[i];
                }

                if(priceArray[i] > highest)
                {
                    highest = priceArray[i];
                }
            }

            return (highest - lowest);
        }
    }
}
