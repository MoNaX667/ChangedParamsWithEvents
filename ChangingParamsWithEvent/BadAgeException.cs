/// <summary>
/// Excep
/// </summary>
namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// Exception for using with age parameter, when different conditions was broken
    /// </summary>
    internal class BadAgeException : Exception
    {
        /// <summary>
        /// New message prop
        /// </summary>
        public override string Message
        {
            get { return "Wrong age parameter was used ... Catch Age Exception"; } 
        }
    }
}
