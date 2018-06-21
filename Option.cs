using System;

namespace dotNet5776_01_2920_0267
{
    public class Option
    {
        public readonly string description;
        public readonly IExecutable operation;

        public Option(string description, IExecutable operation)
        {
            this.description = description;
            this.operation = operation;
        }
    }
}

