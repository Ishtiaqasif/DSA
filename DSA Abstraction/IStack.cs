namespace DSA_Abstraction
{
    public interface IStack<T> where T : struct
    {
        void Push(T item);

        void Pop();

        bool IsFull();

        T Peak();
    }
}