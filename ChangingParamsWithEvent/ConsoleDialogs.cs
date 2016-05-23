namespace ChangingParamsWithEvent
{
    using System;

    internal static class ConsoleDialogs
    {
        /// <summary>
        /// Show confirm dialog
        /// </summary>
        /// <returns>Dialog bool result</returns>
        public static bool ShowConfirmDialog()
        {
            Console.Write("Change params? (yes/no): ");

            if (Console.ReadLine().ToLower() == "yes")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Show accept message with info of params changed
        /// </summary>
        /// <param name="oldValue">old param value</param>
        /// <param name="newValue">new param value</param>
        public static void AcceptParams(string oldValue, string newValue)
        {
            Console.WriteLine("Old value: {0}; New value: {1}",oldValue,newValue);
            Console.WriteLine("Params will be changed");
        }

    }
}
