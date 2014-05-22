using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalc
{
    class Operations
    {
        private double _value1;
        private string _operation;
        private double _value2;
        
        
        public Operations()
        {
            _value1 = 0;
            _operation = "";
            _value2 = 0;

        }

        public Operations(double value1, string operation, double value2)
        {
            _value1 = value1;
            _operation = operation;
            _value2 = value2;
        }

        public void InitWithStrings(string value1, string operation, string value2)
        {
            Double.TryParse(value1, out _value1);
            _operation=operation;
            Double.TryParse(value2, out _value2);

        }


        public override string ToString()
        {
            return string.Format("{0}{1}{2}={3}", _value1, _operation, _value2);
        }

        public double Total()
        {

            switch (_operation)
            {
                case "/":
                    return _value1 / _value2;
                case "*":
                    return _value1 * _value2;
                case "-":
                    return _value1 - _value2;
                case "+":
                    return _value1 + _value2;

            }
            return 0;
        }


        public double Value1
        {
            get { return _value1; }
            set { _value1 = value; }

        }

        public string Operation
        {
            get { return _operation; }
            set { _operation = value; }

        }

        public double Value2
        {
            get { return _value2; }
            set { _value2 = value; }

        }


    }
}
