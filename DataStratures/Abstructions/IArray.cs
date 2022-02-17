using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStratures.Abstructions
{
    public interface IArray<T> where T: class
    {
        int Size();
        bool IsEmpty();
        T Get(int index);
        void Set(int index, T value);
        void Clear();
        void Add(T value); 
        T RemoveAt(int index);
        bool Remove(object T);
        bool Contains(object T); 
    }
}
