using System;

namespace Strategy
{
    public class BusStrategy : IStrategy
    {
        public void GetTravelTime(string source, string destination)
        {
           Console.WriteLine("It takes 60 minutes to reach from " + source + " to " + destination + " using Bus.") ;
        }
    }
}