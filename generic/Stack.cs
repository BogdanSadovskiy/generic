namespace mySpace
{
    class myStack<T>
    {
        private int size;
        Node<T>? head;
        public myStack()
        {
            size = 0;
            head = null;
        }
        public void Push(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                size++;
                return;
            }
            Node<T>? newNode = new Node<T>(item);
            newNode.pre = head;
            head = newNode;
            size++;
        }

        public void Pop()
        {
            if (size == 0)
            {
                Console.WriteLine("Noting to delete");
                return;
            }
            Console.WriteLine($"Deleted {head.item}");
            head = head.pre;
            size--;
        }

        public void PrintStack()
        {
            if (size == 0)
            {
                return;
            }
            Node<T>? tmp = head;
            Console.Write("[");
            while (tmp != null)
            {
                Console.Write($"{tmp.item}");
                tmp = tmp.pre;
                if(tmp != null) {Console.Write(" ");}
            }
            Console.WriteLine("]");
        }

        public bool isEmpty()
        {
            if (size > 0)
            {
                Console.WriteLine("Not Empty");
                return false;
            }
            Console.WriteLine("Empty");
            return true;
        }
    }
}
