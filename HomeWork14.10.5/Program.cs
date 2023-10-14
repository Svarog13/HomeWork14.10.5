using System;

Console.WriteLine("Choose the converter type:");
Console.WriteLine("1 - Celsius/Fahrenheit");
Console.WriteLine("2 - Kilometers/Miles");
Console.WriteLine("0 - Exit");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Choose the temperature converter:");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Fahrenheit to Celsius");
        Console.WriteLine("0 - Exit");
        int temperature = int.Parse(Console.ReadLine());

        if (temperature == 0)
        {
            break;
        }

        switch (temperature)
        {
            case 1:
                Console.WriteLine("Enter the temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
                break;

            case 2:
                Console.WriteLine("Enter the temperature in Fahrenheit: ");
                double fahrenheitInput = double.Parse(Console.ReadLine());
                double celsiusOutput = (fahrenheitInput - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheitInput}°F is equal to {celsiusOutput}°C");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 0 to exit.");
                break;
        }
        break;

    case 2:
        Console.WriteLine("Choose the distance converter:");
        Console.WriteLine("1 - Kilometers to Miles");
        Console.WriteLine("2 - Miles to Kilometers");
        Console.WriteLine("0 - Exit");
        int distance = int.Parse(Console.ReadLine());

        if (distance == 0)
        {
            break;
        }

        switch (distance)
        {
            case 1:
                Console.WriteLine("Enter the distance in Kilometers: ");
                double kilometers = double.Parse(Console.ReadLine());
                double miles = kilometers / 1.609344;
                Console.WriteLine($"Converted distance: {miles} miles");
                break;

            case 2:
                Console.WriteLine("Enter the distance in Miles: ");
                double milesInput = double.Parse(Console.ReadLine());
                double kilometersOutput = milesInput * 1.609344;
                Console.WriteLine($"Converted distance: {kilometersOutput} kilometers");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 0 to exit.");
                break;
        }
        break;

    case 0:
        return;

    default:
        Console.WriteLine("Invalid choice. Please select 1, 2, or 0 to exit.");
        break;
}