using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    public class GenericImplementation<T>
    {
        private T _value;
        public void SetValue(T value)
        {
            _value = value;
        }
        public T GetValue()
        {
            return _value;
        }
        
    }
    public class GenericMethod
    {
        public  bool GenericMethodI<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        public  T Add<T>(T a, T b)  // 'where T : struct' means T must be a value type
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;  // Perform addition using dynamic typing
        }

    }
}
