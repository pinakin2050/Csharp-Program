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

        public Customer(int id, string name, bool status)
        {
            _CustomerID = id;
            _CustomerName = name;
            _CustomerStatus = status;
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
    }
}
