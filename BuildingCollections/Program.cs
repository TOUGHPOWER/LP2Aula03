using System;
using System.Collections.Generic;

namespace BuildingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildList = new List<Building>();
            Stack<Building> buildStack = new Stack<Building>();
            Queue<Building> buildQueue = new Queue<Building>();
            HashSet<Building> buildHash = new HashSet<Building>();

            Building b1 = new Building("Large", 50, 20);
            Building b2 = new Building("Small", 10, 10); 
            Building b3 = new Building("Medium", 20, 15); 
            Building b4 = new Building("Special", 70, 30);

            buildList.Add(b1);
            buildList.Add(b2);
            buildList.Add(b3);
            buildList.Add(b4);
            buildList.Add(b4);

            buildStack.Push(b1);
            buildStack.Push(b2);
            buildStack.Push(b3);
            buildStack.Push(b4);
            buildStack.Push(b4);

            buildQueue.Enqueue(b1);
            buildQueue.Enqueue(b2);
            buildQueue.Enqueue(b3);
            buildQueue.Enqueue(b4);
            buildQueue.Enqueue(b4);

            buildHash.Add(b1);
            buildHash.Add(b2);
            buildHash.Add(b3);
            buildHash.Add(b4);
            buildHash.Add(b4);

            Console.WriteLine("List Starts------------------------");
            foreach (Building building in buildList)
            {
                
                Console.WriteLine(building.ToString());
                
            }
            Console.WriteLine("List Ends------------------------");
            Console.WriteLine();

            Console.WriteLine("Stack Starts------------------------");
            foreach (Building building in buildStack)
            {
                
                Console.WriteLine(building.ToString());
                
            }
            Console.WriteLine("Stack Ends------------------------");
            Console.WriteLine();

            Console.WriteLine("Queue Starts------------------------");
            foreach (Building building in buildQueue)
            {
                
                Console.WriteLine(building.ToString());
                
            }
            Console.WriteLine("Queue Ends------------------------");
            Console.WriteLine();

            Console.WriteLine("HashSet Starts------------------------");
            foreach (Building building in buildHash)
            {
                Console.WriteLine(building.ToString());
            }
            Console.WriteLine("HashSet Ends------------------------");
            Console.WriteLine();     

        }
    }
}
