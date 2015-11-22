using System;
using System.Collections.Generic;
using System.Linq;

namespace KataCalculatorTrialRun1
{
    public class Calculator
    {
        private List<string> delimiterOptions = new List<string>() { ",", "\n" };
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
            
            char defaultInputDelimiter = ',';
            numbers = standardiseToDefaultDelimiter(numbers, defaultInputDelimiter);
            
            List<int> numbersInputted = new List<int>();
            numbersInputted = numbers.Split(defaultInputDelimiter)
                              .Select(x => int.Parse(x)).ToList<int>();
            return numbersInputted;
        }

      
        private string standardiseToDefaultDelimiter(string numbers, char defaultDelimiter)
        {

            if (numbers.StartsWith("//"))
            {   char customDelimiter = extractCustomDelimiter(numbers);
                numbers = removeCustomDelimiterInfoPrepended(numbers);
                numbers = numbers.Replace(customDelimiter, defaultDelimiter);               
            }

            if (numbers.Contains('\n'))
            {
                numbers = numbers.Replace("\n", defaultDelimiter.ToString());
            }
          
            return numbers;
        }

        
        private char extractCustomDelimiter(string numbers)
        {
            return Convert.ToChar((numbers.Substring(2, numbers.IndexOf("\n") - 2)));
        }

        private string removeCustomDelimiterInfoPrepended(string numbers)
        {
            numbers = numbers.Remove(0, numbers.IndexOf("\n") + 1);
            return numbers;
        }

    }

    
}
