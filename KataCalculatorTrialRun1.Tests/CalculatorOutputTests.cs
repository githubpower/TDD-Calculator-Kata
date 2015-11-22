using System;
using NUnit.Framework;

namespace KataCalculatorTrialRun1.Tests
{
     [TestFixture]
    public class CalculatorOutputTests
    {
         [Test]
         public void Add_EmptyValue_OutputZero()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(0, calculator.Add(""));
         }

         [Test]
         public void Add_SingleNumberString_OutputNumberAsInt()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(1, calculator.Add("1"));
         }

         [Test]
         public void Add_TwoNumbersInCommaSeperatedString_OutputSumOfNumbersAsInt()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(3, calculator.Add("1,2"));
         }

         [Test]
         public void Add_MultipleNumbersInCommaSeperatedString_OutputSumOfNumbersAsInt()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(15, calculator.Add("1,2,3,4,5"));
         }
    }
}


    
       