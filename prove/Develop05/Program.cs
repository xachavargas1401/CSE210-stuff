using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        int response = 0;

        while (response != 5)
        {
            response = menu.DisplayMenu();

            Goal myGoal = new Goal("Run", "Run alot faster");
            Console.WriteLine(myGoal.GetConsoleString());

        }
    }
}