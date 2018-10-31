using System;
using System.Collections.Generic;

/// <summary>
/// NIFTY
/// Create an array of string, an array of integers and a list of strings.
/// ask the user to choose an index, if it exists the value is written to console
/// and marked as having been answered
/// if not continues to next prompt. Process repeats until all prompts have been
/// successfully answered with real indexes with each iteration through only asking
/// about the indexes that were not real.
/// </summary>
namespace Lists_Strings_Excercise
{
    class Program
    {
        static void Main()
        {
            string[] array_string = {"One of ","these things "," BANANA ","is not ","like ","the others!" }; //string array population
            int[] array_int = { 0, 2, 5, 100, 76, 42, 0 }; //int array population
            List<string> string_list = new List<string>(); //initialize string list
            string_list.Add("Bananas "); //items to add to string list
            string_list.Add("Are ");
            string_list.Add("Tasty!");
            bool string_check = false; //been answered?
            bool int_check = false; //been answered?
            bool choice = false; // have all been answered? determines end of loop
            bool list_check = false; //been answered


            do
            {
                if (string_check != true) //string array
                {
                    Console.WriteLine("Please Select an index for strings array");
                    int string_choice = Convert.ToInt32(Console.ReadLine());
                    if (string_choice < array_string.Length)
                    {
                        Console.WriteLine("The chosen index has value: " + array_string[string_choice] + "\n");
                        string_check = true;
                    }
                    else
                    {
                        Console.WriteLine("That index does not exist, next prompt \n");
                    }
                }
                if (int_check != true) //int array
                {
                    Console.WriteLine("Please select an index for the integer array");
                    int int_choice = Convert.ToInt32(Console.ReadLine());

                    if (int_choice < array_int.Length)
                    {
                        Console.WriteLine("The chosen index has value: " + array_int[int_choice] + "\n");
                        int_check = true;
                    }
                    else
                    {
                        Console.WriteLine("Your index does not exist, next prompt \n");
                    }  
                }
                if (list_check != true) //list
                {
                    Console.WriteLine("Please select an index for the list");
                    int list_choice = Convert.ToInt32(Console.ReadLine());

                    if (list_choice < string_list.Count)
                    {
                        Console.WriteLine("The chosen index has value: " + string_list[list_choice] + "\n");
                        list_check = true;
                    }
                    else
                    {
                        Console.WriteLine("Your index does not exist");
                    }
                }
                if (string_check && int_check && list_check) //all answered then modifies choice to end
                {
                    choice = true;
                }
                //tells user that at least one index chosen does not exist and that program reiterates to choose other indexes
                else if (!string_check || !int_check || !list_check) 
                {
                    Console.WriteLine("Returning to requery missed indexes \n");
                }
            } while (choice == false);
            Console.WriteLine("All prompts have been answered");
            Console.ReadLine();
           
        }
    }
}
