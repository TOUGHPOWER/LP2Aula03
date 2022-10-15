using System;
using System.Collections.Generic;

namespace HashBuildings
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

            

            buildHash.Add(b1);
            buildHash.Add(b2);
            buildHash.Add(b3);
            buildHash.Add(b4);
            buildHash.Add(b4);

            Console.WriteLine("List Starts------------------------");
            foreach (Building building in buildHash)
            {
                
                Console.WriteLine(building.ToString());
                
            }
            Console.WriteLine("List Ends------------------------");

            Console.WriteLine(b4.GetHashCode());
            Console.WriteLine(b4.Equals(b4));
            
        }


    }
}
