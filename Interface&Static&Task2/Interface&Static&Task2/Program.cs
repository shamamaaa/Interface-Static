using Interface_Static_Task2.Extensions;

namespace Interface_Static_Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reqem daxil edin");
        int number1 = int.Parse(Console.ReadLine());
        if (number1.IsOdd())
        {
            Console.WriteLine($"{number1} tek ededdir.");
        }
        else
        {
            Console.WriteLine($"{number1} cut ededdir.");
        }

        Console.WriteLine("Reqem daxil edin");
        int number2 = int.Parse(Console.ReadLine());

        if (number2.IsEven())
        {
            Console.WriteLine($"{number2} cut ededdir.");
        }
        else
        {
            Console.WriteLine($"{number2} tek ededdir.");
        }

        Console.WriteLine("Password daxil edin");
        string password = Console.ReadLine();

        if (password.CheckPassword())
        {
            Console.WriteLine($"Password gecerlidir");
        }
        else
        {
            Console.WriteLine($"Password duzgun daxil edilmeyib");
        }


        Console.WriteLine("String daxil edin");
        string input = Console.ReadLine().Trim().ToLower();

        Console.WriteLine($"Kohne hali: {input}");
        Console.WriteLine($"Yeni hali: {input.Capitalize()}");

    }
}

