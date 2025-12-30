using System;
using System.Collections.Generic;
using System.Text;

namespace LPU_Common
{
    /// <summary>
    /// Custome generic class created for dem0
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T>
    {
        
        /// <summary>
        /// Custom Generic Method 
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        public void SwapMe(ref T obj1, ref T obj2)
        {
            T temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
}
