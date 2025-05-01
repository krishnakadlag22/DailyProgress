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
            Console.Write("Enter Element you want to SEARCH: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr.Contains(key)?$"Element Found at Index: {Array.IndexOf(arr,key)}":"Elment Not Found");
            /*bool found=false;
            int index = 0;
            foreach(int element in arr)         //linear search
            {
                if(element == key){
                    Console.WriteLine("Elemenet Found at Index: "+index);
                    found=true;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Element not found at ay index");
                
            */

            //Sorting

            int[] sort = arr.OrderBy(a => a).ToArray();
                    
            /*for(int i = 0; i < arr.Length - 1; i++)      //Bubble Sort.
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }*/

            Console.WriteLine("\n_________Sorted Array____________: ");
            foreach(int i in sort)
            {
                Console.Write(i+" ");
            }

        }

    }
}