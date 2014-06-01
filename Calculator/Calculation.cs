using System;
using System.Collections.Generic;


namespace Calculator
{
    class Calculation
    {
        private readonly Dictionary<char, Func<dynamic, dynamic, dynamic>> _actions;
        public dynamic Arg1 { get; set; }
        public dynamic Arg2 { get; set; }
        public dynamic Action { get; set; }
        public Calculation()
        {
            _actions = new Dictionary<char, Func<dynamic, dynamic, dynamic>>
            {
                {'+', (x, y) => x + y},
                {'-', (x, y) => x - y},
                {'*', (x, y) => x * y},
                {'/', (x, y) => x / y},

            };
        }
        protected dynamic Calc()
        {
            dynamic result = _actions[Action](Arg1, Arg2);
            return result;
        }
    }
}
