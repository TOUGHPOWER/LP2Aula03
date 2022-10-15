using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityManager4
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        float Value{get;}

        
    }
}