using System;

namespace NullObject
{
    public class AppleIPhone : IMobile
    {
        public void TurnOn()
        {
            Console.WriteLine("\nAppleIPhone Galaxy Turned ON!");  

        }

        public void TurnOff()
        {
            Console.WriteLine("\nAppleIPhone Galaxy Turned OFF!");  
        }
    }
}