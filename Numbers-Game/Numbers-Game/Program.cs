using System;
using System.Security.Cryptography;

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
            int[] emptyArr = new int[num];

            // Begin Sequence
            int[] filledArr = Populate(emptyArr);

            GetSum(filledArr);

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

        // A method to find the sum of the passed in array
        // Return the sum 
        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            if (sum < 20)
                throw new Exception($"Value of {sum} is too low."));

            return sum;
        }
    }
}
