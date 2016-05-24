/// <summary>
/// First app file
/// </summary>
namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Some test with events";

            // Set window params
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;

            // Create Person instance and linking events
            Person drake = new Person("Drake", 29);
            drake.ParamChanging += ConsoleDialogs.ShowConfirmDialog;
            drake.ParamChanged += ConsoleDialogs.AcceptParams;

            // Start values output
            Console.WriteLine(
                "Current Param ===> name: {0}; age: {1} ... Press Any key to continue",
                drake.Name,
                drake.Age);
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();

            // Name changing
            Console.Write("We testing change name ... input new name: ");
            drake.Name = Console.ReadLine();

            Console.WriteLine(
                "After name changing Param ===> name: {0}; age: {1} ... Press Any key to continue", 
                drake.Name, 
                drake.Age);
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();

            // Age changing
            Console.Write("We testing change Age ... input new age: ");

            while (true)
            {
                int tempAge;
                 
                if (int.TryParse(Console.ReadLine(), out tempAge))
                {
                    try
                    {
                        drake.Age = tempAge;
                        Console.WriteLine(
                        "After age changing Param ===> name: {0}; age: {1} ... Press Any key to continue",
                        drake.Name,
                        drake.Age);
                    }
                    catch (BadAgeException excep)
                    {
                        Console.WriteLine(excep.Message);
                    }

                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
