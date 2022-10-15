using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityManager3
{
    public class Building: IHasValue, IComparable<IHasValue>
    {
        public string Type{get;}
        public float Area{get;}
        public float Value{get;} 

        public Building(string type, float value, float area)
        {
            Type = type;
            Area = area;
            Value = value;

        }

        public override string ToString()
        {
            //return buildingInfo + buildingArea + buildingValue;
            return string.Format("{0,-20} {1,8:f2} {2,8:f2} ",Type,Area,Value);
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

        public int CompareTo(IHasValue other)
        {
            if(other == null)
            return 1;

            if(other.Value == Value)
            {
                return 0;
            }
            else if(other.Value > Value)
            {
                return 1;
            }
            else if(other.Value < Value)
            {
                return -1;
            }

            return 1;

        }
        

        
    }
}