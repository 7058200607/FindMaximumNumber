using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        
        public GenericMaximum(T[] value) 
        {
            this.value = value;
        }
        public T[] Sort(T[] value) 
        {
            Array.Sort(value);
            return value;

        }
        public T MaxValue(params T[] value) 
        {
            var sorted_value =Sort(value);
            return sorted_value[^1];
        }
        public T MaxMethod() 
        {
            var Max = MaxValue(this.value);
            return Max;
        }
        public void PrintMaxValue() 
        {
            var Max = MaxValue(this.value);
            Console.WriteLine(Max);
        }

    }
}
