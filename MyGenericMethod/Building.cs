using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericMethod
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

        public override string ToString()
        {
            //return buildingInfo + buildingArea + buildingValue;
            return GetType() + string.Format("{0,20} {1,-8:f2} {2,-8:f2} ",Type,Area,Value);
        }

        public bool Equals(IHasValue other)
        {
            if(other == null)
            {
                return false;
            }

            if (other.Value == Value)
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