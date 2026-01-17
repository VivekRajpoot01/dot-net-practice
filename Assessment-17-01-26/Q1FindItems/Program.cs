using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1FindItems
{
    public class Program
    {
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>()
        {
            { "Chair", 450 },
            { "Table", 990 },
            { "Cup", 4563 },
            { "Plate", 798645 },
            { "Radio", 9652 }
        };

        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine("=================Program to find item===========");

            Console.Write("Enter sold count to search: ");
            if (long.TryParse(Console.ReadLine(), out long count))
            {
                var result = p.FindItemDetails(count);
                Console.WriteLine("\nResult:");
                if (result.Count ==0)
                {
                    Console.WriteLine("No items found = " + count);
                }
                else
                {
                    foreach (var k in result)
                        Console.WriteLine($"{k.Key}: {k.Value}");
                }
            }

            var minMax = p.FindMinAndMaxSoldItem();

            Console.WriteLine($"\nMin item : {minMax[0]}");
            Console.WriteLine($"Max item : {minMax[1]}");

            Console.WriteLine("\nSorted by count:");
            var sorted = p.SortByCount();
            foreach (var k in sorted)
            {
                Console.WriteLine($"{k.Key} {k.Value}");
            }
        }

        public SortedDictionary<string, long> FindItemDetails(long soldCount)
        {
            SortedDictionary<string, long> result = new SortedDictionary<string, long>();
            if (soldCount < 0)
            {
                Console.WriteLine("Invalid sold count");
                return result;
			}
			
            foreach (var item in itemDetails)
            {
                if (item.Value == soldCount)
                {
                    result.Add(item.Key, item.Value);
                }
            }

            return result;
        }

        public List<string> FindMinAndMaxSoldItem()
        {
            long minSoldItems = itemDetails.Values.Min();
            long maxSoldItems = itemDetails.Values.Max();

            List<string> res = new List<string>();

            string minItemName = itemDetails.Where(k => k.Value == minSoldItems)
                                            .Select(k => k.Key).First();

            string maxItemName = itemDetails.Where(k => k.Value == maxSoldItems)
                                            .Select(k => k.Key).First();

            res.Add(minItemName);
            res.Add(maxItemName);

            return res;
        }

        public Dictionary<string, long> SortByCount()
        {
            Dictionary<string, long> res = new Dictionary<string, long>();

            foreach (var item in itemDetails.OrderBy(v => v.Value))
            {
                res.Add(item.Key, item.Value);
            }

            return res;
        }
    }
}