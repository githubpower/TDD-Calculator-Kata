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

         [Test]
         public void Add_MultipleNumbersInNewLineSeperatedString_OutputSumOfNumbersAsInt()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(15, calculator.Add("1\n2\n3\n4\n5"));
         }

         [Test]
         public void Add_MultipleNumbersCommaAndNewLineSeperated_OutputSumOfNumbersAsInt()
        { 
            Calculator calculator =new Calculator();
            Assert.AreEqual(10, calculator.Add("2,2\n2,2\n2"));
        }

         [Test]
         public void Add_MultipleNumbersCustomSeperated_OutputSumOfNumbersAsInt()
         {
             Calculator calculator = new Calculator();
             Assert.AreEqual(3, calculator.Add("//;\n1;2"));
         }

         [Test]
         [ExpectedException(typeof(Exception))]
         public void Add_NegativeNumbers_ThrowsException()
         {
             Calculator calculator = new Calculator();
             calculator.Add("-1, 14,3");
         }

         [Test]
         public void Add_IncludesOneNegativeNumber_ThrowsExceptionWithCustomMessage()
         {
             Calculator calculator = new Calculator();
             var ex = Assert.Throws<Exception>(() => calculator.Add("-1"));
             Assert.That(ex.Message, Is.EqualTo("negatives not allowed -1"));
         }


    }
}


    
       