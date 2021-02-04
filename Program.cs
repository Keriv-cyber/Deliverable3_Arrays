// Author: Keri Vollenweider
// Date: 2/4/2021
// Comments: This C# Console application code dempnstrates the use of 
// arrays that exucute the size of 25 elements 

using System;

namespace Deliverable3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];
            int i;

            Console.WriteLine("Print elements of an array:");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Input 25 elements in the array:");

            foreach (int newint in array)
            {
                Console.WriteLine(array);
            }
            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < 26; i++)
            {
                Console.WriteLine("Element value = " + i);
            }

            Console.Write("\n");

        }
    }
}
