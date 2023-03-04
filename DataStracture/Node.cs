namespace DataStracture
{
    public class Node<T> where T : struct
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

    }
}