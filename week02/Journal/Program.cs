using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        Console.WriteLine("=================================");
        Console.WriteLine("       MY PERSONAL JOURNAL");
        Console.WriteLine("=================================");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    // Get a random prompt.
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine(prompt);

                    Console.Write("> ");

                    string response = Console.ReadLine() ?? "";

                    // Get today's date.
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    // Create a new journal entry.
                    Entry newEntry = new Entry(
                        date,
                        prompt,
                        response
                    );

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Your entry has been saved in the journal!");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save your journal: ");

                    string saveFilename = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(saveFilename))
                    {
                        Console.WriteLine("Filename cannot be empty.");
                        break;
                    }

                    try
                    {
                        journal.SaveToFile(saveFilename);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving journal: {ex.Message}");
                    }

                    break;

                case "4":
                    Console.Write("Enter filename to load your journal: ");

                    string loadFilename = Console.ReadLine() ?? "";

                    if (string.IsNullOrWhiteSpace(loadFilename))
                    {
                        Console.WriteLine("Filename cannot be empty.");
                        break;
                    }

                    try
                    {
                        journal.LoadFromFile(loadFilename);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading journal: {ex.Message}");
                    }

                    break;

                case "5":
                    running = false;

                    Console.WriteLine("Thank you for using My Personal Journal!");
                    Console.WriteLine("Have a wonderful day!");

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}

/*
CREATIVITY AND EXCEEDING REQUIREMENTS:

1. Added ten different journal prompts.
2. Used JSON format to save and load journal entries.
3. JSON supports commas and quotation marks in responses.
4. Automatically records the current date.
5. Added error handling when saving and loading files.
6. Added a message when the journal is empty.
7. Used separate classes to demonstrate abstraction.
*/