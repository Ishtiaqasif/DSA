using DSA_Abstraction;

namespace DataStracture
{
    public class Stack<T> : IStack<T> where T : struct
    {
        private readonly LinkedList<T> _linkedList;
        private readonly int _capacity;
        private int _size;

        public Stack(int capacity)
        {
            _capacity = capacity;
            _size = 1;
        }

        public bool IsFull()
        {
            return _capacity == _size;
        }

        public T Peak()
        {
            throw new NotImplementedException();
        }

        public void Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }
    }
}