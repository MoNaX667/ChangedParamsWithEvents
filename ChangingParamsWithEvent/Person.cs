// <copyright file="Person.cs" company="Some Company">
// Copyright (c)  All rights reserved.
// <author>Vitaliy Belyakov</author>
// </copyright>

namespace ChangingParamsWithEvent
{
    using System;

    /// <summary>
    /// Some person class
    /// </summary>
    internal class Person
    {
        // Fileds

        /// <summary>
        ///     Name of person
        /// </summary>
        private string name;

        /// <summary>
        ///     Age of person
        /// </summary>
        private int age;

        // Ctors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Person" /> class the base person with name and age values
        /// </summary>
        /// <param name="name">Name of person</param>
        /// <param name="age">Age of person</param>
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Events

        /// <summary>
        /// Changing property event
        /// </summary>
        public event EventHandler<ParamChangingArgs> OnParamChanging;

        /// <summary>
        /// Error event
        /// </summary>
        public event EventHandler<ErrorArgs> OnError; 

        /// <summary>
        /// Changed property event
        /// </summary>
        public event EventHandler<ParamChangedArgs> OnParamChanged;

        // Props

        /// <summary>
        /// Gets or sets Name of person property
        /// </summary>
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
                    this.OnParamChanging(this, new ParamChangingArgs(this.Name, value));
                }

                // Return from prop if value is empty
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }

                this.name = value;

                if (this.OnParamChanged != null)
                {
                    this.OnParamChanged(this, new ParamChangedArgs(this.Name, this.Age));
                }
            }
        }

        /// <summary>
        /// Gets or sets age of person value
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                // If new age format is bad than throw new ageExcep or do event
                if (value < 1 || value >= 100)
                {
                    if (this.OnError != null)
                    {
                        this.OnError(this, new ErrorArgs());
                        return;
                    }

                    throw new BadAgeException();
                }

                if (this.OnParamChanging != null)
                {
                    this.OnParamChanging(this, new ParamChangingArgs(this.Age, value));
                }

                this.age = value;

                if (this.OnParamChanged != null)
                {
                    this.OnParamChanged(this, new ParamChangedArgs(this.Name, this.Age));
                }
            }
        }
    }
}
