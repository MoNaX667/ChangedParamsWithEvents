namespace ChangingParamsWithEvent
{
    using System;

    internal class ConsoleDialogs
    {
        public void ShowConfirmDialog(string message,Person targetPerson)
        {
            Console.WriteLine(message);

            if (Console.ReadLine().ToLower() == "yes")
            {
                if (OnChanging != null)
                {
                    OnChanging(this,new ChangingPersonParams(true,targetPerson));
                }
            }
        }

        public event EventHandler<ChangingPersonParams> OnChanging;

        public static void GetChangeParamsDialog(out string newName, out int newAge)
        {
            Console.Write("Input new name: ");

            while (true)
            {
                newName = Console.ReadLine();

                if (newName != null)
                {
                    break;
                }
            }

            

            while (true)
            {
                Console.Write("Input new age: ");

                if (int.TryParse(Console.ReadLine(),out newAge))
                {
                    if (newAge < 0 || newAge > 140)
                    {
                        Console.WriteLine("Wrong Age");
                    }
                    break;
                }

            }

        }
    }
}
