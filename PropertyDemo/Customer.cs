using System;

namespace PropertyDemo
{
    class Customer
    {
        public const int MinimumBalance = 500;
        int _CustomerID;
        string _CustomerName;
        bool _CustomerStatus;
        double _CustomerBalance;
        string _State;
        //Making it as enum type var bcz branches are available only in few cities so it's better to go with enum in such cases
        //So that user can know what values are acceptable.
        Cities _City;

        public Customer(int Id, string Name, bool Status, double Balance, Cities City, string State) //,string Country)
        {
            _CustomerID = Id;
            _CustomerName = Name;
            _CustomerStatus = Status;
            _CustomerBalance = Balance;
            _City = City;
            _State = State;
            //Auto property can be initialized like this also
            //this.Country = Country;
        }
        public int CustomerID
        {
            get { return _CustomerID; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if (_CustomerStatus)
                    _CustomerName = value;
            }
        }

        public bool CustomerStatus
        {
            get { return _CustomerStatus; }
            set { _CustomerStatus = value; }
        }

        public double CustomerBalance
        {
            get { return _CustomerBalance; }
            set
            {
                if(_CustomerStatus)
                {
                    if (value > MinimumBalance)
                        _CustomerBalance = value;
                }
            }
        }

        public Cities City
        {
            get { return _City; }
            set
            {
                if (_CustomerStatus)
                {
                    _City = value;
                }
            }
        }

        public string State
        {
            get { return _State; }
            //I want only child class to modify the state so i can make it protected.
            protected set
            {
                _State = value;
            }
        }

        //This is an auto property which can be used when you don't want to declare a field 
        //Either you can auto initialize it or can be initialized in the constructor as well
        //set accessor can also be used but without any conditions.
        public string Country { get; } = "India";
    }
}
