using System.Collections;

namespace DataStracture
{
    public class LinkedList<T> : IEnumerable where T : struct
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            
        }

        public LinkedList(T initialData)
        {
            Head = new Node<T>()
            {
                Data = initialData,
                Next = null,
            };
        }

        public void AddBegining(T item)
        {
            var newNode = new Node<T>()
            {
                Data = item,
                Next = Head,
            };

            Head = newNode;
            Count++;
        }

        public void AddEnd(T item)
        {
            Node<T> currentNode = Head;
            Node<T> tail;

            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
            }

            tail = currentNode;

            var newNode = new Node<T>()
            {
                Data = item,
                Next = null,
            };

            tail.Next = newNode;

            Count++;
        }

        public void AddAt(T item, int position) 
        {
            if (position -1 > Count)
            {
                throw new IndexOutOfRangeException();
            }

            var newNode = new Node<T>() { Data= item, Next = null, };

        }

        public IEnumerator GetEnumerator()
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                var data = currentNode.Data;

                currentNode = currentNode.Next;

                yield return data;
            }
        }
    }
}