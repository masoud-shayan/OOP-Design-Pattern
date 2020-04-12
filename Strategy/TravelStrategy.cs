using System;

namespace Strategy
{
    // Context class
    public class TravelStrategy
    {
        // ********** first approach **********

        private IStrategy _strategy;
        
        public TravelStrategy(IStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }
        
        public void GetTravelTime(string source, string destination)
        {
            _strategy.GetTravelTime(source, destination);
        }


        
        
        // ********** second approach *********

        //  private IStrategy currentStrategy;
        //  private BikeStrategy _bikeStrategy = new BikeStrategy();
        //  private BusStrategy _busStrategy = new BusStrategy();
        //  private CarStrategy _carStrategy = new CarStrategy();
        //
        //
        // public TravelStrategy()
        // {
        //     currentStrategy = _bikeStrategy;
        // }
        //
        // public void GetTravelTime(string source, string destination)
        // {
        //     currentStrategy.GetTravelTime(source, destination);
        //
        //     // swap strategy with each call
        //     currentStrategy = (currentStrategy == _bikeStrategy)
        //         ? ((currentStrategy == _busStrategy) ?  (IStrategy) _carStrategy : _busStrategy )
        //         : _bikeStrategy;
        // }
    }
}