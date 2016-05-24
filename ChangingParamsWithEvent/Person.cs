namespace ChangingParamsWithEvent
{
    using System;

    internal class Person
    {
        // Fileds
        private string name;
        private int age;

        // Ctors
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Delegates

        /// <summary>
        /// Wil used with param changing event
        /// </summary>
        /// <returns>Return dialog result</returns>
        public delegate bool PersonParamChangingHandler();

        /// <summary>
        /// Will used with param changed event
        /// </summary>
        /// <param name="oldName">Old value</param>
        /// <param name="newName">New value</param>
        public delegate void PersonParamChangedHandler(string oldName, string newName);

        // Events
        public event PersonParamChangingHandler ParamChanging;

        public event PersonParamChangedHandler ParamChanged;

        // Props
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.ParamChanging())
                {
                    this.ParamChanged(this.name, value);
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value >= 100)
                {
                    throw new BadAgeException();
                }

                if (this.ParamChanging())
                {
                    this.ParamChanged(this.age.ToString(), value.ToString());
                    this.age = value;
                }
            }
        }
    }
}
