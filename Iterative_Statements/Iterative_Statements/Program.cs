using System;
using System.Collections.Generic;

/// <summary>
/// Problem 1: creates an array of strings, receive input from user, add the input to each string in the array and then print each index
/// Problem 2: infinite loop and then fix it!
/// </summary>
namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1");
            int count_int = 0;
            string[] array_string_0 = { "This ", "Is ", "My ", "Array ", "Of ", "STRINGS " };
            Console.WriteLine("PLease give me some delicious text!");
            string user_input_0 = Console.ReadLine();
            for (int i = 0; i < array_string_0.Length; i++)
            {
                array_string_0[i] += user_input_0;
            }
            for (int j = 0; j < array_string_0.Length; j++)
            {
                Console.WriteLine(array_string_0[j]);
            }
            Console.WriteLine("Problem 2 and 3, press enter to continue. . . .");
            Console.ReadLine();
            //PROBELM 2 / 3 will print 100 bananas instead of infinite
            for (int i = 0; i < 100; i++) // changed from i >= 0 to I < 100
            {
                Console.WriteLine("BANANA");
            }
            Console.WriteLine("Problem 4, press enter to continue. . . .");
            Console.ReadLine();
            //Problem 4 will print from 0 to 99
            do
            {
                Console.WriteLine(count_int);
                count_int++;
            } while (count_int < 100); // must be a variable that is initialized before the loop

            //Problem 5 counts down from 100 to 0 and prints the answer to everything on the way.
            Console.WriteLine("Problem 5, press enter to continue. . . .");
            Console.ReadLine();
            while (count_int >= 0)
            {
                if (count_int == 42)
                {
                    Console.WriteLine("Ah " + count_int + ", the answer to life the universe and everything!");
                    count_int--;
                }
                else
                {
                    Console.WriteLine(count_int);
                    count_int--;
                }
            }
            Console.WriteLine("Problem 6 / 7 / 8, press enter to continue. . . .");
            Console.ReadLine();

            //Problem 6 LIST OF STRINGS /7 loops while invalid input /8 built into the program to end when a match has been made

            List<string> unique_strings = new List<string> { "Mythic", "Dungeon", "Invitational", "Kjell's", "Angels", "For", "The", "Win!!" };
            Console.WriteLine("Please press\n '1' to search for the index of \"Mythic\" \n '2' to search for the index of \"Dungeon\"" +
                "\n '3' to search for the index of \"Invitational\"\n '4' to search for the index of \"Kjell's\"\n '4' to search for the index of \"Angels\"" +
                "\n '6' to search for the index of \"For\"\n '7' to search for the index of \"The\"\n '8' to search for the index of \"Win!!\"");
            int user_choice_problem = (Convert.ToInt32(Console.ReadLine())) - 1;

            for (int i = 0; i < unique_strings.Count; i++)
            {
                while (user_choice_problem >= unique_strings.Count || user_choice_problem < 0)
                {
                    Console.WriteLine("Your choice is not a provided option, select again");
                    user_choice_problem = (Convert.ToInt32(Console.ReadLine())) - 1;
                }

                if (i == user_choice_problem)
                {
                    Console.WriteLine("You have chosen " + unique_strings[i]);
                    Console.WriteLine("Your chosen word is located at index " + user_choice_problem);
                }
            }
            ////Problem 9 list of strings with multiple duplcates
            ////Asked user for a specific string from the given list
            ////looped through and grouped the indecies of where they matched
            ////Problem 10 input an else statement that only when no matches were present
            ////to tell them they fail and the prompt is being skipped

            Console.WriteLine("Problem 9 and 10, press enter to continue. . . .");
            Console.ReadLine();
            List<string> duplicate_strings = new List<string> { "Banana", "Monkey", "Whipped", "Cream", "Banana", "Cream", "Banana", "Ice" };
            List<int> counting_ints = new List<int>();
            int check = 0;
            Console.WriteLine("Please type in your choice of word between \"Banana\", \"Monkey\", \"Whipped\", \"Cream\", and \"Ice\" (Case-Sensitive)");
            string user_string = Console.ReadLine();
            for (int i = 0; i < duplicate_strings.Count; i++)
            {
                if (user_string == duplicate_strings[i])
                {
                    counting_ints.Add(i);
                    check++;
                }
            }
            if (check > 1)
            {
                Console.Write("Your chosen word is stored at indecies: \n");
                counting_ints.ForEach(Console.WriteLine);
            }
            else if (check == 0)
            {
                Console.WriteLine("Your choices were \"Banana\", \"Monkey\", \"Whipped\", \"Cream\", and \"Ice\" (Case-Sensitive)");
                Console.WriteLine("Skipping this prompt");
            }
            else
            {
                Console.WriteLine("There was only one instance of your chosen word " + user_string);
            }
            Console.WriteLine("Problem 11, press enter to continue. . . .");
            Console.ReadLine();

            //Problem 11 Creates a list of strings with multiple sets of duplicates
            //does not care if a string was previously checked for duplicates, will still say it has a duplicate value at an earlier index
            List<string> duplicate_strings_2 = new List<string> { "Banana", "Monkey", "Whipped", "Cream", "Banana", "Cream", "Banana", "Ice" };
            int count_int_2 = 0;
            foreach (string list_strings in duplicate_strings_2)
            {
                int count_h = 0;
                for (int i = 0; i < duplicate_strings_2.Count; i++)
                {
                    if (list_strings == duplicate_strings_2[i] && i != count_int_2)
                    {
                        Console.WriteLine("There is a duplicate of " + list_strings + " at  index " + i);
                        count_h++;
                    }
                }
                if (count_h == 0)
                {
                    Console.WriteLine("There are no duplicates of " + list_strings + "\n");
                }
                else
                {
                    Console.WriteLine("Next value \n");
                }
                count_int_2++;
            }
            Console.ReadLine();
        }
    }
}
