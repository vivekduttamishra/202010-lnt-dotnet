using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinance
{

    [TestClass]
    public class SimpleMathTests
    {
        [TestMethod]
        public void TestPlus()
        {
            var result = SimpleMath.Plus(2, 3);

            //Console.WriteLine("SimpleMath.Plus(2,3) => "+result);
        }

        [TestMethod]
        public void TestMinus()
        {
            var result = SimpleMath.Minus(2, 3);

            if (result != -1)
                throw new Exception("Minus Failed Expected -1 Found :" + result);

            //Console.WriteLine("SimpleMath.Minus(2,3) => " + result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var result = SimpleMath.Multiply(2, 3);

            if (result != 6)
                throw new AssertFailedException("Multiply Failed. Expected 6, Found:" + result);

            Console.WriteLine("SimpleMath.Multiply(2,3) => " + result);
        }
        [TestMethod]
        public void DivideShouldPerformIntegerDivision()
        {
            var result = SimpleMath.Divide(9, 4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideByZeroShouldThrowExceptionVerbose()
        {
            try
            {
                var result = SimpleMath.Divide(9, 0);  //should throw an exception!
                //Oh! we reached here. That mean exception was not thrown
                throw new AssertFailedException("Excpected Exception DivisioByZero was not thrown");
            }
            catch(DivideByZeroException ex)
            {
                //Hey!!! Test Passed. I don't need to do anything!
                //No News is a Good News!
            }
            
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroShouldThrowDivideByZeroException()
        {
            SimpleMath.Divide(9, 0); //should throw the exception
        }
    }
}
