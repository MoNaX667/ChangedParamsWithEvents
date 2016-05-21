namespace ChangingParamsWithEvent
{
    using System;

    internal class ChangingPersonParams : EventArgs
    {
        public ChangingPersonParams(bool changingFlag, Person targetPerson)
        {
            this.ChangingFlag = changingFlag;
        }

        public bool ChangingFlag { get; private set; }

        public Person TargetPerson { get; private set; }
    }
}
