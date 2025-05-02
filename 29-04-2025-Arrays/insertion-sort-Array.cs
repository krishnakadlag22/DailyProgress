
using System;
using System.Linq;

namespace C_topics
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of Elements u want: ");
            int size=Convert.ToInt32(Console.ReadLine());

            int[] arr=new int[size];
            

            Console.WriteLine($"Enter {size} Elments: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Element {(i+1)} is: ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            
            //Sorting
            //Insertion Sort
            for(int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;


            }


            Console.WriteLine("\n-----Sorted Array-----");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }

    }
}