using System;
using System.Collections.Generic;

namespace c_topics
{
    public class Program
    {
        static void Main()
        {

            Queue<int> q=new Queue<int> ();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            Console.WriteLine("First/Front element: "+q.Dequeue());
            Console.WriteLine("After Removing the First Element Queue Size: "+q.Count);
            Console.WriteLine("New Front Element: "+q.Peek());

        }
    }
}