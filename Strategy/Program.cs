using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // ********** use first approach *********
            new TravelStrategy(new BikeStrategy()).GetTravelTime("Tehran" , "Golestan");
            new TravelStrategy(new BusStrategy()).GetTravelTime("Tehran" , "Golestan");
            new TravelStrategy(new CarStrategy()).GetTravelTime("Tehran" , "Golestan");
            
            
            
            
            // ********** use second approach **********
             // var travel = new TravelStrategy();
             // travel.GetTravelTime("Tehran" , "Golestan");
             // travel.GetTravelTime("Tehran" , "Golestan");
             // travel.GetTravelTime("Tehran" , "Golestan");
        }
    }
}