namespace ChangingParamsWithEvent
{
    using System;

    class ParamChanging: EventArgs
    {
        /// <summary>
        /// C=tor for changing name
        /// </summary>
        /// <param name="currentName">must be passed</param>
        /// <param name="newName">can be initilizate by default</param>
        public ParamChanging(string currentName, string newName = "")
        {
            this.Name = currentName;
            this.newName = newName;
        }

        /// <summary>
        /// C=tor for changing age
        /// </summary>
        /// <param name="currentAge">must be passed</param>
        /// <param name="newAge">can be initilizate by default</param>
        public ParamChanging(int currentAge, int newAge)
        {
            this.Age = currentAge;
            this.NewAge = newAge;
        }

        // Props
        public int NewAge { get; private set; }

        public int Age { get; private set; }

        public string newName { get; private set; }

        public string Name { get; private set; }
    }
}
