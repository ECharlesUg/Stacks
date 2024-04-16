using System.Collections;
namespace Stacks
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Stack<string> var = new Stack<string>();
            var.Push("e");
            var.Push("d");
            var.Push("c");
            var.Push("b");
            var.Push("a");

            PrintStack(stack);
            PrintStack(var);
            ReverseString("Hello");
        }

        public static void PrintStack<T> (Stack<T> stacks)
        {
            while(stacks.Count > 0)
            {
                Console.WriteLine(stacks.Pop());
            }
        }

        public static void ReverseString(string str)
        {
            Stack<string> strings = new Stack<string>();
            for (int i = 0; i < str.Length; i++)
            {
                string num = str[i].ToString();
                strings.Push(num);
            }
            string newStr = "";

            while(strings.Count > 0)
            {
                newStr = newStr + strings.Pop();
            }
            Console.WriteLine(newStr); 
        }
    }
}