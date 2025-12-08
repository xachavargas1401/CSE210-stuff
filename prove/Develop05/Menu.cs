using System.ComponentModel.DataAnnotations;

class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while(response < 1 || response > 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record daily health check");
            Console.WriteLine("5. Quit");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input must be an integer value from 1 to 5");
            }
        }
        return response;
    }
    public int DisplayCreateGoalMenu()
    {
        return 0;
    }

}