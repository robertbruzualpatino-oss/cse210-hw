using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        // Description of exceeding requirements (as requested by the prompt)
        /*
         * Exceeded requirements by:
         * 1. Adding additional prompts to the list (more than the required 5).
         * 2. Implementing basic error handling for file operations (try-catch blocks).
         * 3. Using robust, unique separator (~|~) for file saving to better ensure data integrity.
         */

         while (running)
        {
           Console.WriteLine("\nChoose an option:");
           Console.WriteLine("1. Write a new entry");
           Console.WriteLine("2. Display the journal");
           Console.WriteLine("3. Save the journal to a file");
           Console.WriteLine("4. Load the journal from a file");
           Console.WriteLine("5. Exit");
           Console.Write("Enter your choice (1-5): ");

           string choice = Console.ReadLine();

           switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                journal.DisplayJournal();
                break;
                case "3":
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFilename = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(saveFilename))
                    {
                        journal.SaveToFile(saveFilename);
                    }
                    break;
                case "4":
                    Console.Write("Enter filename to load (e.g., journal.txt): ");
                    string loadFilename = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(loadFilename))
                    {
                        journal.LoadFromFile(loadFilename);
                    }
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}