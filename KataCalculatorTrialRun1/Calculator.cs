using System;
using System.Collections.Generic;
using System.Linq;

namespace KataCalculatorTrialRun1
{
    public class Calculator
    {
       
        public Calculator()
        {
          
        }

        public int Add(string numbers)
        {
            List<int> numbersCollection = new List<int>();
            if (numbers == string.Empty)
                return 0;
            else
                numbersCollection = convertNumbersToIntCollection(numbers);
            return numbersCollection.Sum();

        }

        private List<int> convertNumbersToIntCollection(string numbers)
        {
            char delimiter = getDelimiter(numbers);
            List<int> numbersInputted = new List<int>();
            numbersInputted = numbers.Split(delimiter)
                              .Select(x => int.Parse(x)).ToList<int>();
            return numbersInputted;

        }

        private char getDelimiter(string numbers)
        {
            return (numbers.Contains('\n')) ? '\n' : ',';         
        }
    }

    
}
