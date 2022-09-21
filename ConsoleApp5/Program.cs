using System.Reflection.Metadata;

class ConsoleApp2
{
    public static void Main()
    {
        int id, speed, speed_limit, fine;
        Console.WriteLine("Enter your id: ");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the speed you are driving: ");
        speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the speed_limit: ");
        speed_limit = int.Parse(Console.ReadLine());
        if (speed > speed_limit)
        {
            fine = (speed - speed_limit) * 30;
            Console.WriteLine("Your id is {0}, and your fine is {0} shekels!", id, fine);
        }
        else
            Console.WriteLine("You shall drive!");
    }
}