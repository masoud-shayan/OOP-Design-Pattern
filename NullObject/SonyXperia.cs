using System;

namespace NullObject
{
    public class SonyXperia : IMobile
    {
        public void TurnOn()
        {
            Console.WriteLine("\nSonyXperia Galaxy Turned ON!");  

        }

        public void TurnOff()
        {
            Console.WriteLine("\nSonyXperia Galaxy Turned OFF!");  
        }
    }
}