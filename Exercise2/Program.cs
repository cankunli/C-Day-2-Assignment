using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Size: ");
            string sSize = Console.ReadLine();
            int i = Convert.ToInt32(sSize);
            int[] score = new int[i];

            // create the loop of asking the test scores limited to the array sSize
            for (int a = 0; a < i; a++)
            {
                Console.WriteLine("Please enter list of value " + (a + 1) + ": ");
                string testArray = Console.ReadLine();
                int g = Convert.ToInt32(testArray);
                score[a] = g;
            }

            //create loop to display all test scores
            foreach (var item in score)
                Console.WriteLine(item);

            //string[] a;
            //a.GetData();
            //Display();
            Console.ReadLine();
        }
    }
}
