using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCalculatorTrialRun1
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Add(string numbers)
        {
            if (numbers == string.Empty)
                return 0;
            else
                return int.Parse(numbers);
        }
    }

    
}
