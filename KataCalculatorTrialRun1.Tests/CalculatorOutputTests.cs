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
    }
}


    
       