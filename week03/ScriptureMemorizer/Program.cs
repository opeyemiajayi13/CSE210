using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity feature:
        // The program contains a library of scriptures.
        // It randomly selects a scripture each time the program starts.
        // This gives users different scriptures to memorize.

        Scripture[] scriptureLibrary =
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };

        // Randomly select a scripture from the library.
        Random random = new Random();

        Scripture scripture = scriptureLibrary[
            random.Next(scriptureLibrary.Length)
        ];

        // Continue until all words are hidden or the user quits.
        while (true)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       SCRIPTURE MEMORIZER");
            Console.WriteLine("================================");
            Console.WriteLine();

            // Display the scripture.
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Check whether all words are hidden.
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You have hidden all the words.");
                Console.WriteLine("Thank you for practicing!");
                break;
            }

            Console.WriteLine("Press ENTER to hide three random words.");
            Console.WriteLine("Type 'quit' to exit the program.");

            string input = Console.ReadLine();

            // Allow the user to quit.
            if (input != null && input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Thank you for using Scripture Memorizer!");
                break;
            }

            // Hide three words when Enter is pressed.
            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}