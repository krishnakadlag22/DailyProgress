using System;
using System.Collections.Generic;

namespace c_topics
{
    public class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();  // Built-in stack
            bool inThese = true;

            while (inThese)
            {
                Console.WriteLine("\n-------- Menu -----------");
                Console.WriteLine("\n1. Push\n2. Pop\n3. Peek\n4. Count\n5. Stack Empty?\n6. Exit");
                
                Console.Write("Enter Choice (1-6): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to push: ");
                        int addItem = Convert.ToInt32(Console.ReadLine());
                        stack.Push(addItem);
                        Console.WriteLine("Pushed: " + addItem);
                        break;

                    case 2:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        else
                        {
                            int popped = stack.Pop();
                            Console.WriteLine("Popped: " + popped);
                        }
                        break;

                    case 3:
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        else
                        {
                            Console.WriteLine("Top element: " + stack.Peek());
                        }
                        break;

                    case 4:
                        Console.WriteLine("Stack Count: " + stack.Count);
                        break;

                    case 5:
                        Console.WriteLine(stack.Count == 0 ? "Stack is Empty" : "Stack is Not Empty");
                        break;

                    case 6:
                        inThese = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice! Please try (1-6)");
                        break;
                }
            }
        }
    }
}
