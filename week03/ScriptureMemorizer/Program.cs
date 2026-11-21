using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity feature:
        // This program contains a library of three scriptures.
        // A different scripture is randomly selected each time
        // the program starts, giving the user more practice.

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

        Random random = new Random();

        Scripture scripture = scriptureLibrary[
            random.Next(scriptureLibrary.Length)
        ];

        while (true)
        {
            Console.Clear();

            Console.WriteLine("==============================");
            Console.WriteLine("     SCRIPTURE MEMORIZER");
            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("All scripture words are hidden.");
                Console.WriteLine("Thank you for practicing!");
                break;
            }

            Console.WriteLine("Press ENTER to hide three random words.");
            Console.WriteLine("Type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLowerInvariant() == "quit")
            {
                Console.WriteLine("Thank you for using Scripture Memorizer!");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}