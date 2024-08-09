using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Range<T> where T : IComparable<T>
    {

        public T MiniMumValue { get; set; }
        public T MaxiMumValue { get; set; }


        public Range(T minValue, T maxValue)
        {
            MiniMumValue = minValue;
            MaxiMumValue = maxValue;
        }

        public bool IsInRange(T Value)
        {
            return Value.CompareTo(MiniMumValue) > 0 && Value.CompareTo(MaxiMumValue) < 0;

        }
        public T Length()
        {

            dynamic min = MiniMumValue;
            dynamic max = MaxiMumValue;
            return max - min;
        }

        



    }

    
}
