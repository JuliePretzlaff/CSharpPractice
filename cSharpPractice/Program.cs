using System;

namespace cSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stockPricesYesterday = { 13, 7, 5, 8, 11, 9 };

            // Returns 6 (buying for $5 and selling for $11)

            Console.WriteLine("The max profit possible is: " + GetMaxProfit(stockPricesYesterday));

        }

        static int GetMaxProfit(int[] priceArray)
        {
            int lowest = priceArray[0];
            int highest = 0;
            int indexOfLowest=0;

            for (int i = 0; i < priceArray.Length; i++)
            {
                if (priceArray[i] < lowest)
                {
                    lowest = priceArray[i];
                    indexOfLowest = i;
                }
            }
            Console.WriteLine(indexOfLowest);
            for (int k = (indexOfLowest); k < priceArray.Length; k++)
            {
                if (priceArray[k] > highest)
                {
                    highest = priceArray[k];
                }
            }
            return (highest - lowest);
        }
    }
}
