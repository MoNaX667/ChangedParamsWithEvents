// <copyright file="ParamChangedArgs.cs" company="Some Company">
// Copyright (c)  All rights reserved.
// <author>Vitaliy Belyakov</author>
// </copyright>

namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// Changed event class
    /// </summary>
    internal class ParamChangedArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParamChangedArgs" /> class
        /// </summary>
        /// <param name="name">current name</param>
        /// <param name="age">current age</param>
        public ParamChangedArgs(string name = "", int age = 0)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// Gets current name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets current age
        /// </summary>
        public int Age { get; private set; }
    }
}
