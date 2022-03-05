namespace CustomList.Lib
{
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
