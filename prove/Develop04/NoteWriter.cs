using System;

public class NoteWriter
{
    public void WriteNote(Journal journal)
    {
        Console.WriteLine("\nWrite your note below (no prompt):");
        string response = Console.ReadLine();

        string dateTime = DateTime.Now.ToString("g"); // Includes date and time
        string prompt = "[Personal Note]";

        Entry noteEntry = new Entry(dateTime, prompt, response);
        journal.AddEntry(noteEntry);

        Console.WriteLine("Note added!");
    }
}