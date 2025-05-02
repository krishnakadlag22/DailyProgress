using System;
using System.Collections.Generic;

namespace c_topics
{
    public class Program
    {
        static void Main()
        {
            Stack<int> s = new Stack<int>();
            s.Push( 1 );
            s.Push( 2 );
            s.Push(3);
            s.Push( 4 );

            Console.WriteLine("Top Element in STack: "+s.Peek());
            Console.WriteLine("Remove Element: "+s.Pop());
            Console.WriteLine("new Elements at TOP: "+s.Peek());
            Console.WriteLine("Stack Size after POP: "+s.Count);
            //Console.WriteLine();
        }
    }
}
