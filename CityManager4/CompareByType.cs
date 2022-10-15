using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityManager4
{
    public class CompareByType : IComparer<Building>
    {
        public bool Check { get; }

        public CompareByType()
        {
        }
        public CompareByType(bool check)
        {
            Check = check;
        }

        public int Compare(Building x, Building y)
        {
            if (Check == true)
            {
                if (x.Type.CompareTo(y.Type) == 0)
                {
                    return 0;
                }
                else if (x.Type.CompareTo(y.Type) > 0)
                {
                    return 1;
                }
                else if (x.Type.CompareTo(y.Type) < 0)
                {
                    return -1;
                }
            }
            else if (Check == true)
            {
                if (x.Type.CompareTo(y.Type) == 0)
                {
                    return 0;
                }
                else if (x.Type.CompareTo(y.Type) > 0)
                {
                    return -1;
                }
                else if (x.Type.CompareTo(y.Type) < 0)
                {
                    return 1;
                }
            }

            if (x.CompareTo(y) == 0)
                {
                    return 0;
                }
                else if (x.CompareTo(y) > 0)
                {
                    return 1;
                }
                else if (x.CompareTo(y) < 0)
                {
                    return -1;
                }

            return 1;
        }
    }
}