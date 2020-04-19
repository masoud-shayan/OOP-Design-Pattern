using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Using First_Example
            
            
            // IComponent component;
            // CompositeComponent composite1 = new CompositeComponent();
            //
            // composite1.AddComponent(new Leaf());
            // composite1.AddComponent(new SecondTypeOfLeaf());
            // composite1.AddComponent(new ThirdLeafType());
            //
            //
            // component = composite1;
            // component.SomeThing();
            
            
            
            
            
            
            // Using Second_Example
            
            

            // from bottom of tree
            
            // add a new leafs to total box2
            Box box2 = new Box();
            box2.AddProduct(new Product("product4" , 1000));
            box2.AddProduct(new Product("product5" , 1000));
            box2.AddProduct(new Product("product6" , 1000));
            Console.WriteLine($"the total number of box2 is: {box2.GetTotalPrice()}");
            Console.WriteLine($"the total name of box2 is: {box2.GetTotalName()}");
            
            
            // add a new leafs to total box1
            Box box1 = new Box();
            box1.AddProduct(new Product("product2" , 1000));
            box1.AddProduct(new Product("product3" , 1000));
            box1.AddProduct(box2); // box1 = product2 + product3 + box2
            Console.WriteLine($"the total number of box1 is: {box1.GetTotalPrice()}");
            Console.WriteLine($"the total name of box1 is: {box1.GetTotalName()}");


            
            // the root of the tree
            // add a new leaf to total totalBox
            Box totalBox = new Box();
            totalBox.AddProduct(new Product("product1" , 1000));
            totalBox.AddProduct(box1); // // totalBox = product1 +box1 => product1 + product2 + product3 + product4 + product5 + product6
            Console.WriteLine($"the total number of totalBox is: {totalBox.GetTotalPrice()}");
            Console.WriteLine($"the total name of totalBox is: {totalBox.GetTotalName()}");

            
        }
    }
}