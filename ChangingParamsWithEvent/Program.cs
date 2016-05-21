namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// AutoGenrated Program classes
    /// </summary>
    internal class Program
    {
        private static Person someBody;

        static void Main(string[] args)
        {
            Console.Title = "Some test with events";
            // Set window params
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;

            someBody = new Person("Jaky",20);
            ConsoleDialogs dialogShower = new ConsoleDialogs();


            // Linking events
            dialogShower.OnChanging += dialogShower_OnChanging;
            someBody.OnChanged += someBody_OnChanged;

            // Output start value
            Console.Write(new string('-', 30));
            Console.Write("Start version of person");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(someBody.ToString());
            Console.Write(new string('-', 30));
            Console.WriteLine();

            // Change person params
            dialogShower.ShowConfirmDialog(
                "Are you sure that you wish change params: Yes/No",
                someBody);

            // Output chanhed value
            Console.Write(new string('-', 30));
            Console.Write("Chenged version of person");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(someBody.ToString());
            Console.Write(new string('-', 30));
            Console.WriteLine();

            Console.ReadKey();
        }

        /// <summary>
        /// Event changing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void dialogShower_OnChanging(object sender, ChangingPersonParams e)
        {
            if (e.ChangingFlag)
            {
                string tempName="";
                int tempAge=0;

                ConsoleDialogs.GetChangeParamsDialog(out tempName,out tempAge);

                someBody.ChangeParams(tempName,tempAge);
            }
        }

        /// <summary>
        /// Event Changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void someBody_OnChanged(object sender, ChangedPersonParams e)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(e.Message);
            Console.WriteLine(new string('-', 30));
        }
    }
}
