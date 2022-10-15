using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityManager3
{
    public interface IHasValue : IEquatable<IHasValue>
    {
        float Value{get;}

        
    }
}