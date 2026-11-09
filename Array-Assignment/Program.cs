

using System;
using System.Collections.Generic;


namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a one-dimensional array of strings and assign a list of fruits to it
            string[] fruits = new string[] { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to select an index of the array and then display the fruit at that index on the screen
            Console.WriteLine("Please select an index of the array of Fruits (0-4):");
            // convert the string to an int
            int userSelection = Convert.ToInt32(Console.ReadLine());
            //add a message that displays when the user selects an index that is out of range of the array
            if (userSelection < 0 || userSelection >= fruits.Length)
            {
                Console.WriteLine("Index out of range. Please select a valid index between 0 and 4.");
                userSelection = Convert.ToInt32(Console.ReadLine());
                if (userSelection < 0 || userSelection >= fruits.Length)
                {
                    Console.WriteLine("Index out of range again. Exiting the program.");
                    return;

                }
                else if (userSelection >= 0 || userSelection < fruits.Length)
                {
                    Console.WriteLine("The fruit at index {0} is {1}", userSelection, fruits[userSelection]);
                }
            }
            else
            {
                Console.WriteLine("The fruit at index {0} is {1}", userSelection, fruits[userSelection]);
            }


            // Create a one-dimensional array of integers and assign a list of numbers to it
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };
            // Ask the user to select an index of the array and then display the number at that index on the screen
            Console.WriteLine("Please select an index of the array of Numbers (0-4):");
            int userSelection2 = Convert.ToInt32(Console.ReadLine());
            //add a message that displays when the user selects an index that is out of range of the array
            if (userSelection2 < 0 || userSelection2 >= numbers.Length)
            {
                Console.WriteLine("Index out of range. Please select a valid index between 0 and 4.");
                userSelection2 = Convert.ToInt32(Console.ReadLine());
                if (userSelection2 < 0 || userSelection2 >= numbers.Length)
                {
                    Console.WriteLine("Index out of range again. Exiting the program.");
                    return;
                }else if (userSelection2 >= 0 && userSelection2 < numbers.Length)
                {
                    Console.WriteLine("The number at index {0} is {1}", userSelection2, numbers[userSelection2]);
                }
            }
            else
            {
                Console.WriteLine("The number at index {0} is {1}", userSelection2, numbers[userSelection2]);
            }

            // create a list of strings and assign a list of colors to it
            List<string> colors = new List<string>() { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user to select an index of the list and then display the color at that index on the screen
            Console.WriteLine("Please select an index of the list of Colors (0-4):");
            int userSelection3 = Convert.ToInt32(Console.ReadLine());
            //add a message that displays when the user selects an index that is out of range of the list
            if (userSelection3 < 0 || userSelection3 >= colors.Count)
            {
                Console.WriteLine("Index out of range. Please select a valid index between 0 and 4.");
                userSelection3 = Convert.ToInt32(Console.ReadLine());
                if (userSelection3 < 0 || userSelection3 >= colors.Count)
                {
                    Console.WriteLine("Index out of range again. Exiting the program.");
                    return;
                } else if (userSelection3 >= 0 && userSelection3 < colors.Count)
                {
                    Console.WriteLine("The color at index {0} is {1}", userSelection3, colors[userSelection3]);     
                }
            }
            else
            {
                Console.WriteLine("The color at index {0} is {1}", userSelection3, colors[userSelection3]);
            }

            // Ask the user to select an index of the array and then display the fruit at that index on the screen
            Console.WriteLine("Please select an index of the array of Fruits (0-4):");
            int userSelection4 = Convert.ToInt32(Console.ReadLine());

            //using while loop instead
            bool validString = false;

            while(!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite fruit is " + fruits[userSelection4]); // if an error is thrown, the catch will be called
                    // The below code will not be called, while this is an error in the selection.
                    validString = true;

                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between (0-4)");
                    userSelection4 = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Read();
            
        }
    }
}
