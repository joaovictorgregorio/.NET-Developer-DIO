using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculator
    {
        private List<string> _history;
        private string _date;

        public Calculator(string date)
        {
            _history = new List<string>();
            this._date = date;
        }

        public int Sum(int valueOne, int valueTwo)
        {
            int result = valueOne + valueTwo;

            _history.Insert(0, "Result: " + result);

            return result;
        }

        public int Subtraction(int valueOne, int valueTwo)
        {
            int result = valueOne - valueTwo;

            _history.Insert(0, "Result: " + result);

            return result;
        }

        public int Multiplication(int valueOne, int valueTwo)
        {
            int result = valueOne * valueTwo;

            _history.Insert(0, "Result: " + result);

            return result;
        }

        public int Division(int valueOne, int valueTwo)
        {
            int result = valueOne / valueTwo;

            _history.Insert(0, "Result: " + result);

            return result;
        }

        public List<string> HistoricalCalculations()
        {
            _history.RemoveRange(3, _history.Count - 3);

            return _history;
        }
    }
}