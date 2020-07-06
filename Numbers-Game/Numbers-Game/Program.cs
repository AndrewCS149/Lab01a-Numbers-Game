using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            StartSequence();
        }

        static void StartSequence()
        {
            // Request int from user and store in a variable
            Console.Write("Please enter a number greather than zero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Create an arr the length of the user input
            int[] numArr = new int[num];

            // Begin Sequence
            //GetSum(numArr);

            //GetProduct();

            //GetQuotient();
        }
    }
}
