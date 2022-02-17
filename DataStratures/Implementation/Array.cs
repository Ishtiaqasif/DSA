using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStratures.Abstructions;
namespace DataStratures.Implementation
{
    public class Array<T> : IArray<T> where T : class
    {
        private T[] _array;
        private int _length = 0;
        private int _capacity = 0;

        public Array(int capacity)
        {

            if (capacity < 0) throw new ArgumentOutOfRangeException($"Illegal Capacity: ${capacity} ");
            _array = new T[capacity];
        }

        public void Add(T value)
        {
            _array[_length++] = value;
        }

        public void Clear()
        {
            for (int i = 0; i < _capacity; i++)
            {
                _array[i] = null;
            }
            _length = 0;
        }

        public bool Contains(object T)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            return _array[index];
        }

        public bool IsEmpty() => Size() == 0;

        public bool Remove(object T)
        {
            throw new NotImplementedException();
        }

        public T RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Set(int index, T value)
        {
            
        }

        public int Size() => _length;
    }
}
