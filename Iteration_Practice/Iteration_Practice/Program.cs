using System;
using System.Collections.Generic;

namespace Iteration_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] test_scores = { 98, 99, 85, 23, 70, 82, 45, 87, 23, 00};

            //for (int i = 0; i < test_scores.Length; i++)
            //{
            //    if( test_scores[i] >= 85)
            //    {
            //        Console.WriteLine("Congratulations you passed! " +  test_scores[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("FAIL " + test_scores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Berry", "Erik", "Geroge", "Fred" };

            //for(int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine("YOUR NAME IS " + names[j]);
            //}
            //Console.ReadLine();

            //List<int> test_scores = new List<int>();
            //test_scores.Add(65);
            //test_scores.Add(90);
            //test_scores.Add(98);
            //test_scores.Add(5);
            //test_scores.Add(43);
            //test_scores.Add(76);
            //test_scores.Add(55);
            //test_scores.Add(65);

            //foreach (int score in test_scores)
            //{
            //    if (score >= 85)
            //    {
            //        Console.WriteLine("YOU PASS " + score);
            //    }
            //    else
            //    {
            //        Console.WriteLine("FAIL " + score);
            //    }
            //}
            //Console.ReadLine();

            List<int> test_scores_1 = new List<int> { 90, 84, 23, 43, 99, 0, 84};
            List<int> passing_score = new List<int>();

            foreach (int score in test_scores_1)
            {
                if (score >= 85)
                {
                    passing_score.Add(score);
                }
            }
            Console.WriteLine(passing_score.Count);
            Console.ReadLine();
        }
    }
}
