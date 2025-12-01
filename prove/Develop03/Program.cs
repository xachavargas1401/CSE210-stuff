using System;

class Program
{
    static void Main(string[] args)
    {
        ScripturesList library = new ScripturesList();
        Scripture chosenScripture = library.GetRandomScripture();

        Console.WriteLine("Press ENTER once you are ready to start memorizing a random scripture or type 'quit' to exit.");
        string startInput = Console.ReadLine().Trim().ToLower();

        if (startInput == "quit")
            return;

        Console.Clear();

        while (true)
        {
            Console.WriteLine(chosenScripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to start hiding words or type 'quit' to end.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            Console.Clear();
            chosenScripture.HideRandomWords();

            if (chosenScripture.IsCompletelyHidden())
            {
                Console.Clear();
                break;
            }
        }
    }
}
