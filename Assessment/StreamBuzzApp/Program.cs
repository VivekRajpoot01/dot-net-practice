using System;
using System.Collections.Generic;

namespace StreamBuzzApp
{
    public class CreatorStats
    {
        public string CreatorName { get; set; }
        
        public double[] WeeklyLikes { get; set; }
    }

    public class Program
    {
        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

        
        public void RegisterCreator(CreatorStats record)
        {
            EngagementBoard.Add(record);
        }

        // Count weeks where likes >= threshold
        public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            

            foreach(var rec in records)
            {
                int count=0;
                foreach(var item in rec.WeeklyLikes){
                    if (item >= likeThreshold)
                    {
                        count++;
                    }
                    
                }
                if (count>0)
                    {
                        result.Add(rec.CreatorName,count);
                    }
            }

            return result;
        }

        // Calculate average of all weekly likes
        public double CalculateAverageLikes()
        {
            double totalLikes = 0;
            int totalCount = 0;  
            foreach(var item in EngagementBoard)
            {
                foreach(var like in item.WeeklyLikes)
                {
                    totalLikes=0;
                    totalCount++;
                }
            } 
            return totalLikes/totalCount;
        }

        static void Main()
        {
            Program obj = new Program();

            while (true)
            {
                Console.WriteLine("1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    CreatorStats cs = new CreatorStats();

                    Console.WriteLine("Enter Creator Name:");
                    cs.CreatorName = Console.ReadLine();

                    cs.WeeklyLikes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                    // TODO: Read 4 weekly likes

                    obj.RegisterCreator(cs);
                    Console.WriteLine("Creator registered successfully");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter like threshold:");
                    double threshold = double.Parse(Console.ReadLine());

                    Dictionary<string, int> output =
                        obj.GetTopPostCounts(EngagementBoard, threshold);

                    if (output.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        // TODO: Print creator name and count
                    }
                }
                else if (choice == 3)
                {
                    double avg = obj.CalculateAverageLikes();
                    Console.WriteLine($"Overall average weekly likes: {avg}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    break;
                }
            }
        }
    }
}
