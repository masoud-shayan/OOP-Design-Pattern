using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Going to build Concrete Wall House"); 
            House house = new ConcreteWallHouse();
            house.BuildHouse();
            
            
            Console.WriteLine("Concrete Wall House constructed successfully"); 

 
            Console.WriteLine("");
 
            Console.WriteLine("********************");
 
            Console.WriteLine("Going to build Glass Wall House");
 
            house = new GlassWallHouse();
            house.BuildHouse();
 
            Console.WriteLine("Glass Wall House constructed successfully");
        }
    }
}