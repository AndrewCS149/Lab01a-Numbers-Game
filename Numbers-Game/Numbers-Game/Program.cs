using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            StartSequence();
        }

        // A method to begin the application by calling all other methods
        static void StartSequence()
        {
            // Request int from user and store in a variable
            Console.Write("Please enter a number greather than zero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Create an arr the length of the user input
            int[] numArr = new int[num];

            // Begin Sequence
            Populate(numArr);

            //GetSum(numArr);

            //GetProduct();

            //GetQuotient();
        }

        // A method to generate the contents within the array defined in 'StartSequence()'
        // Pass in empty array
        // Return filled array
        static int[] Populate(int[] arr)
        {
            // add content to the passed in array
            for (int i = 1; i <= arr.Length; i++)
            {
                // Gather user input
                Console.Write($"Please enter number: {i} of {arr.Length}: ");
                string userInput = Console.ReadLine();

                // Store in array
                arr[i - 1] = Convert.ToInt32(userInput);
            }

            return arr;
        }
    }
}
