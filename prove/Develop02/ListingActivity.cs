using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);
    }

    public override void DoActivity()
    {
        StartActivity();

        Console.Clear();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses you can to the following prompt");
        Console.WriteLine($"\n---{prompt}---");
        Countdown(4);

        Console.WriteLine("\nStart!");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    }
}
