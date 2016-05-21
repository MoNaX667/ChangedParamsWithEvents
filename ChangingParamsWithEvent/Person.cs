namespace ChangingParamsWithEvent
{
    using System;

    internal class Person
    {
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public void ChangeParams(string newName, int newAge)
        {
            this.name = newName;
            this.age = newAge;

            if (OnChanged != null)
            {
                OnChanged(this, new ChangedPersonParams("Params will be changed"));
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}; Age: {1}",this.name,this.age);
        }

        public event EventHandler<ChangedPersonParams> OnChanged;
    }
}
