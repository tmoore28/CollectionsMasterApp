using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] myArray = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);



            //Print the first number of the array
            Console.WriteLine(myArray[0]);

            //Print the last number of the array            
            Console.WriteLine(myArray.Length - 1);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var newList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"New Capacity; {newList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(newList);

            //Print the new capacity
            Console.WriteLine($"New Capacity; {newList.Capacity}");

            Console.WriteLine("--------------------");

            //Create a method that prints if a user number is present in the list
            int userNumber;
            bool isAnswer;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isAnswer = int.TryParse(Console.ReadLine(), out userNumber);

            } while (!isAnswer);

            NumberChecker(newList, userNumber);

            //Remember: What if the user types "abc" accident your app should handle that!


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(newList);
            Console.WriteLine("-------------------");


            //Create a method that will remove all odd numbers from the list then print results

            Console.WriteLine("Evens Only!!");

            OddKiller(newList);

            Console.WriteLine("------------------");


            //Sort the list then print results

            Console.WriteLine("Sorted Evens!!");

            newList.Sort();
            NumberPrinter(newList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            newList.ToArray();

            //Clear the list
            newList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (var i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 == 0)
                {
                    numberList.Add(numberList[i]);
                }
                else
                {
                    numberList.RemoveAt(i);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes {searchNumber} is in the list.");
            }
            else
            {
                Console.WriteLine($"No {searchNumber} is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            while (numberList.Count <= 50)
            {
                var number = rng.Next(0, 50);
                numberList.Add(number);
            }
            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }

        private static void ReverseArray(int[] array)
        {
            for (int i = 50; i < array.Length; i--)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}