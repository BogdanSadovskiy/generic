



namespace mySpace
{
    public class myProgram
    {
        public static void Main(string[] args)
        {
            myStack<int> stack = new myStack<int>();
            Console.WriteLine("Nothing");
            stack.PrintStack();
            Console.WriteLine("-----------------------");
            
            Console.WriteLine("Adding 1");
            stack.Push(1);
            stack.PrintStack();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Adding 2");
            stack.Push(2);
            stack.PrintStack();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Deleting last (2)");
            stack.Pop();
            stack.PrintStack();
            Console.WriteLine("-----------------------");

        }
    }
}