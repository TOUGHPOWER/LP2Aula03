using System;

namespace GameInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            IHasValue[] valueArray = new IHasValue[5];

            valueArray[0] = new MilitaryUnit(10,10,20);
            valueArray[1] = new SettlerUnit(15,5);
            valueArray[2] = new Building("Medium", 25,20);
            valueArray[3] = new Building("Large", 25,30);
            valueArray[4] = new Building("Small", 15,30);

            foreach (IHasValue valuable in valueArray)
            {
                IHasValue currentValueable = null;
                Console.WriteLine(valuable.GetType().BaseType.ToString());
                Console.WriteLine(valuable.ToString());
                Console.WriteLine(valuable.Equals(currentValueable));
                currentValueable = valuable;
                
            }

            
            
        }
    }
}
