using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PriorityQueue<Char> priorityQueue = new PriorityQueue<char>();

            priorityQueue.Enqueue(1, 'A');
            priorityQueue.Enqueue(2, 'B');
            priorityQueue.Enqueue(1, 'C');

            Console.WriteLine(priorityQueue.Count);
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
        }
    }
}
