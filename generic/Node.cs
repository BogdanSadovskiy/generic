

namespace mySpace
{
    internal class Node<T>
    {
        public Node<T>? pre { get; set; }
        public T item { get; }
        public Node(T t)
        {
            this.item = t;
            pre = null;
        }
    }
}

