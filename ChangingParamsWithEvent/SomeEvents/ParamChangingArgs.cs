// <copyright file="ParamChangingArgs.cs" company="Some Company">
// Copyright (c)  All rights reserved.
// <author>Vitaliy Belyakov</author>
// </copyright>

namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// Changing event class
    /// </summary>
    internal class ParamChangingArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParamChangingArgs" /> class with name
        /// </summary>
        /// <param name="currentName">current Name</param>
        /// <param name="newName">new Name</param>
        public ParamChangingArgs(string currentName, string newName = "")
        {
            this.Name = currentName;
            this.NewName = newName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamChangingArgs" /> class with age
        /// </summary>
        /// <param name="currentAge">current age</param>
        /// <param name="newAge">new age</param>
        public ParamChangingArgs(int currentAge, int newAge)
        {
            this.Age = currentAge;
            this.NewAge = newAge;
        }

        // Props

        /// <summary>
        /// Gets new age
        /// </summary>
        public int NewAge { get; private set; }

        /// <summary>
        /// Gets current age
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Gets new name
        /// </summary>
        public string NewName { get; private set; }

        /// <summary>
        /// Gets current name
        /// </summary>
        public string Name { get; private set; }
    }
}
