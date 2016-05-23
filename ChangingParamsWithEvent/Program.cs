namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// AutoGenrated Program classes
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Some test with events";
            // Set window params
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;

            Person drake=new Person("Drake",29);

            // Start values output
            Console.WriteLine("Current Param ===> name: {0}; age: {1} ... Press Any key to continue",
                drake.Name,
                drake.Age);
            Console.ReadKey();

            // Name changing
            Console.WriteLine("We testing change name");
            drake.Name = "Thomas";
            Console.WriteLine("After name changing Param ===> name: {0}; age: {1} ... Press Any key to continue", 
                drake.Name, 
                drake.Age);
            Console.ReadKey();

            // Age changing
            Console.WriteLine("We testing change Age");
            drake.Age = 40;
            Console.WriteLine("After age changing Param ===> name: {0}; age: {1} ... Press Any key to continue",
                drake.Name,
                drake.Age);
            Console.ReadKey();
        }
    }
}
