using System;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected void SetName(string name) => _name = name;
    protected void SetDescription(string description) => _description = description;
    protected void SetDuration(int duration) => _duration = duration;

    protected int GetDuration() => _duration;
    protected string GetName() => _name;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\n{_description}\n");
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
    }

    public abstract void DoActivity();

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {GetDuration()} seconds of the {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
