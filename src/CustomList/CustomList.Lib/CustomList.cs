using System;

namespace CustomList.Lib
{
    public class CustomList<T> : IDisposable
    {
        private int count = 0;
        private Node<T> root = null;


        public int Count { get { return count; } }
        public void Add(T value)
        {
            if (root == null)
            {
                root = new Node<T>(count, value);
            }
            else
            {
                var current = root;
                while (current.Child != null)
                {
                    current = current.Child;
                }
                current.Child = new Node<T>(count, value);
            }
            count++;
        }

        private T Get(int index)
        {
            var current = root;
            while (current.Index != index)
            {
                current = current.Child;
            }
            return current.Value;
        }


        private void Update(int index, T value)
        {

            var current = root;
            while (current.Index != index)
            {
                current = current.Child;
            }
            current.Value = value;

        }

        public void Dispose()
        {
            root = null;
            GC.Collect();
        }

        public T this[int i]
        {
            get
            {
                return Get(i);
            }
            set
            {
                if (i < count)
                {
                    Update(i, value);
                }
                else if (i == count)
                {
                    Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index is Out Of Range");
                }
            }
        }
    }

    public class Node<T>
    {
        public readonly int Index;
        public T Value { get; set; }
        public Node<T> Child { get; set; } = null;

        public Node(int index, T value)
        {
            this.Index = index;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"Index: {Index}, Value: '{Value}'";
        }

    }
}
