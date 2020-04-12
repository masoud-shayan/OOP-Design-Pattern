using System;

namespace Strategy
{
    public class BikeStrategy : IStrategy
    {
        public void GetTravelTime(string source, string destination)
        {
            Console.WriteLine("It takes 25 minutes to reach from " + source + " to " + destination + " using Bike.");
        }
    }
}