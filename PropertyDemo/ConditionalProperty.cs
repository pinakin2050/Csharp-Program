using System;

namespace PropertyDemo
{
    class ConditionalProperty
    {
        double _Balance = 1000;

        public double Balance
        {
            get { return _Balance; }
            set //If the condition is satisfied then value of _Balance will be updated else it will be the same.
            {
                if (value < _Balance)
                    _Balance -= value;
            }
        }

        static void Main()
        {
            ConditionalProperty obj = new ConditionalProperty();
            double withdrawalAmount = 4000;
            obj.Balance = withdrawalAmount;
            Console.WriteLine("Value of _Balance: " + obj.Balance);

            withdrawalAmount = 500;
            obj.Balance = withdrawalAmount;
            Console.WriteLine("Updated value of _Balance: " + obj.Balance);
        }
    }
}
