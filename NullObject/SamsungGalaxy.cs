﻿using System;

namespace NullObject
{
    public class SamsungGalaxy : IMobile
    {
        public void TurnOff()  
        {  
            Console.WriteLine("\nSamsung Galaxy Turned OFF!");  
        }  
  
        public void TurnOn()  
        {  
            Console.WriteLine("\nSamsung Galaxy Turned ON!");  
        }
    }
}