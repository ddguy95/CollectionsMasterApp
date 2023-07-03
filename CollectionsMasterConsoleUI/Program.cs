using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var array = new int[50];
            //int[] array = new int[50];
            //NumberPrinter(array);

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(array);

            //TODO: Print the first number of the array
            Console.WriteLine($"{array[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"{array[array.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                   Array.Reverse
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(array);
            NumberPrinter(array);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(array);
           
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);
            NumberPrinter(array);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array);
            NumberPrinter(array);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list= new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(list.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);
            NumberPrinter(list);

            //TODO: Print the new capacity
            Console.WriteLine("New capacity");
            Console.WriteLine(list.Capacity);
            Console.WriteLine();

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int numberLookingFor = int.Parse(Console.ReadLine());
            NumberChecker(list, numberLookingFor);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);

                  
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            list.Sort();
            NumberPrinter(list);
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = list.ToArray();

            //TODO: Clear the list
            list.Clear();
            Console.WriteLine("This list is clear. Here are all the numbers in the list");
            NumberPrinter(list);


            #endregion
        }

        private static void Populater(object count)
        {
            throw new NotImplementedException();
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++ )
            {
                if (numbers[i] %3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            Random instance = new Random(); 
            for (int i = numberList.Count -1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]); 
                }
           
           
                
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            foreach (var item in numberList)
            {   
                if (item == searchNumber)
                {
                    Console.WriteLine($"{searchNumber} is in your list");
                    foundNumber = true;
                    break;
                }
               
            }

            if (foundNumber == false)
            {
                Console.WriteLine($"{searchNumber} is not in your list");
            }
        }

        private static void Populater(List<int> numberList)
        {          
            while(numberList.Count < 51)
            {
                Random rng = new Random();
                var array = rng.Next(0, 50);

                numberList.Add(array);

            }
            NumberPrinter(numberList);
                
               //list.Add(randomNumber); 

        }

        private static void Populater(int[] numbers)
        
        {
            
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber = rng.Next(0, 51);
                numbers[i] = randomNumber;
            }
              

        }        

        private static void ReverseArray(int[] array)
        {
            // 5 parts of a loop: loop type: 
            // for ( initializer ; conditional ; increment / decrementor )
            // {
            // scope / body - The, What we want the loop to do.
            // }
            // for is the loop type. int is variable type,
            // reverseNumbers is the variable name, (=) tells what is to the right to assign it to the variable we've created.
            // reverseNumbers >= 0; This is our conditional. Which will evaluate to true or false. What this means is, if true, continue looping. If false, exit out.
            // reverseNumbers-- is our vehicle to telling the program that we want it to decrement. Which is how we update the conditional, so that eventually it becomes false, and we can exit the loop.
            for (int reverseNumbers = array.Length - 1; reverseNumbers >= 0; reverseNumbers--)
            {
                Console.WriteLine(array[reverseNumbers]);
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
