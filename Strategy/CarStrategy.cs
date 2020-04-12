using System;

namespace Strategy
{
    public class CarStrategy : IStrategy
    {
        public void GetTravelTime(string source, string destination)
        {
            Console.WriteLine("It takes 40 minutes to reach from " + source + " to " + destination + " using Car.");
        }
    }
}