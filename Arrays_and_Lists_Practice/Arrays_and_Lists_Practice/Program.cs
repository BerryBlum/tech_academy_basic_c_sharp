using System;
using System.Collections.Generic;
/// <summary>
/// WELL WELL WELL THIS IS NIFTY
/// </summary>
namespace Arrays_and_Lists_Practice
{
    class Program
    {
        static void Main()
        {
            List<int> int_list = new List<int>();
            int_list.Add(6);
            int_list.Add(10);
            int_list.Remove(10);

            Console.WriteLine(int_list[0]);


            byte[] byte_array = new byte[2345678765432345];
            //int[] num_array = new int[5];
            //num_array[0] = 5;
            //num_array[1] = 2;
            //num_array[2] = 10;
            //num_array[3] = 200;
            //num_array[4] = 5000000;

            //int[] num_array_1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] num_array_2 = { 5, 2, 10, 300, 5000, 600, 2300 };

            //num_array_2[5] = 345;

            //Console.WriteLine(num_array_2[2]);
            //Console.ReadLine();

        }
    }
}
