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

        // Events
        public event EventHandler<ParamChanging> OnParamChanging;

        public event EventHandler<Error> OnError; 

        public event EventHandler<ParamChanged> OnParamChanged;

        // Props
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.OnParamChanging != null)
                {
                    this.OnParamChanging(this, new ParamChanging(this.Name, value));
                }

                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }

                if (this.OnParamChanged != null)
                {
                    this.OnParamChanged(this, new ParamChanged(this.Name, this.Age));
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
                    if (this.OnError != null)
                    {
                        this.OnError(this, new Error());
                        return;
                    }

                    throw new BadAgeException();
                }

                if (this.OnParamChanging != null)
                {
                    this.OnParamChanging(this, new ParamChanging(this.Age, value));

                    this.age = value;

                    if (this.OnParamChanged != null)
                    {
                        this.OnParamChanged(this, new ParamChanged(this.Name, this.Age));
                    }
                }
            }
        }
    }
}
