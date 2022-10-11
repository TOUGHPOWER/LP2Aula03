using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces
{
    public class Building: IHasValue
    {
        public string Type{get;}
        public float Area{get;}
        public float Value{get;} 

        public Building(string type, float area, float value)
        {
            Type = type;
            Area = area;
            Value = value;

        }

        public string ToString()
        {
            string buildingInfo = string.Format("{0,20} ",Type);
            string buildingArea = string.Format("{0.-8,f2} ",Area);
            string buildingValue = string.Format("{0.-8,f2} ",Value);
            return buildingInfo + buildingArea + buildingValue;
        }

        public bool Equals(IHasValue other)
        {
            if(other == null)
            {
                return false;
            }

            if (other.Value == this.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}