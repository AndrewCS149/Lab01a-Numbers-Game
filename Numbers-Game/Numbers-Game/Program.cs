﻿using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet user
            Console.WriteLine("Welcome to my game! Let's do some math!");

            // Begin application
            StartSequence();
        }

        // A method to begin the application by calling all other methods
        static void StartSequence()
        {
            // Request int from user and store in a variable
            Console.Write("Please enter a number greater than zero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Create an arr the length of the user input
            int[] emptyArr = new int[num];

            // Begin Sequence

            // create and fill array
            int[] filledArr = Populate(emptyArr);

            // get sum of 'filledArr'
            int sum = GetSum(filledArr);

            // get product from 'sum' and 'filledArr' 
            int product = GetProduct(filledArr, sum);

            // get quotient of 'product' and user generated value
            GetQuotient(product);
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
                //arr[i - 1] = Convert.ToInt32(userInput);
                arr[i - 1] = Int32.Parse(userInput);
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
                throw new Exception($"Value of {sum} is too low.");

            return sum;
        }

        // A method to find the product of the user input and the length of the
        // passed in array.
        // Return the product
        static int GetProduct(int[] arr, int sum)
        {
            int num;
            int product;
            try
            {
                Console.Write($"Please enter a number between 1 and {arr.Length}: ");
                string userInput = Console.ReadLine();
                num = Convert.ToInt32(userInput);
                product = arr[num - 1] * sum;
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }

            return product;
        }

        // A method to get the quotient with the GetProduct() result as the dividend
        // and a user generated value as the divisor. 
        // Return the quotient
        static decimal GetQuotient(int product)
        {
            int divisor;
            decimal quotient;
            try
            {
                // Get the divisor from the user and store in 'divisor' var.
                Console.Write($"Please enter a number to divide your product {product} by: ");
                string userInput = Console.ReadLine();

                // convert user input to integer
                divisor = Convert.ToInt32(userInput);

                // get quotient of product and divisor
                quotient = decimal.Divide(product, divisor);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                quotient = 0;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                quotient = 0;
            }

            Console.WriteLine($"Quotient: {quotient}");
            return quotient;
        }
    }
}
