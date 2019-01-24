/*
 Author: Yao Xiao
 Date: 1/24/2019
 Comments: This C# Console application code demonstrates the use of 
 conditional statements after getting input from users
*/

using System;

namespace Students_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] i = new int[1];
            do
            {

                Console.WriteLine("Please enter your grades...");
                i[0] = Convert.ToInt32(Console.ReadLine());

                if (i[0] >= 90)
                {
                    Console.WriteLine("you get A! ");
                }
                else if (i[0] >= 80 && i[0] < 90)
                {
                    Console.WriteLine("you get B! ");
                }
                else if (i[0] >= 70 && i[0] < 80)
                {
                    Console.WriteLine("you get C! ");
                }
                else if (i[0] >= 60 && i[0] < 70)
                {
                    Console.WriteLine("you get D! ");
                }
                else if (i[0] < 60)
                {
                    Console.WriteLine("you get F! ");
                }
                else if (i[0] < 0)
                {
                    Console.WriteLine("Please enter a grades between 0 to 100");
                }
                else if ((i[0] > 100))
                {
                    Console.WriteLine("Please enter a grades between 0 to 100");
                }
            } while (true);
        }
    }
}
