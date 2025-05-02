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
            for(int i = 0; i < size-1; i++)
            {
                int minimum = i;    //Selection Sort
                for(int j=i+1;j<size; j++)
                {
                    if (arr[j] < arr[minimum])
                    {
                        minimum = j;
                    }

                    if (minimum != 1)
                    {
                        int temp = arr[i];
                        arr[i]=arr[minimum];
                        arr[minimum] = temp;
                    }
                }
            }


            Console.WriteLine("\n-----Sorted Array-----");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }

    }
}