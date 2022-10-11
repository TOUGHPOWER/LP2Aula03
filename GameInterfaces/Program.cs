using System;

namespace GameInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasValue[] valueArray = new IHasValue[5];

            valueArray[0] = new MilitaryUnit(10,10,20);
            valueArray[1] = new MilitaryUnit(5,20,30);
            valueArray[2] = new SettlerUnit(15,5);
            valueArray[3] = new Building("Large", 25,50);
            valueArray[4] = new Building("Small", 15,30);

            foreach (IHasValue valuable in valueArray)
            {
                Console.WriteLine(valuable.GetType().ToString());
                Console.WriteLine(valuable.ToString());
                Console.WriteLine();
                
            }

            
        }
    }
}
