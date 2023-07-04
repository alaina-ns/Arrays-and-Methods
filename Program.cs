using System;

namespace Arrays_and_Methods
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            bool validInput = false;
            int input = 0;

            while (!validInput)
            {
                Console.WriteLine("Enter an integer number between 5 and 15");

                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (input >= 5 && input <= 15)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 5 and 15.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }

            int[] MyArray = random_array(input);

            Console.Write("The elements in the random array are: ");
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The sum is: " + sum(MyArray));
        }
    }
}
