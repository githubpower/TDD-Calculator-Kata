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
            if (numbers == string.Empty)
                return 0;
            else
            {
                List<int> numbersCollection = new List<int>();
                numbersCollection = convertNumbersToIntCollection(numbers);

                ValidateNumbers(numbersCollection);
                return numbersCollection.Sum();
            }
        }

        private void ValidateNumbers(List<int> numbersInputted)
        {
            var isValid = !(hasNegativeValues(numbersInputted));
            if (!isValid)
            {
                string theInvalidNumbers = getNegativeValues(numbersInputted);
                throw new Exception("negatives not allowed " + theInvalidNumbers); 
            }
        }

        private bool hasNegativeValues(List<int> numbersInputted)
        {
            return numbersInputted.Any(i => i < 0);
        }

        private string getNegativeValues(List<int> numbersInputted)
        {
             string invalidNumbersSuppliedMsg = "";
             var negativeInts = numbersInputted.Where(i => i < 0);
         
                foreach (int i in negativeInts)
                {
                    invalidNumbersSuppliedMsg += i.ToString();
                    if (i != negativeInts.Last())
                    {
                        invalidNumbersSuppliedMsg += ",";
                    }

                }
            return invalidNumbersSuppliedMsg;
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
