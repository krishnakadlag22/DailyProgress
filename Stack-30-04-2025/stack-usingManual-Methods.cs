using System;


namespace c_topics
{
    public class Program
    {
        static int[] stack = new int[100];
        static int top = -1;
        static void Main()
        {
            //bool in= true;
            while (true){
                Console.WriteLine("---------Stack MEnu---------");
                Console.WriteLine("\n1.Push\n2.Pop\n3.Peek\n4.Display\n5.Exit");
                Console.WriteLine("Choose the Choice: ");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element You want to push: ");
                        int val = int.Parse(Console.ReadLine());
                        Push(val);
                        break;
                    case 2:
                        Pop();
                        break;
                    case 3:
                        Peek();
                        break;
                    case 4:
                        Display();
                        break;
                    case 5:
                        Console.WriteLine("Exiting.....");
                        return;
                }


            
            }
        }
        static void Push(int val)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack Overflow!! Cannot Push");
            }
            top++;
            stack[top] = val;
            Console.WriteLine("Pushed!");
        }
        static void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack UNderFlow! Stack is Empty cannot Pop!");
            }
            Console.WriteLine("Popped VAlue: "+stack[top]);
            top--;
        }
        static void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Peek Element: " + stack[top]);
        }
        static void Display()
        {
            Console.WriteLine("\nStack Element : ");
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]+" ");
            }
        }
    }

}
