using System;

namespace ExceptionDemo
{
    class DivideByOddNumber : ApplicationException
    {
        public override string Message
        {
            get { return "The divisor must be even!"; }
        }
    }
}
