namespace ChangingParamsWithEvent
{
    using System;

    internal class ChangedPersonParams : EventArgs
    {
        public ChangedPersonParams(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}
