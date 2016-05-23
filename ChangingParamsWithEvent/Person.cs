namespace ChangingParamsWithEvent
{
    using System;

    internal class Person
    {
        // Fileds
        private string name;
        private int age;
        private PersonParamChangingHandler tempChanging;
        private PersonParamChangedHandler tempChanged ;

        // Delegates
        /// <summary>
        /// Wil used with param changing event
        /// </summary>
        /// <returns></returns>
        public delegate bool PersonParamChangingHandler();

        /// <summary>
        /// Will used with param changed event
        /// </summary>
        /// <param name="oldName">Old value</param>
        /// <param name="newName">New value</param>
        public delegate void PersonParamChangedHandler(string oldName,string newName);

        // Events
        public event PersonParamChangingHandler ParamChanging;
        public event PersonParamChangedHandler ParamChanged;

        // Ctors
        public Person(string name,int age)
        {
            // Create new link from event to delegate with func
            this.tempChanging = new PersonParamChangingHandler(ConsoleDialogs.ShowConfirmDialog);
            this.tempChanged = new PersonParamChangedHandler(ConsoleDialogs.AcceptParams);
            this.ParamChanging += tempChanging;

            this.name = name;
            this.age = age;
        }

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
                    tempChanged(this.name, value);
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
                if (this.ParamChanging())
                {
                    tempChanged(this.age.ToString(), value.ToString());
                    this.age = value;
                }
            }
        }
    }
}
