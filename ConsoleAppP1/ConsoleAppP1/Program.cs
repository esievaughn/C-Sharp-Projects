using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP1 
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNMENT PT 1: A loop that iterates through each string in the array and adds the user's text input to the end
            // of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
            //Then create a loop that prints off each string in the array on a separate line.
           
            string[] wordArray = { "active", "visible", "value", "appear", "agreeable", "sect" };

            Console.WriteLine("Please choose one from the following prefixes: pro, non, in, re, de, dis, inter");
            string addPrefix = Console.ReadLine();
           
            for (int i = 0; i < wordArray.Length; i++)          //for loop to iterate through each string in the area, increments by 1
                {
                    wordArray[i] = addPrefix + wordArray[i];    //adds user's input to each string index
                }
            foreach (string word in wordArray)                  //foreach loop to iterate through the array collection 
            {
                Console.WriteLine(word);
            }

            // ASSIGNMENT PT 2: An infinite loop; Fix the infinite loop so that it will execute properly.

            while (true)                                         //while true creates infinite loop
            {
                foreach (string word in wordArray)
                    Console.WriteLine(word);
                break;                                          //break fixes infinite loop
            }

            //ASSIGNMENT PT 3: A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator;
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
           
            int[] employeeID = { 2323, 2524, 3623, 4362, 5324, 6345, 7124, 8958 };

            foreach (int id in employeeID)                  //iterating loop
            {

                if (id < 2524)                              //uses comparison <
                {
                    Console.WriteLine("Oldest employee id: " + id);
                }

                if (id <= 8958)                             //uses comparison <=
                {
                    Console.WriteLine("\n" + id);
                }
            }

            //ASSIGNMENT PT 4: A list of strings where each item in the list is unique. Ask the user to input text to search for in the list.
            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //Add code to the loop that stops it from executing once a match has been found.

            List<string> daysOfWeek = new List<string>() { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            Console.WriteLine("\nPlease choose one weekday and write it below:");
            string userDay = Console.ReadLine().ToLower();  //ToLower to account for capitalization
            bool userInputMatch = daysOfWeek.Contains(userDay);
            userInputMatch = false;

            for (int i = 0; i < daysOfWeek.Count; i++)      //use count instead of Length for list
            {
                if (daysOfWeek[i].Contains(userDay))        //.Contains returns a value indicating whether a specified character occurs within this string
                {
                    Console.WriteLine(userDay + " has an index of: " + i);
                    userInputMatch = true;
                    break;
                }
            } 
            if (!userInputMatch) //if not matched
            {
                Console.WriteLine("Sorry, that is not a day of the week!");
            }

            //ASSIGNMENT PT 5: A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            //Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

            List<string> fruit = new List<string>() { "pineapple", "kiwi", "strawberry", "blackberry", "strawberry", "pear", "watermelon", "pear" };

            Console.WriteLine("\nPlease choose a fruit and write it below:");
            string userFruit = Console.ReadLine().ToLower();
            bool userInput = fruit.Contains(userFruit);
     
            if (userInput) 
            {
                for (int i = 0; i < fruit.Count; i++)      //use count instead of Length for list
                {
                    if (fruit[i].Contains(userFruit))        //.Contains returns a value indicating whether a specified character occurs within this string
                    {
                        Console.WriteLine(userFruit + " has an index of: " + i + "\n");
                        userInput = true;
                    }
                }
            }
            else
            {
                userInput = false;
                Console.WriteLine("Sorry, that is not a fruit in the list!\n");
            }

            //ASSIGNMENT PT 6: Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> duplicateCheck = new List<string>();  //need a new list to store each element

            foreach (string f in fruit) //iterate through original fruit list
            {
                if (!duplicateCheck.Contains(f))
                {
                    duplicateCheck.Add(f);
                    Console.WriteLine(f + " is unique on this list!");
                }
                else
                {
                    Console.WriteLine(f + " is a duplicate on the list.");
                }
            }

            Console.ReadLine();
        }
    }
}
