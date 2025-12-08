using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);
    }

    public override void DoActivity()
    {
        StartActivity();

        Console.Clear();
        Console.WriteLine("Get ready....\n");
        ShowSpinner(2);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("\nBreathe out... ");
            Countdown(6);
            Console.WriteLine("\n");
        }

        EndActivity();
    }
}
