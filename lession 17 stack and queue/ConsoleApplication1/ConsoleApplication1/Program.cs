using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));

        }

        static T Max<T>(T[] source)
            where T : IComparable
        {
            if (source.Length == 0)
                return default(T);
            var temp = source[0];
            foreach (T t in source)
            {
                if (t.CompareTo(temp) > 0) temp = t;
            }
            return temp;
        }
    }

    class Stack
    {
        List<int> list = new List<int>();
        public void Push(int value)
        {
            list.Add(value);
        }

        public int Pop()
        {
            if(list.Count == 0) throw new InvalidOperationException();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count-1);
            return result;
        }
    }

    class Queue
    {
        List<int >list = new List<int>();

        public void Enqueue(int value)
        {
            list.Add(value);
            
        }

        public int Dequeue()
        {
            if (list.Count ==0) throw new InvalidOperationException();
            var result = list[0];
            list.RemoveAt(0);
            return result;
        }
    }
}
