namespace ChangingParamsWithEvent
{
    using System;

    class ParamChanged : EventArgs
    {
        public ParamChanged(string name= "", int age = 0)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}
